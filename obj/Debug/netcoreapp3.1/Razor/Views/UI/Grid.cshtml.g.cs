#pragma checksum "E:\PROJECTS\GENIKOS\GenikosApp\Views\UI\Grid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afe9727cd0ced43206ea69c63ac17386c734501b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UI_Grid), @"mvc.1.0.view", @"/Views/UI/Grid.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afe9727cd0ced43206ea69c63ac17386c734501b", @"/Views/UI/Grid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9280cd403e9114f41b42698cec59645e918c4a4", @"/Views/_ViewImports.cshtml")]
    public class Views_UI_Grid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-12"">
            <div class=""card m-b-20"">
                <div class=""card-body"">

                    <h4 class=""mt-0 header-title"">Grid options</h4>
                    <p class=""text-muted m-b-30 "">
                        See how aspects of the Bootstrap grid
                        system work across multiple devices with a handy table.
                    </p>

                    <div class=""table-responsive"">
                        <table class=""table table-bordered table-striped"">
                            <thead>
                                <tr>
                                    <th></th>
                                    <th class=""text-center"">
                                        Extra small<br>
                                        <small>&lt;576px</small>
                                    </th>
                                    <th class=""text-center"">
                                        Small<br>
     ");
            WriteLiteral(@"                                   <small>???576px</small>
                                    </th>
                                    <th class=""text-center"">
                                        Medium<br>
                                        <small>???768px</small>
                                    </th>
                                    <th class=""text-center"">
                                        Large<br>
                                        <small>???992px</small>
                                    </th>
                                    <th class=""text-center"">
                                        Extra large<br>
                                        <small>???1200px</small>
                                    </th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <th class=""text-nowrap"" scope=""row"">Grid behavior</th>
              ");
            WriteLiteral(@"                      <td>Horizontal at all times</td>
                                    <td colspan=""4"">Collapsed to start, horizontal above breakpoints</td>
                                </tr>
                                <tr>
                                    <th class=""text-nowrap"" scope=""row"">Max container width</th>
                                    <td>None (auto)</td>
                                    <td>540px</td>
                                    <td>720px</td>
                                    <td>960px</td>
                                    <td>1140px</td>
                                </tr>
                                <tr>
                                    <th class=""text-nowrap"" scope=""row"">Class prefix</th>
                                    <td><code>.col-</code></td>
                                    <td><code>.col-sm-</code></td>
                                    <td><code>.col-md-</code></td>
                                    <td><code>.col");
            WriteLiteral(@"-lg-</code></td>
                                    <td><code>.col-xl-</code></td>
                                </tr>
                                <tr>
                                    <th class=""text-nowrap"" scope=""row""># of columns</th>
                                    <td colspan=""5"">12</td>
                                </tr>
                                <tr>
                                    <th class=""text-nowrap"" scope=""row"">Gutter width</th>
                                    <td colspan=""5"">20px (10px on each side of a column)</td>
                                </tr>
                                <tr>
                                    <th class=""text-nowrap"" scope=""row"">Nestable</th>
                                    <td colspan=""5"">Yes</td>
                                </tr>
                                <tr>
                                    <th class=""text-nowrap"" scope=""row"">Offsets</th>
                                    <td colspan=""5"">Yes</");
            WriteLiteral(@"td>
                                </tr>
                                <tr>
                                    <th class=""text-nowrap"" scope=""row"">Column ordering</th>
                                    <td colspan=""5"">Yes</td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div> <!-- end col -->

    </div> <!-- end row -->
");
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
