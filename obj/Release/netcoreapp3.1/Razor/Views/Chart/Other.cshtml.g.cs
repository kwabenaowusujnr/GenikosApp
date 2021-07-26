#pragma checksum "E:\PROJECTS\GENIKOS\GenikosApp\Views\Chart\Other.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "486704feb77641fe78f6a649bc9ae9ab58b3e651"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chart_Other), @"mvc.1.0.view", @"/Views/Chart/Other.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\PROJECTS\GENIKOS\GenikosApp\Views\_ViewImports.cshtml"
using GenikosApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\PROJECTS\GENIKOS\GenikosApp\Views\_ViewImports.cshtml"
using GenikosApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"486704feb77641fe78f6a649bc9ae9ab58b3e651", @"/Views/Chart/Other.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9280cd403e9114f41b42698cec59645e918c4a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Chart_Other : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/plugins/jquery-knob/excanvas.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/plugins/jquery-knob/jquery.knob.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("styles", async() => {
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-12"">
            <div class=""card m-b-20"">
                <div class=""card-body"">

                    <h4 class=""mt-0 header-title"">Examples</h4>
                    <p class=""text-muted m-b-30 "">Nice, downward compatible, touchable, jQuery dial</p>

                    <div class=""row text-center"">
                        <div class=""col-lg-4 text-center"">
                            <h5 class=""font-16 m-b-20"">Disable display input</h5>
                            <input class=""knob"" data-width=""150"" data-fgcolor=""#7a6fbe"" data-displayinput=""false"" value=""35"">
                        </div>
                        <div class=""col-lg-4 text-center"">
                            <h5 class=""font-16 m-b-20"">Cursor mode</h5>
                            <input class=""knob"" data-width=""150"" data-cursor=""true"" data-fgcolor=""#4ac18e"" value=""29"">
                        </div>
                        <div class=""col-lg-4 text-center"">
                   ");
            WriteLiteral(@"         <h5 class=""font-16 m-b-20"">Display previous value</h5>
                            <input class=""knob"" data-width=""150"" data-min=""-100"" data-fgcolor=""#ffbb44"" data-displayprevious=""true"" value=""44"">
                        </div>
                    </div>

                    <div class=""row"">
                        <div class=""col-lg-4 text-center"">
                            <h5 class=""font-16 m-b-20"">Angle offset</h5>
                            <input class=""knob"" data-width=""150"" data-angleoffset=""90"" data-linecap=""round"" data-fgcolor=""#ea553d"" value=""35"">
                        </div>
                        <div class=""col-lg-4 text-center"">
                            <h5 class=""font-16 m-b-20""> 5-digit values, step 1000</h5>
                            <input class=""knob"" data-width=""150"" data-min=""-15000"" data-displayprevious=""true"" data-max=""15000"" data-step=""1000"" value=""-11000"" data-fgcolor=""#1d1e3a"">
                        </div>
                        <div class=""co");
            WriteLiteral(@"l-lg-4 text-center"">
                            <h5 class=""font-16 m-b-20"">Angle offset and arc</h5>
                            <input class=""knob"" data-width=""150"" data-cursor=""true"" data-fgcolor=""#f06292"" value=""29"">
                        </div>
                    </div>

                    <div class=""row"">
                        <div class=""col-lg-4 text-center"">
                            <h5 class=""font-16 m-b-20"">Readonly</h5>
                            <input class=""knob"" data-width=""150"" data-height=""150"" data-linecap=round
                                   data-fgColor=""#5468da"" value=""80"" data-skin=""tron"" data-angleOffset=""180""
                                   data-readOnly=true data-thickness="".1"" />
                        </div>
                        <div class=""col-lg-4 text-center"">
                            <h5 class=""font-16 m-b-20""> Angle offset and arc</h5>
                            <input class=""knob"" data-width=""150"" data-height=""150""
                   ");
            WriteLiteral(@"                data-displayPrevious=true data-fgColor=""#8d6e63"" data-skin=""tron""
                                   data-cursor=true value=""75"" data-thickness="".2"" data-angleOffset=-125
                                   data-angleArc=250 value=""44"" />

                        </div>
                    </div>

                </div>
            </div>
        </div> <!-- end col -->
    </div> <!-- end row -->

");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "486704feb77641fe78f6a649bc9ae9ab58b3e6517732", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "486704feb77641fe78f6a649bc9ae9ab58b3e6518831", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        $(function () {\r\n            $(\".knob\").knob();\r\n        });\r\n    </script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
