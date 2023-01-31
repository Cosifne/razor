﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

using System;
using Microsoft.CodeAnalysis.Host;
using Microsoft.CodeAnalysis.Razor.ProjectSystem;

namespace Microsoft.CodeAnalysis.Razor;

internal abstract class ErrorReporter : IWorkspaceService
{
    public abstract void ReportError(Exception exception);

    public abstract void ReportError(Exception exception, IProjectSnapshot? project);

    public abstract void ReportError(Exception exception, Project workspaceProject);
}
