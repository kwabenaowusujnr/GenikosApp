#pragma checksum "E:\PROJECTS\GENIKOS\GenikosApp\Views\Dashboard\Reports.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a882e77dd0a8b0ac1aa72c2148b3ecd35981fc71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Reports), @"mvc.1.0.view", @"/Views/Dashboard/Reports.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a882e77dd0a8b0ac1aa72c2148b3ecd35981fc71", @"/Views/Dashboard/Reports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9280cd403e9114f41b42698cec59645e918c4a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Reports : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-xl-12"">
        <div class=""card m-b-20"">
            <div class=""card-body"">
                <h4 class=""mt-0 m-b-30 header-title"">Latest Transactions</h4>
                <div id=""grid_MostRecentSales""></div>

            </div>
        </div>
    </div>
</div>


<script>

    $(function () {
        $(""#grid_MostRecentSales"").dxDataGrid({
            dataSource: [],
            paging: {
                pageSize: 10
            },
            editing: {
                mode: ""popup"",
                allowUpdating: false,
                allowDeleting: false,
                allowAdding: true,
                popup: {
                    title: ""Transaction Info."",
                    showTitle: true,
                    width: 700,
                    height: 400,
                    position: {
                        my: ""center"",
                        at: ""center"",
                        of: window
                    }
      ");
            WriteLiteral(@"          },
            },
            pager: {
                showPageSizeSelector: true,
                allowedPageSizes: [10, 25, 50, 100]
            },
            remoteOperations: false,
            searchPanel: {
                visible: true,
                highlightCaseSensitive: true
            },
            groupPanel: { visible: false },
            grouping: {
                autoExpandAll: true
            },
            allowColumnReordering: true,
            rowAlternationEnabled: true,
            showBorders: true,
            filterRow: {
                visible: true,
                applyFilter: ""auto""
            },
            columns: [
                {
                    dataField: ""Id"",
                    formItem: { visible: false }
                },
                {
                    dataField: ""Date"",
                    dataType: ""date""
                },
                {
                    dataField: ""Name"",
                    d");
            WriteLiteral(@"ataType: ""string""
                },
                {
                    dataField: ""Telephone"",
                    dataType: ""string"",
                    validationRules: [{ type: ""required"" }]
                },
                {
                    dataField: ""VehicleNo"",
                    dataType: ""string""
                },
                {
                    dataField: ""Amount"",
                    caption: ""Amount"",
                    dataType: ""number"",
                    format: ""currency"",
                    alignment: ""right"",
                    validationRules: [{ type: ""required"" }]
                },
                {
                    dataField: ""TransactionType"",
                    dataType: ""string"",
                    lookup: {
                        dataSource: [{
                            ""ID"": '1',
                            ""Name"": 'Debit'
                        },
                        {
                            ""ID"": '2',
        ");
            WriteLiteral(@"                    ""Name"": 'Credit'
                        }],
                        valueExpr: ""ID"",
                        displayExpr: ""Name""
                    }, validationRules: [{ type: ""required"" }]
                },
                {
                    dataField: ""Remarks"",
                    dataType: ""string"",
                    formItem: {
                        colSpan: 2,
                        editorType: ""dxTextArea"",
                        editorOptions: {
                            height: 90
                        }
                    }
                }
            ],
        });
    })
</script>");
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
