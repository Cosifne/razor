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
#nullable restore
#line (1,2)-(2,1) "x:\dir\subdir\Test\TestComponent.cshtml"
using Microsoft.AspNetCore.Components.Web

#nullable disable
    ;
#nullable restore
#line (2,2)-(3,1) "x:\dir\subdir\Test\TestComponent.cshtml"
using Microsoft.AspNetCore.Components.Rendering

#line default
#line hidden
#nullable disable
    ;
    #nullable restore
    public partial class TestComponent : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 TestCssScope>Element with no attributes</h1>\r\n");
            __builder.OpenElement(1, "parent");
            __builder.AddAttribute(2, "with-attributes", "yes");
            __builder.AddAttribute(3, "with-csharp-attribute-value", 
#nullable restore
#line (4,62)-(4,65) "x:\dir\subdir\Test\TestComponent.cshtml"
123

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(4, "TestCssScope");
            __builder.AddMarkupContent(5, "<child TestCssScope></child>\r\n    ");
            __builder.AddMarkupContent(6, "<child has multiple attributes=\"some with values\" TestCssScope>With text</child>\r\n    ");
            __builder.OpenComponent<global::Test.TemplatedComponent>(7);
            __builder.AddAttribute(8, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(9, "<span id=\"hello\" TestCssScope>This is in child content</span>");
            }
            ));
            __builder.AddComponentReferenceCapture(10, (__value) => {
#nullable restore
#line (7,31)-(7,51) "x:\dir\subdir\Test\TestComponent.cshtml"
myComponentReference

#line default
#line hidden
#nullable disable
                 = (Test.TemplatedComponent)__value;
            }
            );
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line (11,2)-(13,1) "x:\dir\subdir\Test\TestComponent.cshtml"
if (DateTime.Now.Year > 1950)
{

#line default
#line hidden
#nullable disable

            __builder.OpenElement(11, "with-ref-capture");
            __builder.AddAttribute(12, "some-attr");
            __builder.AddAttribute(13, "TestCssScope");
            __builder.AddElementReferenceCapture(14, (__value) => {
#nullable restore
#line (13,39)-(13,57) "x:\dir\subdir\Test\TestComponent.cshtml"
myElementReference

#line default
#line hidden
#nullable disable
                 = __value;
            }
            );
            __builder.AddContent(15, "Content");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "id", "myElem");
            __builder.AddAttribute(19, "another-attr", "Another attr value");
            __builder.AddAttribute(20, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line (14,31)-(14,41) "x:\dir\subdir\Test\TestComponent.cshtml"
myVariable

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => myVariable = __value, myVariable));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(22, "TestCssScope");
            __builder.CloseElement();
#nullable restore
#line (15,1)-(16,1) "x:\dir\subdir\Test\TestComponent.cshtml"
}

#line default
#line hidden
#nullable disable

        }
        #pragma warning restore 1998
#nullable restore
#line (17,8)-(26,1) "x:\dir\subdir\Test\TestComponent.cshtml"

    ElementReference myElementReference;
    TemplatedComponent myComponentReference;
    string myVariable;

    void MethodRenderingMarkup(RenderTreeBuilder __builder)
    {
        for (var i = 0; i < 10; i++)
        {

#line default
#line hidden
#nullable disable

        __builder.OpenElement(23, "li");
        __builder.AddAttribute(24, "data-index", 
#nullable restore
#line (26,29)-(26,30) "x:\dir\subdir\Test\TestComponent.cshtml"
i

#line default
#line hidden
#nullable disable
        );
        __builder.AddAttribute(25, "TestCssScope");
        __builder.AddContent(26, "Something ");
        __builder.AddContent(27, 
#nullable restore
#line (26,42)-(26,43) "x:\dir\subdir\Test\TestComponent.cshtml"
i

#line default
#line hidden
#nullable disable
        );
        __builder.CloseElement();
#nullable restore
#line (27,1)-(33,1) "x:\dir\subdir\Test\TestComponent.cshtml"
        }

        System.GC.KeepAlive(myElementReference);
        System.GC.KeepAlive(myComponentReference);
        System.GC.KeepAlive(myVariable);
    }

#line default
#line hidden
#nullable disable

    }
}
#pragma warning restore 1591
