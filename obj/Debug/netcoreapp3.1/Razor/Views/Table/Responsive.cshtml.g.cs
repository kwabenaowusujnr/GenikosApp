#pragma checksum "E:\PROJECTS\GENIKOS\GenikosApp\Views\Table\Responsive.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ffa411a48b70564ba3d502aaf822ccc88684bc8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Table_Responsive), @"mvc.1.0.view", @"/Views/Table/Responsive.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ffa411a48b70564ba3d502aaf822ccc88684bc8", @"/Views/Table/Responsive.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9280cd403e9114f41b42698cec59645e918c4a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Table_Responsive : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/plugins/RWD-Table-Patterns/dist/css/rwd-table.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("media", new global::Microsoft.AspNetCore.Html.HtmlString("screen"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/plugins/RWD-Table-Patterns/dist/js/rwd-table.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3ffa411a48b70564ba3d502aaf822ccc88684bc84936", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"
    <div class=""row"">
        <div class=""col-12"">
            <div class=""card m-b-20"">
                <div class=""card-body"">

                    <h4 class=""mt-0 header-title"">Example</h4>
                    <p class=""text-muted m-b-30 "">This is an experimental awesome solution for responsive tables with complex data.</p>

                    <div class=""table-rep-plugin"">
                        <div class=""table-responsive b-0"" data-pattern=""priority-columns"">
                            <table id=""tech-companies-1"" class=""table  table-striped"">
                                <thead>
                                    <tr>
                                        <th>Company</th>
                                        <th data-priority=""1"">Last Trade</th>
                                        <th data-priority=""3"">Trade Time</th>
                                        <th data-priority=""1"">Change</th>
                                        <th data-priority=""3"">Prev Close</th>");
            WriteLiteral(@"
                                        <th data-priority=""3"">Open</th>
                                        <th data-priority=""6"">Bid</th>
                                        <th data-priority=""6"">Ask</th>
                                        <th data-priority=""6"">1y Target Est</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <th>GOOG <span class=""co-name"">Google Inc.</span></th>
                                        <td>597.74</td>
                                        <td>12:12PM</td>
                                        <td>14.81 (2.54%)</td>
                                        <td>582.93</td>
                                        <td>597.95</td>
                                        <td>597.73 x 100</td>
                                        <td>597.91 x 300</td>
                                        <");
            WriteLiteral(@"td>731.10</td>
                                    </tr>
                                    <tr>
                                        <th>AAPL <span class=""co-name"">Apple Inc.</span></th>
                                        <td>378.94</td>
                                        <td>12:22PM</td>
                                        <td>5.74 (1.54%)</td>
                                        <td>373.20</td>
                                        <td>381.02</td>
                                        <td>378.92 x 300</td>
                                        <td>378.99 x 100</td>
                                        <td>505.94</td>
                                    </tr>
                                    <tr>
                                        <th>AMZN <span class=""co-name"">Amazon.com Inc.</span></th>
                                        <td>191.55</td>
                                        <td>12:23PM</td>
                                        <td>3.16 (1.6");
            WriteLiteral(@"8%)</td>
                                        <td>188.39</td>
                                        <td>194.99</td>
                                        <td>191.52 x 300</td>
                                        <td>191.58 x 100</td>
                                        <td>240.32</td>
                                    </tr>
                                    <tr>
                                        <th>ORCL <span class=""co-name"">Oracle Corporation</span></th>
                                        <td>31.15</td>
                                        <td>12:44PM</td>
                                        <td>1.41 (4.72%)</td>
                                        <td>29.74</td>
                                        <td>30.67</td>
                                        <td>31.14 x 6500</td>
                                        <td>31.15 x 3200</td>
                                        <td>36.11</td>
                                    </tr>
               ");
            WriteLiteral(@"                     <tr>
                                        <th>MSFT <span class=""co-name"">Microsoft Corporation</span></th>
                                        <td>25.50</td>
                                        <td>12:27PM</td>
                                        <td>0.66 (2.67%)</td>
                                        <td>24.84</td>
                                        <td>25.37</td>
                                        <td>25.50 x 71100</td>
                                        <td>25.51 x 17800</td>
                                        <td>31.50</td>
                                    </tr>
                                    <tr>
                                        <th>CSCO <span class=""co-name"">Cisco Systems, Inc.</span></th>
                                        <td>18.65</td>
                                        <td>12:45PM</td>
                                        <td>0.97 (5.49%)</td>
                                        <td>17.68</t");
            WriteLiteral(@"d>
                                        <td>18.23</td>
                                        <td>18.65 x 10300</td>
                                        <td>18.66 x 24000</td>
                                        <td>21.12</td>
                                    </tr>
                                    <tr>
                                        <th>YHOO <span class=""co-name"">Yahoo! Inc.</span></th>
                                        <td>15.81</td>
                                        <td>12:25PM</td>
                                        <td>0.11 (0.67%)</td>
                                        <td>15.70</td>
                                        <td>15.94</td>
                                        <td>15.79 x 6100</td>
                                        <td>15.80 x 17000</td>
                                        <td>18.16</td>
                                    </tr>
                                    <!-- Repeat -->
                               ");
            WriteLiteral(@"     <tr>
                                        <th>GOOG <span class=""co-name"">Google Inc.</span></th>
                                        <td>597.74</td>
                                        <td>12:12PM</td>
                                        <td>14.81 (2.54%)</td>
                                        <td>582.93</td>
                                        <td>597.95</td>
                                        <td>597.73 x 100</td>
                                        <td>597.91 x 300</td>
                                        <td>731.10</td>
                                    </tr>
                                    <tr>
                                        <th>AAPL <span class=""co-name"">Apple Inc.</span></th>
                                        <td>378.94</td>
                                        <td>12:22PM</td>
                                        <td>5.74 (1.54%)</td>
                                        <td>373.20</td>
                          ");
            WriteLiteral(@"              <td>381.02</td>
                                        <td>378.92 x 300</td>
                                        <td>378.99 x 100</td>
                                        <td>505.94</td>
                                    </tr>
                                    <tr>
                                        <th>AMZN <span class=""co-name"">Amazon.com Inc.</span></th>
                                        <td>191.55</td>
                                        <td>12:23PM</td>
                                        <td>3.16 (1.68%)</td>
                                        <td>188.39</td>
                                        <td>194.99</td>
                                        <td>191.52 x 300</td>
                                        <td>191.58 x 100</td>
                                        <td>240.32</td>
                                    </tr>
                                    <tr>
                                        <th>ORCL <span class=""co-");
            WriteLiteral(@"name"">Oracle Corporation</span></th>
                                        <td>31.15</td>
                                        <td>12:44PM</td>
                                        <td>1.41 (4.72%)</td>
                                        <td>29.74</td>
                                        <td>30.67</td>
                                        <td>31.14 x 6500</td>
                                        <td>31.15 x 3200</td>
                                        <td>36.11</td>
                                    </tr>
                                    <tr>
                                        <th>MSFT <span class=""co-name"">Microsoft Corporation</span></th>
                                        <td>25.50</td>
                                        <td>12:27PM</td>
                                        <td>0.66 (2.67%)</td>
                                        <td>24.84</td>
                                        <td>25.37</td>
                                   ");
            WriteLiteral(@"     <td>25.50 x 71100</td>
                                        <td>25.51 x 17800</td>
                                        <td>31.50</td>
                                    </tr>
                                    <tr>
                                        <th>CSCO <span class=""co-name"">Cisco Systems, Inc.</span></th>
                                        <td>18.65</td>
                                        <td>12:45PM</td>
                                        <td>0.97 (5.49%)</td>
                                        <td>17.68</td>
                                        <td>18.23</td>
                                        <td>18.65 x 10300</td>
                                        <td>18.66 x 24000</td>
                                        <td>21.12</td>
                                    </tr>
                                    <tr>
                                        <th>YHOO <span class=""co-name"">Yahoo! Inc.</span></th>
                                ");
            WriteLiteral(@"        <td>15.81</td>
                                        <td>12:25PM</td>
                                        <td>0.11 (0.67%)</td>
                                        <td>15.70</td>
                                        <td>15.94</td>
                                        <td>15.79 x 6100</td>
                                        <td>15.80 x 17000</td>
                                        <td>18.16</td>
                                    </tr>
                                    <!-- Repeat -->
                                    <tr>
                                        <th>GOOG <span class=""co-name"">Google Inc.</span></th>
                                        <td>597.74</td>
                                        <td>12:12PM</td>
                                        <td>14.81 (2.54%)</td>
                                        <td>582.93</td>
                                        <td>597.95</td>
                                        <td>597.73 x 100<");
            WriteLiteral(@"/td>
                                        <td>597.91 x 300</td>
                                        <td>731.10</td>
                                    </tr>
                                    <tr>
                                        <th>AAPL <span class=""co-name"">Apple Inc.</span></th>
                                        <td>378.94</td>
                                        <td>12:22PM</td>
                                        <td>5.74 (1.54%)</td>
                                        <td>373.20</td>
                                        <td>381.02</td>
                                        <td>378.92 x 300</td>
                                        <td>378.99 x 100</td>
                                        <td>505.94</td>
                                    </tr>
                                    <tr>
                                        <th>AMZN <span class=""co-name"">Amazon.com Inc.</span></th>
                                        <td>191.55</td>
 ");
            WriteLiteral(@"                                       <td>12:23PM</td>
                                        <td>3.16 (1.68%)</td>
                                        <td>188.39</td>
                                        <td>194.99</td>
                                        <td>191.52 x 300</td>
                                        <td>191.58 x 100</td>
                                        <td>240.32</td>
                                    </tr>
                                    <tr>
                                        <th>ORCL <span class=""co-name"">Oracle Corporation</span></th>
                                        <td>31.15</td>
                                        <td>12:44PM</td>
                                        <td>1.41 (4.72%)</td>
                                        <td>29.74</td>
                                        <td>30.67</td>
                                        <td>31.14 x 6500</td>
                                        <td>31.15 x 3200</td>
    ");
            WriteLiteral(@"                                    <td>36.11</td>
                                    </tr>
                                    <tr>
                                        <th>MSFT <span class=""co-name"">Microsoft Corporation</span></th>
                                        <td>25.50</td>
                                        <td>12:27PM</td>
                                        <td>0.66 (2.67%)</td>
                                        <td>24.84</td>
                                        <td>25.37</td>
                                        <td>25.50 x 71100</td>
                                        <td>25.51 x 17800</td>
                                        <td>31.50</td>
                                    </tr>
                                    <tr>
                                        <th>CSCO <span class=""co-name"">Cisco Systems, Inc.</span></th>
                                        <td>18.65</td>
                                        <td>12:45PM</td>
     ");
            WriteLiteral(@"                                   <td>0.97 (5.49%)</td>
                                        <td>17.68</td>
                                        <td>18.23</td>
                                        <td>18.65 x 10300</td>
                                        <td>18.66 x 24000</td>
                                        <td>21.12</td>
                                    </tr>
                                    <tr>
                                        <th>YHOO <span class=""co-name"">Yahoo! Inc.</span></th>
                                        <td>15.81</td>
                                        <td>12:25PM</td>
                                        <td>0.11 (0.67%)</td>
                                        <td>15.70</td>
                                        <td>15.94</td>
                                        <td>15.79 x 6100</td>
                                        <td>15.80 x 17000</td>
                                        <td>18.16</td>
                 ");
            WriteLiteral(@"                   </tr>
                                    <!-- Repeat -->
                                    <tr>
                                        <th>GOOG <span class=""co-name"">Google Inc.</span></th>
                                        <td>597.74</td>
                                        <td>12:12PM</td>
                                        <td>14.81 (2.54%)</td>
                                        <td>582.93</td>
                                        <td>597.95</td>
                                        <td>597.73 x 100</td>
                                        <td>597.91 x 300</td>
                                        <td>731.10</td>
                                    </tr>
                                    <tr>
                                        <th>AAPL <span class=""co-name"">Apple Inc.</span></th>
                                        <td>378.94</td>
                                        <td>12:22PM</td>
                                    ");
            WriteLiteral(@"    <td>5.74 (1.54%)</td>
                                        <td>373.20</td>
                                        <td>381.02</td>
                                        <td>378.92 x 300</td>
                                        <td>378.99 x 100</td>
                                        <td>505.94</td>
                                    </tr>
                                    <tr>
                                        <th>AMZN <span class=""co-name"">Amazon.com Inc.</span></th>
                                        <td>191.55</td>
                                        <td>12:23PM</td>
                                        <td>3.16 (1.68%)</td>
                                        <td>188.39</td>
                                        <td>194.99</td>
                                        <td>191.52 x 300</td>
                                        <td>191.58 x 100</td>
                                        <td>240.32</td>
                                    </tr");
            WriteLiteral(@">
                                    <tr>
                                        <th>ORCL <span class=""co-name"">Oracle Corporation</span></th>
                                        <td>31.15</td>
                                        <td>12:44PM</td>
                                        <td>1.41 (4.72%)</td>
                                        <td>29.74</td>
                                        <td>30.67</td>
                                        <td>31.14 x 6500</td>
                                        <td>31.15 x 3200</td>
                                        <td>36.11</td>
                                    </tr>
                                    <tr>
                                        <th>MSFT <span class=""co-name"">Microsoft Corporation</span></th>
                                        <td>25.50</td>
                                        <td>12:27PM</td>
                                        <td>0.66 (2.67%)</td>
                                     ");
            WriteLiteral(@"   <td>24.84</td>
                                        <td>25.37</td>
                                        <td>25.50 x 71100</td>
                                        <td>25.51 x 17800</td>
                                        <td>31.50</td>
                                    </tr>
                                    <tr>
                                        <th>CSCO <span class=""co-name"">Cisco Systems, Inc.</span></th>
                                        <td>18.65</td>
                                        <td>12:45PM</td>
                                        <td>0.97 (5.49%)</td>
                                        <td>17.68</td>
                                        <td>18.23</td>
                                        <td>18.65 x 10300</td>
                                        <td>18.66 x 24000</td>
                                        <td>21.12</td>
                                    </tr>
                                    <tr>
                  ");
            WriteLiteral(@"                      <th>YHOO <span class=""co-name"">Yahoo! Inc.</span></th>
                                        <td>15.81</td>
                                        <td>12:25PM</td>
                                        <td>0.11 (0.67%)</td>
                                        <td>15.70</td>
                                        <td>15.94</td>
                                        <td>15.79 x 6100</td>
                                        <td>15.80 x 17000</td>
                                        <td>18.16</td>
                                    </tr>
                                    <!-- Repeat -->
                                    <tr>
                                        <th>GOOG <span class=""co-name"">Google Inc.</span></th>
                                        <td>597.74</td>
                                        <td>12:12PM</td>
                                        <td>14.81 (2.54%)</td>
                                        <td>582.93</td>
    ");
            WriteLiteral(@"                                    <td>597.95</td>
                                        <td>597.73 x 100</td>
                                        <td>597.91 x 300</td>
                                        <td>731.10</td>
                                    </tr>
                                    <tr>
                                        <th>AAPL <span class=""co-name"">Apple Inc.</span></th>
                                        <td>378.94</td>
                                        <td>12:22PM</td>
                                        <td>5.74 (1.54%)</td>
                                        <td>373.20</td>
                                        <td>381.02</td>
                                        <td>378.92 x 300</td>
                                        <td>378.99 x 100</td>
                                        <td>505.94</td>
                                    </tr>
                                    <tr>
                                        <th>AMZN");
            WriteLiteral(@" <span class=""co-name"">Amazon.com Inc.</span></th>
                                        <td>191.55</td>
                                        <td>12:23PM</td>
                                        <td>3.16 (1.68%)</td>
                                        <td>188.39</td>
                                        <td>194.99</td>
                                        <td>191.52 x 300</td>
                                        <td>191.58 x 100</td>
                                        <td>240.32</td>
                                    </tr>
                                    <tr>
                                        <th>ORCL <span class=""co-name"">Oracle Corporation</span></th>
                                        <td>31.15</td>
                                        <td>12:44PM</td>
                                        <td>1.41 (4.72%)</td>
                                        <td>29.74</td>
                                        <td>30.67</td>
                    ");
            WriteLiteral(@"                    <td>31.14 x 6500</td>
                                        <td>31.15 x 3200</td>
                                        <td>36.11</td>
                                    </tr>
                                    <tr>
                                        <th>MSFT <span class=""co-name"">Microsoft Corporation</span></th>
                                        <td>25.50</td>
                                        <td>12:27PM</td>
                                        <td>0.66 (2.67%)</td>
                                        <td>24.84</td>
                                        <td>25.37</td>
                                        <td>25.50 x 71100</td>
                                        <td>25.51 x 17800</td>
                                        <td>31.50</td>
                                    </tr>
                                    <tr>
                                        <th>CSCO <span class=""co-name"">Cisco Systems, Inc.</span></th>
         ");
            WriteLiteral(@"                               <td>18.65</td>
                                        <td>12:45PM</td>
                                        <td>0.97 (5.49%)</td>
                                        <td>17.68</td>
                                        <td>18.23</td>
                                        <td>18.65 x 10300</td>
                                        <td>18.66 x 24000</td>
                                        <td>21.12</td>
                                    </tr>
                                    <tr>
                                        <th>YHOO <span class=""co-name"">Yahoo! Inc.</span></th>
                                        <td>15.81</td>
                                        <td>12:25PM</td>
                                        <td>0.11 (0.67%)</td>
                                        <td>15.70</td>
                                        <td>15.94</td>
                                        <td>15.79 x 6100</td>
                           ");
            WriteLiteral(@"             <td>15.80 x 17000</td>
                                        <td>18.16</td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>

                    </div>

                </div>
            </div>
        </div> <!-- end col -->
    </div> <!-- end row -->


");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ffa411a48b70564ba3d502aaf822ccc88684bc832284", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        $(function () {\r\n            $(\'.table-responsive\').responsiveTable({\r\n                addDisplayAllBtn: \'btn btn-secondary\'\r\n            });\r\n        });\r\n    </script>\r\n\r\n");
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
