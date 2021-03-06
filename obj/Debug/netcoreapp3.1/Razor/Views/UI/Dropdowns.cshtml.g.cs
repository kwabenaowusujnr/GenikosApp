#pragma checksum "E:\PROJECTS\GENIKOS\GenikosApp\Views\UI\Dropdowns.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8ec14fe83a4fb9e044d7d6fbc01ea7a5849857b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UI_Dropdowns), @"mvc.1.0.view", @"/Views/UI/Dropdowns.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8ec14fe83a4fb9e044d7d6fbc01ea7a5849857b", @"/Views/UI/Dropdowns.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9280cd403e9114f41b42698cec59645e918c4a4", @"/Views/_ViewImports.cshtml")]
    public class Views_UI_Dropdowns : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

    <div class=""row"">
        <div class=""col-lg-6"">
            <div class=""card m-b-30"">
                <div class=""card-body"">

                    <h4 class=""mt-0 header-title"">Single button dropdowns</h4>
                    <p class=""text-muted m-b-30 "">
                        Any single <code class=""highlighter-rouge"">.btn</code> can be turned into a dropdown
                        toggle with some markup changes. Here’s how you can put them to work
                        with either <code class=""highlighter-rouge"">&lt;button&gt;</code>
                        elements:
                    </p>

                    <div class=""row"">
                        <div class=""col-sm-6"">
                            <div class=""dropdown mo-mb-2"">
                                <button class=""btn btn-secondary dropdown-toggle"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                    Dropdown button
     ");
            WriteLiteral(@"                           </button>
                                <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton"">
                                    <a class=""dropdown-item"" href=""#"">Action</a>
                                    <a class=""dropdown-item"" href=""#"">Another action</a>
                                    <a class=""dropdown-item"" href=""#"">Something else here</a>
                                </div>
                            </div>
                        </div>

                        <div class=""col-sm-6"">
                            <div class=""dropdown mo-mb-2"">
                                <a class=""btn btn-secondary dropdown-toggle"" href=""https://example.com"" id=""dropdownMenuLink"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                    Dropdown link
                                </a>

                                <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuLink"">
                      ");
            WriteLiteral(@"              <a class=""dropdown-item"" href=""#"">Action</a>
                                    <a class=""dropdown-item"" href=""#"">Another action</a>
                                    <a class=""dropdown-item"" href=""#"">Something else here</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class=""col-lg-6"">
            <div class=""card m-b-30"">
                <div class=""card-body"">

                    <h4 class=""mt-0 header-title"">Variant</h4>
                    <p class=""text-muted m-b-30 "">The best part is you can do this with any button variant, too:</p>

                    <div");
            BeginWriteAttribute("class", " class=\"", 2813, "\"", 2821, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""btn-group m-b-10"">
                            <button type=""button"" class=""btn btn-primary dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">Primary</button>
                            <div class=""dropdown-menu"">
                                <a class=""dropdown-item"" href=""#"">Action</a>
                                <a class=""dropdown-item"" href=""#"">Another action</a>
                                <a class=""dropdown-item"" href=""#"">Something else here</a>
                                <div class=""dropdown-divider""></div>
                                <a class=""dropdown-item"" href=""#"">Separated link</a>
                            </div>
                        </div><!-- /btn-group -->
                        <div class=""btn-group m-b-10"">
                            <button type=""button"" class=""btn btn-secondary dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">Secondary</button>
  ");
            WriteLiteral(@"                          <div class=""dropdown-menu"">
                                <a class=""dropdown-item"" href=""#"">Action</a>
                                <a class=""dropdown-item"" href=""#"">Another action</a>
                                <a class=""dropdown-item"" href=""#"">Something else here</a>
                                <div class=""dropdown-divider""></div>
                                <a class=""dropdown-item"" href=""#"">Separated link</a>
                            </div>
                        </div><!-- /btn-group -->
                        <div class=""btn-group m-b-10"">
                            <button type=""button"" class=""btn btn-success dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">Success</button>
                            <div class=""dropdown-menu"">
                                <a class=""dropdown-item"" href=""#"">Action</a>
                                <a class=""dropdown-item"" href=""#"">Another action</a>
                    ");
            WriteLiteral(@"            <a class=""dropdown-item"" href=""#"">Something else here</a>
                                <div class=""dropdown-divider""></div>
                                <a class=""dropdown-item"" href=""#"">Separated link</a>
                            </div>
                        </div><!-- /btn-group -->
                        <div class=""btn-group m-b-10"">
                            <button type=""button"" class=""btn btn-info dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">Info</button>
                            <div class=""dropdown-menu"">
                                <a class=""dropdown-item"" href=""#"">Action</a>
                                <a class=""dropdown-item"" href=""#"">Another action</a>
                                <a class=""dropdown-item"" href=""#"">Something else here</a>
                                <div class=""dropdown-divider""></div>
                                <a class=""dropdown-item"" href=""#"">Separated link</a>
                  ");
            WriteLiteral(@"          </div>
                        </div><!-- /btn-group -->
                        <div class=""btn-group m-b-10"">
                            <button type=""button"" class=""btn btn-warning dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">Warning</button>
                            <div class=""dropdown-menu"">
                                <a class=""dropdown-item"" href=""#"">Action</a>
                                <a class=""dropdown-item"" href=""#"">Another action</a>
                                <a class=""dropdown-item"" href=""#"">Something else here</a>
                                <div class=""dropdown-divider""></div>
                                <a class=""dropdown-item"" href=""#"">Separated link</a>
                            </div>
                        </div><!-- /btn-group -->
                        <div class=""btn-group m-b-10"">
                            <button type=""button"" class=""btn btn-danger dropdown-toggle"" data-toggle=""dropdown"" ar");
            WriteLiteral(@"ia-haspopup=""true"" aria-expanded=""false"">Danger</button>
                            <div class=""dropdown-menu"">
                                <a class=""dropdown-item"" href=""#"">Action</a>
                                <a class=""dropdown-item"" href=""#"">Another action</a>
                                <a class=""dropdown-item"" href=""#"">Something else here</a>
                                <div class=""dropdown-divider""></div>
                                <a class=""dropdown-item"" href=""#"">Separated link</a>
                            </div>
                        </div><!-- /btn-group -->
                    </div>

                </div>
            </div>

        </div> <!-- end col -->
    </div> <!-- end row -->


    <div class=""row"">
        <div class=""col-lg-6"">
            <div class=""card m-b-30"">
                <div class=""card-body"">

                    <h4 class=""mt-0 header-title"">Split button dropdowns</h4>
                    <p class=""text-muted m-b-30 "">The");
            WriteLiteral(" best part is you can do this with any button variant, too:</p>\r\n\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 8033, "\"", 8041, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""btn-group m-b-10"">
                            <button type=""button"" class=""btn btn-primary"">Primary</button>
                            <button type=""button"" class=""btn btn-primary dropdown-toggle dropdown-toggle-split"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                <span class=""sr-only"">Toggle Dropdown</span>
                            </button>
                            <div class=""dropdown-menu"">
                                <a class=""dropdown-item"" href=""#"">Action</a>
                                <a class=""dropdown-item"" href=""#"">Another action</a>
                                <a class=""dropdown-item"" href=""#"">Something else here</a>
                                <div class=""dropdown-divider""></div>
                                <a class=""dropdown-item"" href=""#"">Separated link</a>
                            </div>
                        </div><!-- /btn-group -->
                     ");
            WriteLiteral(@"   <div class=""btn-group m-b-10"">
                            <button type=""button"" class=""btn btn-secondary"">Secondary</button>
                            <button type=""button"" class=""btn btn-secondary dropdown-toggle dropdown-toggle-split"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                <span class=""sr-only"">Toggle Dropdown</span>
                            </button>
                            <div class=""dropdown-menu"">
                                <a class=""dropdown-item"" href=""#"">Action</a>
                                <a class=""dropdown-item"" href=""#"">Another action</a>
                                <a class=""dropdown-item"" href=""#"">Something else here</a>
                                <div class=""dropdown-divider""></div>
                                <a class=""dropdown-item"" href=""#"">Separated link</a>
                            </div>
                        </div><!-- /btn-group -->
                        <div class=""btn");
            WriteLiteral(@"-group m-b-10"">
                            <button type=""button"" class=""btn btn-success"">Success</button>
                            <button type=""button"" class=""btn btn-success dropdown-toggle dropdown-toggle-split"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                <span class=""sr-only"">Toggle Dropdown</span>
                            </button>
                            <div class=""dropdown-menu"">
                                <a class=""dropdown-item"" href=""#"">Action</a>
                                <a class=""dropdown-item"" href=""#"">Another action</a>
                                <a class=""dropdown-item"" href=""#"">Something else here</a>
                                <div class=""dropdown-divider""></div>
                                <a class=""dropdown-item"" href=""#"">Separated link</a>
                            </div>
                        </div><!-- /btn-group -->
                        <div class=""btn-group m-b-10"">
       ");
            WriteLiteral(@"                     <button type=""button"" class=""btn btn-info"">Info</button>
                            <button type=""button"" class=""btn btn-info dropdown-toggle dropdown-toggle-split"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                <span class=""sr-only"">Toggle Dropdown</span>
                            </button>
                            <div class=""dropdown-menu"">
                                <a class=""dropdown-item"" href=""#"">Action</a>
                                <a class=""dropdown-item"" href=""#"">Another action</a>
                                <a class=""dropdown-item"" href=""#"">Something else here</a>
                                <div class=""dropdown-divider""></div>
                                <a class=""dropdown-item"" href=""#"">Separated link</a>
                            </div>
                        </div><!-- /btn-group -->
                        <div class=""btn-group m-b-10"">
                            <button type");
            WriteLiteral(@"=""button"" class=""btn btn-warning"">Warning</button>
                            <button type=""button"" class=""btn btn-warning dropdown-toggle dropdown-toggle-split"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                <span class=""sr-only"">Toggle Dropdown</span>
                            </button>
                            <div class=""dropdown-menu"">
                                <a class=""dropdown-item"" href=""#"">Action</a>
                                <a class=""dropdown-item"" href=""#"">Another action</a>
                                <a class=""dropdown-item"" href=""#"">Something else here</a>
                                <div class=""dropdown-divider""></div>
                                <a class=""dropdown-item"" href=""#"">Separated link</a>
                            </div>
                        </div><!-- /btn-group -->
                        <div class=""btn-group m-b-10"">
                            <button type=""button"" class=""btn btn");
            WriteLiteral(@"-danger"">Danger</button>
                            <button type=""button"" class=""btn btn-danger dropdown-toggle dropdown-toggle-split"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                <span class=""sr-only"">Toggle Dropdown</span>
                            </button>
                            <div class=""dropdown-menu"">
                                <a class=""dropdown-item"" href=""#"">Action</a>
                                <a class=""dropdown-item"" href=""#"">Another action</a>
                                <a class=""dropdown-item"" href=""#"">Something else here</a>
                                <div class=""dropdown-divider""></div>
                                <a class=""dropdown-item"" href=""#"">Separated link</a>
                            </div>
                        </div><!-- /btn-group -->
                    </div>

                </div>
            </div>
        </div>

        <div class=""col-lg-6"">
            <div class=");
            WriteLiteral(@"""card m-b-30"">
                <div class=""card-body"">

                    <h4 class=""mt-0 header-title"">Sizing</h4>
                    <p class=""text-muted m-b-30 "">
                        Button dropdowns work with buttons of
                        all sizes, including default and split dropdown buttons.
                    </p>

                    <div");
            BeginWriteAttribute("class", " class=\"", 14557, "\"", 14565, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <!-- Large button groups (default and split) -->
                        <div class=""btn-group mo-mb-2"">
                            <button class=""btn btn-secondary btn-lg dropdown-toggle"" type=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                Large button
                            </button>
                            <div class=""dropdown-menu"">
                                <a class=""dropdown-item"" href=""#"">Action</a>
                                <a class=""dropdown-item"" href=""#"">Another action</a>
                                <a class=""dropdown-item"" href=""#"">Something else here</a>
                                <div class=""dropdown-divider""></div>
                                <a class=""dropdown-item"" href=""#"">Separated link</a>
                            </div>
                        </div>
                        <div class=""btn-group mo-mb-2"">
                            <button class=""bt");
            WriteLiteral(@"n btn-secondary btn-lg"" type=""button"">
                                Large button
                            </button>
                            <button type=""button"" class=""btn btn-lg btn-secondary dropdown-toggle dropdown-toggle-split"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                <span class=""sr-only"">Toggle Dropdown</span>
                            </button>
                            <div class=""dropdown-menu"">
                                <a class=""dropdown-item"" href=""#"">Action</a>
                                <a class=""dropdown-item"" href=""#"">Another action</a>
                                <a class=""dropdown-item"" href=""#"">Something else here</a>
                                <div class=""dropdown-divider""></div>
                                <a class=""dropdown-item"" href=""#"">Separated link</a>
                            </div>
                        </div>

                        <!-- Small button groups (defau");
            WriteLiteral(@"lt and split) -->
                        <div class=""btn-group mo-mb-2"">
                            <button class=""btn btn-secondary btn-sm dropdown-toggle"" type=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                Small button
                            </button>
                            <div class=""dropdown-menu"">
                                <a class=""dropdown-item"" href=""#"">Action</a>
                                <a class=""dropdown-item"" href=""#"">Another action</a>
                                <a class=""dropdown-item"" href=""#"">Something else here</a>
                                <div class=""dropdown-divider""></div>
                                <a class=""dropdown-item"" href=""#"">Separated link</a>
                            </div>
                        </div>
                        <div class=""btn-group mo-mb-2"">
                            <button class=""btn btn-secondary btn-sm"" type=""button"">
                  ");
            WriteLiteral(@"              Small button
                            </button>
                            <button type=""button"" class=""btn btn-sm btn-secondary dropdown-toggle dropdown-toggle-split"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                <span class=""sr-only"">Toggle Dropdown</span>
                            </button>
                            <div class=""dropdown-menu"">
                                <a class=""dropdown-item"" href=""#"">Action</a>
                                <a class=""dropdown-item"" href=""#"">Another action</a>
                                <a class=""dropdown-item"" href=""#"">Something else here</a>
                                <div class=""dropdown-divider""></div>
                                <a class=""dropdown-item"" href=""#"">Separated link</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div> <!-- end col -->
    </div>");
            WriteLiteral(@" <!-- end row -->


    <div class=""row"">
        <div class=""col-lg-6"">
            <div class=""card m-b-30"">
                <div class=""card-body"">

                    <h4 class=""mt-0 header-title"">Dropup variation</h4>
                    <p class=""text-muted m-b-30 "">
                        Trigger dropdown menus above elements
                        by adding <code class=""highlighter-rouge"">.dropup</code> to the parent
                        element.
                    </p>

                    <div");
            BeginWriteAttribute("class", " class=\"", 19192, "\"", 19200, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <!-- Default dropup button -->
                        <div class=""btn-group dropup mo-mb-2"">
                            <button type=""button"" class=""btn btn-secondary dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">Dropup</button>
                            <div class=""dropdown-menu"">
                                <a class=""dropdown-item"" href=""#"">Action</a>
                                <a class=""dropdown-item"" href=""#"">Another action</a>
                                <a class=""dropdown-item"" href=""#"">Something else here</a>
                                <div class=""dropdown-divider""></div>
                                <a class=""dropdown-item"" href=""#"">Separated link</a>
                            </div>
                        </div>

                        <!-- Split dropup button -->
                        <div class=""btn-group dropup mo-mb-2"">
                            <button type=""button"" class=""btn btn-secon");
            WriteLiteral(@"dary"">
                                Split dropup
                            </button>
                            <button type=""button"" class=""btn btn-secondary dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                <span class=""sr-only"">Toggle Dropdown</span>
                            </button>
                            <div class=""dropdown-menu"">
                                <a class=""dropdown-item"" href=""#"">Action</a>
                                <a class=""dropdown-item"" href=""#"">Another action</a>
                                <a class=""dropdown-item"" href=""#"">Something else here</a>
                                <div class=""dropdown-divider""></div>
                                <a class=""dropdown-item"" href=""#"">Separated link</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class=""col-lg-6");
            WriteLiteral(@""">
            <div class=""card m-b-30"">
                <div class=""card-body"">

                    <h4 class=""mt-0 header-title"">Menu alignment</h4>
                    <p class=""text-muted m-b-30 "">
                        Add <code class=""highlighter-rouge"">.dropdown-menu-right</code>
                        to a <code class=""highlighter-rouge"">.dropdown-menu</code> to right
                        align the dropdown menu.
                    </p>

                    <div class=""btn-group"">
                        <button type=""button"" class=""btn btn-secondary dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            Menu is right-aligned
                        </button>
                        <div class=""dropdown-menu dropdown-menu-right"">
                            <a class=""dropdown-item"" href=""#"">Action</a>
                            <a class=""dropdown-item"" href=""#"">Another action</a>
                            <a class=""d");
            WriteLiteral(@"ropdown-item"" href=""#"">Something else here</a>
                        </div>
                    </div>

                </div>
            </div>
        </div> <!-- end col -->
    </div> <!-- end row -->


    <div class=""row"">
        <div class=""col-lg-6"">
            <div class=""card m-b-30"">
                <div class=""card-body"">

                    <h4 class=""mt-0 header-title"">Dropright variation</h4>
                    <p class=""text-muted m-b-30 "">
                        Trigger dropdown menus at the right of the elements by adding <code>.dropright</code> to the parent element.
                    </p>

                    <div");
            BeginWriteAttribute("class", " class=\"", 22944, "\"", 22952, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <!-- Default dropright button -->
                        <div class=""btn-group mb-2 dropright"">
                            <button type=""button"" class=""btn btn-info waves-effect waves-light dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                Dropright
                            </button>
                            <div class=""dropdown-menu"">
                                <a class=""dropdown-item"" href=""#"">Action</a>
                                <a class=""dropdown-item"" href=""#"">Another action</a>
                                <a class=""dropdown-item"" href=""#"">Something else here</a>
                            </div>
                        </div>

                        <!-- Split dropright button -->
                        <div class=""btn-group mb-2 dropright"">
                            <button type=""button"" class=""btn btn-info waves-effect waves-light"">
                                Spl");
            WriteLiteral(@"it dropright
                            </button>
                            <button type=""button"" class=""btn btn-info waves-effect waves-light dropdown-toggle-split dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                <span class=""sr-only"">Toggle Dropright</span>
                            </button>
                            <div class=""dropdown-menu"">
                                <a class=""dropdown-item"" href=""#"">Action</a>
                                <a class=""dropdown-item"" href=""#"">Another action</a>
                                <a class=""dropdown-item"" href=""#"">Something else here</a>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </div>

        <div class=""col-lg-6"">
            <div class=""card m-b-30"">
                <div class=""card-body"">

                    <h4 class=""mt-0 header-title"">Dropleft variat");
            WriteLiteral(@"ion</h4>
                    <p class=""text-muted m-b-30 "">
                        Trigger dropdown menus at the right of the elements by adding <code>.dropleft</code> to the parent element.
                    </p>

                    <!-- Default dropright button -->
                    <div class=""btn-group mb-2 dropleft"">
                        <button type=""button"" class=""btn btn-info waves-effect waves-light dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            Dropleft
                        </button>
                        <div class=""dropdown-menu"">
                            <a class=""dropdown-item"" href=""#"">Action</a>
                            <a class=""dropdown-item"" href=""#"">Another action</a>
                            <a class=""dropdown-item"" href=""#"">Something else here</a>
                        </div>
                    </div>

                    <!-- Split dropright button -->
                    <div cl");
            WriteLiteral(@"ass=""btn-group mb-2"">
                        <div class=""btn-group dropleft"">
                            <button type=""button"" class=""btn btn-info waves-effect waves-light dropdown-toggle-split dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                <span class=""sr-only"">Toggle Dropleft</span>
                            </button>
                            <div class=""dropdown-menu"">
                                <a class=""dropdown-item"" href=""#"">Action</a>
                                <a class=""dropdown-item"" href=""#"">Another action</a>
                                <a class=""dropdown-item"" href=""#"">Something else here</a>
                            </div>
                        </div>

                        <button type=""button"" class=""btn btn-info waves-effect waves-light"">
                            Split Dropleft
                        </button>
                    </div>
                </div>
            </div");
            WriteLiteral(">\r\n        </div> <!-- end col -->\r\n    </div> <!-- end row -->\r\n");
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
