#pragma checksum "E:\PROJECTS\GENIKOS\GenikosApp\Views\UI\Pagination.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff2be2938e4fadde02b53ca7021244643a8cf381"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UI_Pagination), @"mvc.1.0.view", @"/Views/UI/Pagination.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff2be2938e4fadde02b53ca7021244643a8cf381", @"/Views/UI/Pagination.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9280cd403e9114f41b42698cec59645e918c4a4", @"/Views/_ViewImports.cshtml")]
    public class Views_UI_Pagination : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

    <div class=""row"">
        <div class=""col-lg-6"">
            <div class=""card m-b-20"">
                <div class=""card-body"">

                    <h4 class=""mt-0 header-title"">Default Example</h4>
                    <p class=""text-muted m-b-30 "">Pagination links indicate a series of related content exists across multiple pages.</p>

                    <nav aria-label=""Page navigation example"">
                        <ul class=""pagination"">
                            <li class=""page-item""><a class=""page-link"" href=""#"">Previous</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">Next</a></li>
                        </ul>
                    </nav>

                    <nav a");
            WriteLiteral(@"ria-label=""Page navigation example"">
                        <ul class=""pagination"">
                            <li class=""page-item"">
                                <a class=""page-link"" href=""#"" aria-label=""Previous"">
                                    <span aria-hidden=""true"">&laquo;</span>
                                    <span class=""sr-only"">Previous</span>
                                </a>
                            </li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                            <li class=""page-item"">
                                <a class=""page-link"" href=""#"" aria-label=""Next"">
                                    <span aria-hidden=""true"">&raquo;</span>
                                    <span class=""sr-only"">Next</span>
                ");
            WriteLiteral(@"                </a>
                            </li>
                        </ul>
                    </nav>
                </div>
            </div>
        </div>

        <div class=""col-lg-6"">
            <div class=""card m-b-20"">
                <div class=""card-body"">

                    <h4 class=""mt-0 header-title"">Disabled and active states</h4>
                    <p class=""text-muted m-b-30 "">
                        Pagination links are customizable for
                        different circumstances. Use <code class=""highlighter-rouge"">.disabled</code> for links that appear
                        un-clickable and <code class=""highlighter-rouge"">.active</code> to
                        indicate the current page.
                    </p>

                    <nav aria-label=""..."">
                        <ul class=""pagination"">
                            <li class=""page-item disabled"">
                                <a class=""page-link"" href=""#"" tabindex=""-1"">Previou");
            WriteLiteral(@"s</a>
                            </li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
                            <li class=""page-item active"">
                                <a class=""page-link"" href=""#"">2 <span class=""sr-only"">(current)</span></a>
                            </li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                            <li class=""page-item"">
                                <a class=""page-link"" href=""#"">Next</a>
                            </li>
                        </ul>
                    </nav>

                    <nav aria-label=""..."">
                        <ul class=""pagination"">
                            <li class=""page-item disabled"">
                                <span class=""page-link"">Previous</span>
                            </li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
                      ");
            WriteLiteral(@"      <li class=""page-item active"">
                                <span class=""page-link"">
                                    2
                                    <span class=""sr-only"">(current)</span>
                                </span>
                            </li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                            <li class=""page-item"">
                                <a class=""page-link"" href=""#"">Next</a>
                            </li>
                        </ul>
                    </nav>
                </div>
            </div>
        </div> <!-- end col -->
    </div> <!-- end row -->

    <div class=""row"">
        <div class=""col-lg-6"">
            <div class=""card m-b-20"">
                <div class=""card-body"">

                    <h4 class=""mt-0 header-title"">Sizing</h4>
                    <p class=""text-muted m-b-30 "">
                        Fancy larger or smaller pagination? Add
   ");
            WriteLiteral(@"                     <code class=""highlighter-rouge"">.pagination-lg</code> or <code class=""highlighter-rouge"">.pagination-sm</code> for additional
                        sizes.
                    </p>

                    <nav aria-label=""..."">
                        <ul class=""pagination pagination-lg"">
                            <li class=""page-item disabled"">
                                <a class=""page-link"" href=""#"" tabindex=""-1"">Previous</a>
                            </li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                            <li class=""page-item"">
                                <a class=""page-link"" href=""#"">Next</a>
                            </li>
                        </ul>
                    </nav>

                    <nav ar");
            WriteLiteral(@"ia-label=""..."">
                        <ul class=""pagination pagination-sm"">
                            <li class=""page-item disabled"">
                                <a class=""page-link"" href=""#"" tabindex=""-1"">Previous</a>
                            </li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                            <li class=""page-item"">
                                <a class=""page-link"" href=""#"">Next</a>
                            </li>
                        </ul>
                    </nav>
                </div>
            </div>
        </div> <!-- end col -->

        <div class=""col-lg-6"">
            <div class=""card m-b-20"">
                <div class=""card-body"">

                    <h4 class=""mt-0 header-title"">Alignment</h4>
     ");
            WriteLiteral(@"               <p class=""text-muted m-b-30 "">
                        Change the alignment of pagination
                        components with flexbox utilities.
                    </p>

                    <nav aria-label=""Page navigation example"">
                        <ul class=""pagination justify-content-center"">
                            <li class=""page-item disabled"">
                                <a class=""page-link"" href=""#"" tabindex=""-1"">Previous</a>
                            </li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                            <li class=""page-item"">
                                <a class=""page-link"" href=""#"">Next</a>
                            </li>
                        </ul>
                    </nav>

           ");
            WriteLiteral(@"         <nav aria-label=""Page navigation example"">
                        <ul class=""pagination justify-content-end"">
                            <li class=""page-item disabled"">
                                <a class=""page-link"" href=""#"" tabindex=""-1"">Previous</a>
                            </li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                            <li class=""page-item"">
                                <a class=""page-link"" href=""#"">Next</a>
                            </li>
                        </ul>
                    </nav>
                </div>
            </div>
        </div> <!-- end col -->
    </div> <!-- end row -->");
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