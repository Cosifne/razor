﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Telemetry;
using Microsoft.CodeAnalysis.Razor.Logging;
using Microsoft.CodeAnalysis.Razor.Workspaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.LanguageServer.Protocol;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using StreamJsonRpc;

namespace Microsoft.AspNetCore.Razor.LanguageServer.Hosting;

internal sealed partial class RazorLanguageServerHost : IDisposable
{
    private readonly RazorLanguageServer _server;
    private readonly JsonRpc _jsonRpc;

    private bool _disposed;

    private RazorLanguageServerHost(RazorLanguageServer server, JsonRpc jsonRpc)
    {
        _server = server;
        _jsonRpc = jsonRpc;
    }

    public void Dispose()
    {
        if (_disposed)
        {
            return;
        }

        _disposed = true;

        _jsonRpc.Dispose();
    }

    public static RazorLanguageServerHost Create(
        Stream input,
        Stream output,
        ILoggerFactory loggerFactory,
        ITelemetryReporter telemetryReporter,
        Action<IServiceCollection>? configure = null,
        LanguageServerFeatureOptions? featureOptions = null,
        RazorLSPOptions? razorLSPOptions = null,
        ILspServerActivationTracker? lspServerActivationTracker = null,
        TraceSource? traceSource = null)
    {
        var (jsonRpc, jsonSerializer) = CreateJsonRpc(input, output);

        // This ensures each request is a separate activity in LogHub
        jsonRpc.ActivityTracingStrategy = new CorrelationManagerTracingStrategy
        {
            TraceSource = traceSource
        };

        var server = new RazorLanguageServer(
            jsonRpc,
            jsonSerializer,
            loggerFactory,
            featureOptions,
            configure,
            razorLSPOptions,
            lspServerActivationTracker,
            telemetryReporter);

        return new RazorLanguageServerHost(server, jsonRpc);
    }

    private static (JsonRpc, JsonSerializer) CreateJsonRpc(Stream input, Stream output)
    {
        var messageFormatter = new JsonMessageFormatter();
        messageFormatter.JsonSerializer.AddVSInternalExtensionConverters();
        messageFormatter.JsonSerializer.ContractResolver = new CamelCasePropertyNamesContractResolver();

        var jsonRpc = new JsonRpc(new HeaderDelimitedMessageHandler(output, input, messageFormatter));

        // Get more information about exceptions that occur during RPC method invocations.
        jsonRpc.ExceptionStrategy = ExceptionProcessing.ISerializable;

        return (jsonRpc, messageFormatter.JsonSerializer);
    }

    public void StartListening()
    {
        _jsonRpc.StartListening();
    }

    public Task WaitForExitAsync()
    {
        var lspServices = _server.GetLspServices();
        if (lspServices is LspServices razorServices)
        {
            // If the LSP Server is already disposed it means the server has already exited.
            if (razorServices.IsDisposed)
            {
                return Task.CompletedTask;
            }
            else
            {
                var lifeCycleManager = razorServices.GetRequiredService<RazorLifeCycleManager>();
                return lifeCycleManager.WaitForExit;
            }
        }
        else
        {
            throw new NotImplementedException($"LspServices should always be of type {nameof(LspServices)}.");
        }
    }

    internal T GetRequiredService<T>() where T : notnull
    {
        var lspServices = _server.GetLspServices();
        return lspServices.GetRequiredService<T>();
    }
}
