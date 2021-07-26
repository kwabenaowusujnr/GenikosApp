#pragma checksum "E:\PROJECTS\GENIKOS\GenikosApp\Views\UI\Alerts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c06fd8888a7cb0563cb347c2dc8e9db8a5d3eeea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UI_Alerts), @"mvc.1.0.view", @"/Views/UI/Alerts.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c06fd8888a7cb0563cb347c2dc8e9db8a5d3eeea", @"/Views/UI/Alerts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9280cd403e9114f41b42698cec59645e918c4a4", @"/Views/_ViewImports.cshtml")]
    public class Views_UI_Alerts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <div class=""row"">
        <div class=""col-lg-6"">
            <div class=""card m-b-20"">
                <div class=""card-body"">

                    <h4 class=""mt-0 header-title"">Examples</h4>
                    <p class=""text-muted m-b-30 "">
                        Alerts are available for any length of
                        text, as well as an optional dismiss button. For proper styling, use one
                        of the four <strong>required</strong> contextual classes (e.g., <code class=""highlighter-rouge"">.alert-success</code>). For inline
                        dismissal, use the alerts jQuery plugin.
                    </p>

                    <div");
            BeginWriteAttribute("class", " class=\"", 692, "\"", 700, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""alert alert-success"" role=""alert"">
                            <strong>Well done!</strong> You successfully read this important alert message.
                        </div>
                        <div class=""alert alert-info"" role=""alert"">
                            <strong>Heads up!</strong> This alert needs your attention, but it's not super important.
                        </div>
                        <div class=""alert alert-warning"" role=""alert"">
                            <strong>Warning!</strong> Better check yourself, you're not looking too good.
                        </div>
                        <div class=""alert alert-danger"" role=""alert"">
                            <strong>Oh snap!</strong> Change a few things up and try submitting again.
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class=""col-lg-6"">
            <div class=""card m-b-20"">
         ");
            WriteLiteral(@"       <div class=""card-body"">

                    <h4 class=""mt-0 header-title"">Link color</h4>
                    <p class=""text-muted m-b-30 "">
                        Use the <code class=""highlighter-rouge"">.alert-link</code> utility class to
                        quickly provide matching colored links within any alert.
                    </p>

                    <div");
            BeginWriteAttribute("class", " class=\"", 2113, "\"", 2121, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""alert alert-success"" role=""alert"">
                            <strong>Well done!</strong> You successfully read <a href=""#"" class=""alert-link"">this important alert message</a>.
                        </div>
                        <div class=""alert alert-info"" role=""alert"">
                            <strong>Heads up!</strong> This <a href=""#"" class=""alert-link"">alert needs your attention</a>, but it's not super important.
                        </div>
                        <div class=""alert alert-warning"" role=""alert"">
                            <strong>Warning!</strong> Better check yourself, you're <a href=""#"" class=""alert-link"">not looking too good</a>.
                        </div>
                        <div class=""alert alert-danger"" role=""alert"">
                            <strong>Oh snap!</strong> <a href=""#"" class=""alert-link"">Change a few things up</a> and try submitting again.
                        </div>
                    </div>
  ");
            WriteLiteral(@"              </div>
            </div>
        </div>
    </div>


    <div class=""row"">
        <div class=""col-lg-6"">
            <div class=""card m-b-20"">
                <div class=""card-body"">

                    <h4 class=""mt-0 header-title"">Dismissing</h4>
                    <p class=""text-muted m-b-30 "">You can see this in action with a live demo:</p>

                    <div");
            BeginWriteAttribute("class", " class=\"", 3550, "\"", 3558, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""alert alert-success alert-dismissible fade show"" role=""alert"">
                            <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                                <span aria-hidden=""true"">&times;</span>
                            </button>
                            <strong>Well done!</strong> You successfully read this important alert message.
                        </div>
                        <div class=""alert alert-info alert-dismissible fade show"" role=""alert"">
                            <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                                <span aria-hidden=""true"">&times;</span>
                            </button>
                            <strong>Heads up!</strong> This alert needs your attention, but it's not super important.
                        </div>
                        <div class=""alert alert-warning alert-dismissible fade show"" role=""alert");
            WriteLiteral(@""">
                            <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                                <span aria-hidden=""true"">&times;</span>
                            </button>
                            <strong>Warning!</strong> Better check yourself, you're not looking too good.
                        </div>
                        <div class=""alert alert-danger alert-dismissible fade show"" role=""alert"">
                            <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                                <span aria-hidden=""true"">&times;</span>
                            </button>
                            <strong>Oh snap!</strong> Change a few things up and try submitting again.
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class=""col-lg-6"">
            <div class=""card m-b-20"">
                <div class=""card-body"">

      ");
            WriteLiteral("              <h4 class=\"mt-0 header-title\">Additional content</h4>\r\n                    <p class=\"text-muted m-b-30 \">Alerts can also contain additional HTML elements like headings and paragraphs.</p>\r\n\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 5836, "\"", 5844, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""alert alert-success"" role=""alert"">
                            <h4 class=""alert-heading font-18"">Well done!</h4>
                            <p>Aww yeah, you successfully read this important alert message. This example text is going to run a bit longer so that you can see how spacing within an alert works with this kind of content.</p>
                            <p class=""mb-0"">Whenever you need to, be sure to use margin utilities to keep things nice and tidy.</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>


    <div class=""row"">
        <div class=""col-lg-6"">
            <div class=""card m-b-20"">
                <div class=""card-body"">

                    <h4 class=""mt-0 header-title"">Examples</h4>
                    <p class=""text-muted m-b-30 "">
                        Alerts are available for any length of
                        text, as well as an optional dism");
            WriteLiteral(@"iss button. For proper styling, use one
                        of the four <strong>required</strong> contextual classes (e.g., <code class=""highlighter-rouge"">.alert-success .bg-**</code>). For inline
                        dismissal, use the alerts jQuery plugin.
                    </p>

                    <div");
            BeginWriteAttribute("class", " class=\"", 7191, "\"", 7199, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""alert alert-success bg-success text-white"" role=""alert"">
                            <strong>Well done!</strong> You successfully read this important alert message.
                        </div>
                        <div class=""alert alert-info bg-info text-white"" role=""alert"">
                            <strong>Heads up!</strong> This alert needs your attention, but it's not super important.
                        </div>
                        <div class=""alert alert-warning bg-warning text-white"" role=""alert"">
                            <strong>Warning!</strong> Better check yourself, you're not looking too good.
                        </div>
                        <div class=""alert alert-danger bg-danger text-white"" role=""alert"">
                            <strong>Oh snap!</strong> Change a few things up and try submitting again.
                        </div>
                    </div>
                </div>
            </div>
        </div>");
            WriteLiteral("\r\n    </div>\r\n");
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