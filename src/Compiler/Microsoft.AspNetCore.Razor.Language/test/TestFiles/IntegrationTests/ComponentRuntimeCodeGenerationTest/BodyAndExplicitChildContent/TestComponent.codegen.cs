﻿// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
    #line default
    #line hidden
    #nullable restore
    public partial class TestComponent : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line (1,3)-(1,49) "x:\dir\subdir\Test\TestComponent.cshtml"
 RenderFragment<string> header = (context) => 

#line default
#line hidden
#nullable disable

            (__builder2) => {
                __builder2.OpenElement(0, "div");
                __builder2.AddContent(1, 
#nullable restore
#line (1,56)-(1,82) "x:\dir\subdir\Test\TestComponent.cshtml"
context.ToLowerInvariant()

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
#nullable restore
#line (1,88)-(1,90) "x:\dir\subdir\Test\TestComponent.cshtml"
; 

#line default
#line hidden
#nullable disable

            __builder.OpenComponent<global::Test.MyComponent>(2);
            __builder.AddComponentParameter(3, "Header", (global::Microsoft.AspNetCore.Components.RenderFragment<System.String>)(
#nullable restore
#line (2,22)-(2,28) "x:\dir\subdir\Test\TestComponent.cshtml"
header

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(5, "Some Content");
            }
            ));
            __builder.AddAttribute(6, "Footer", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(7, "Bye!");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
