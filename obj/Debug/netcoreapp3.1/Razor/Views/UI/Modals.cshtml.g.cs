#pragma checksum "E:\PROJECTS\GENIKOS\GenikosApp\Views\UI\Modals.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "126eebdbe3a951e6e9040d19f63b26cb7ba303e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UI_Modals), @"mvc.1.0.view", @"/Views/UI/Modals.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"126eebdbe3a951e6e9040d19f63b26cb7ba303e4", @"/Views/UI/Modals.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9280cd403e9114f41b42698cec59645e918c4a4", @"/Views/_ViewImports.cshtml")]
    public class Views_UI_Modals : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-12"">
            <div class=""card m-b-30"">
                <div class=""card-body"">

                    <h4 class=""mt-0 header-title"">Modals Examples</h4>
                    <p class=""text-muted m-b-30 "">
                        Modals are streamlined, but flexible
                        dialog prompts powered by JavaScript. They support a number of use cases
                        from user notification to completely custom content and feature a
                        handful of helpful subcomponents, sizes, and more.
                    </p>

                    <div class=""modal bs-example-modal"" tabindex=""-1"" role=""dialog"">
                        <div class=""modal-dialog"" role=""document"">
                            <div class=""modal-content"">
                                <div class=""modal-header"">
                                    <h5 class=""modal-title mt-0"">Modal title</h5>
                                    <button type=""button");
            WriteLiteral(@""" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                        <span aria-hidden=""true"">&times;</span>
                                    </button>
                                </div>
                                <div class=""modal-body"">
                                    <p>One fine body&hellip;</p>
                                </div>
                                <div class=""modal-footer"">
                                    <button type=""button"" class=""btn btn-primary"">Save changes</button>
                                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                                </div>
                            </div><!-- /.modal-content -->
                        </div><!-- /.modal-dialog -->
                    </div><!-- /.modal -->


                    <div class=""row"">

                        <div class=""col-sm-6 col-md-3 m-t-30"">
                            <div class=""");
            WriteLiteral(@" text-center"">
                                <p class=""text-muted"">Standard Modal</p>
                                <button type=""button"" class=""btn btn-primary waves-effect waves-light"" data-toggle=""modal"" data-target=""#myModal"">Standard Modal</button>
                            </div>

                            <!-- sample modal content -->
                            <div id=""myModal"" class=""modal fade"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
                                <div class=""modal-dialog"">
                                    <div class=""modal-content"">
                                        <div class=""modal-header"">
                                            <h5 class=""modal-title mt-0"" id=""myModalLabel"">Modal Heading</h5>
                                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">??</button>
                                        </div>
                                     ");
            WriteLiteral(@"   <div class=""modal-body"">
                                            <h5>Overflowing text to show scroll behavior</h5>
                                            <p>
                                                Cras mattis consectetur purus sit amet fermentum.
                                                Cras justo odio, dapibus ac facilisis in,
                                                egestas eget quam. Morbi leo risus, porta ac
                                                consectetur ac, vestibulum at eros.
                                            </p>
                                            <p>
                                                Praesent commodo cursus magna, vel scelerisque
                                                nisl consectetur et. Vivamus sagittis lacus vel
                                                augue laoreet rutrum faucibus dolor auctor.
                                            </p>
                                            <p>");
            WriteLiteral(@"
                                                Aenean lacinia bibendum nulla sed consectetur.
                                                Praesent commodo cursus magna, vel scelerisque
                                                nisl consectetur et. Donec sed odio dui. Donec
                                                ullamcorper nulla non metus auctor
                                                fringilla.
                                            </p>
                                            <p>
                                                Cras mattis consectetur purus sit amet fermentum.
                                                Cras justo odio, dapibus ac facilisis in,
                                                egestas eget quam. Morbi leo risus, porta ac
                                                consectetur ac, vestibulum at eros.
                                            </p>
                                            <p>
                       ");
            WriteLiteral(@"                         Praesent commodo cursus magna, vel scelerisque
                                                nisl consectetur et. Vivamus sagittis lacus vel
                                                augue laoreet rutrum faucibus dolor auctor.
                                            </p>
                                            <p>
                                                Aenean lacinia bibendum nulla sed consectetur.
                                                Praesent commodo cursus magna, vel scelerisque
                                                nisl consectetur et. Donec sed odio dui. Donec
                                                ullamcorper nulla non metus auctor
                                                fringilla.
                                            </p>
                                            <p>
                                                Cras mattis consectetur purus sit amet fermentum.
                                ");
            WriteLiteral(@"                Cras justo odio, dapibus ac facilisis in,
                                                egestas eget quam. Morbi leo risus, porta ac
                                                consectetur ac, vestibulum at eros.
                                            </p>
                                            <p>
                                                Praesent commodo cursus magna, vel scelerisque
                                                nisl consectetur et. Vivamus sagittis lacus vel
                                                augue laoreet rutrum faucibus dolor auctor.
                                            </p>
                                            <p>
                                                Aenean lacinia bibendum nulla sed consectetur.
                                                Praesent commodo cursus magna, vel scelerisque
                                                nisl consectetur et. Donec sed odio dui. Donec
              ");
            WriteLiteral(@"                                  ullamcorper nulla non metus auctor
                                                fringilla.
                                            </p>
                                        </div>
                                        <div class=""modal-footer"">
                                            <button type=""button"" class=""btn btn-secondary waves-effect"" data-dismiss=""modal"">Close</button>
                                            <button type=""button"" class=""btn btn-primary waves-effect waves-light"">Save changes</button>
                                        </div>
                                    </div><!-- /.modal-content -->
                                </div><!-- /.modal-dialog -->
                            </div><!-- /.modal -->
                        </div>

                        <div class=""col-sm-6 col-md-3 m-t-30"">
                            <div class=""text-center"">
                                <p class=""text-muted"">Large moda");
            WriteLiteral(@"l</p>
                                <!-- Large modal -->
                                <button type=""button"" class=""btn btn-primary waves-effect waves-light"" data-toggle=""modal"" data-target="".bs-example-modal-lg"">Large modal</button>
                            </div>


                            <!--  Modal content for the above example -->
                            <div class=""modal fade bs-example-modal-lg"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myLargeModalLabel"" aria-hidden=""true"">
                                <div class=""modal-dialog modal-lg"">
                                    <div class=""modal-content"">
                                        <div class=""modal-header"">
                                            <h5 class=""modal-title mt-0"" id=""myLargeModalLabel"">Large modal</h5>
                                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">??</button>
                                        </div>
               ");
            WriteLiteral(@"                         <div class=""modal-body"">
                                            <p>
                                                Cras mattis consectetur purus sit amet fermentum.
                                                Cras justo odio, dapibus ac facilisis in,
                                                egestas eget quam. Morbi leo risus, porta ac
                                                consectetur ac, vestibulum at eros.
                                            </p>
                                            <p>
                                                Praesent commodo cursus magna, vel scelerisque
                                                nisl consectetur et. Vivamus sagittis lacus vel
                                                augue laoreet rutrum faucibus dolor auctor.
                                            </p>
                                            <p>
                                                Aenean lacinia bibendum");
            WriteLiteral(@" nulla sed consectetur.
                                                Praesent commodo cursus magna, vel scelerisque
                                                nisl consectetur et. Donec sed odio dui. Donec
                                                ullamcorper nulla non metus auctor
                                                fringilla.
                                            </p>
                                        </div>
                                    </div><!-- /.modal-content -->
                                </div><!-- /.modal-dialog -->
                            </div><!-- /.modal -->
                        </div>

                        <div class=""col-sm-6 col-md-3 m-t-30"">
                            <div class=""text-center"">
                                <p class=""text-muted"">Small modal</p>
                                <!-- Small modal -->
                                <button type=""button"" class=""btn btn-primary waves-effect waves-light"" d");
            WriteLiteral(@"ata-toggle=""modal"" data-target="".bs-example-modal-sm"">Small modal</button>
                            </div>

                            <div class=""modal fade bs-example-modal-sm"" tabindex=""-1"" role=""dialog"" aria-labelledby=""mySmallModalLabel"" aria-hidden=""true"">
                                <div class=""modal-dialog modal-sm"">
                                    <div class=""modal-content"">
                                        <div class=""modal-header"">
                                            <h5 class=""modal-title mt-0"" id=""mySmallModalLabel"">Small modal</h5>
                                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">??</button>
                                        </div>
                                        <div class=""modal-body"">
                                            <p>
                                                Cras mattis consectetur purus sit amet fermentum.
                                           ");
            WriteLiteral(@"     Cras justo odio, dapibus ac facilisis in,
                                                egestas eget quam. Morbi leo risus, porta ac
                                                consectetur ac, vestibulum at eros.
                                            </p>
                                            <p>
                                                Praesent commodo cursus magna, vel scelerisque
                                                nisl consectetur et. Vivamus sagittis lacus vel
                                                augue laoreet rutrum faucibus dolor auctor.
                                            </p>
                                            <p>
                                                Aenean lacinia bibendum nulla sed consectetur.
                                                Praesent commodo cursus magna, vel scelerisque
                                                nisl consectetur et. Donec sed odio dui. Donec
                         ");
            WriteLiteral(@"                       ullamcorper nulla non metus auctor
                                                fringilla.
                                            </p>
                                        </div>
                                    </div><!-- /.modal-content -->
                                </div><!-- /.modal-dialog -->
                            </div><!-- /.modal -->
                        </div>

                        <div class=""col-sm-6 col-md-3 m-t-30"">
                            <div class=""text-center"">
                                <p class=""text-muted"">Center modal</p>
                                <!-- Small modal -->
                                <button type=""button"" class=""btn btn-primary waves-effect waves-light"" data-toggle=""modal"" data-target="".bs-example-modal-center"">Center modal</button>
                            </div>

                            <div class=""modal fade bs-example-modal-center"" tabindex=""-1"" role=""dialog"" aria-labelledby=""m");
            WriteLiteral(@"ySmallModalLabel"" aria-hidden=""true"">
                                <div class=""modal-dialog modal-dialog-centered"">
                                    <div class=""modal-content"">
                                        <div class=""modal-header"">
                                            <h5 class=""modal-title mt-0"">Center modal</h5>
                                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">??</button>
                                        </div>
                                        <div class=""modal-body"">
                                            <p>
                                                Cras mattis consectetur purus sit amet fermentum.
                                                Cras justo odio, dapibus ac facilisis in,
                                                egestas eget quam. Morbi leo risus, porta ac
                                                consectetur ac, vestibulum at eros.
              ");
            WriteLiteral(@"                              </p>
                                            <p>
                                                Praesent commodo cursus magna, vel scelerisque
                                                nisl consectetur et. Vivamus sagittis lacus vel
                                                augue laoreet rutrum faucibus dolor auctor.
                                            </p>
                                            <p>
                                                Aenean lacinia bibendum nulla sed consectetur.
                                                Praesent commodo cursus magna, vel scelerisque
                                                nisl consectetur et. Donec sed odio dui. Donec
                                                ullamcorper nulla non metus auctor
                                                fringilla.
                                            </p>
                                        </div>
                        ");
            WriteLiteral(@"            </div><!-- /.modal-content -->
                                </div><!-- /.modal-dialog -->
                            </div><!-- /.modal -->
                        </div>
                    </div> <!-- end row -->
                </div>
            </div>
        </div>
    </div><!-- end row -->

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
