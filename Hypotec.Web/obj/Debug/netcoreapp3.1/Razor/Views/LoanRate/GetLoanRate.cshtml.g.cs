#pragma checksum "E:\Project\Hypotec-MGLD\Hypotec.Web\Views\LoanRate\GetLoanRate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6af813a209c3082a5ea73c758589f25eb742405b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LoanRate_GetLoanRate), @"mvc.1.0.view", @"/Views/LoanRate/GetLoanRate.cshtml")]
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
#line 1 "E:\Project\Hypotec-MGLD\Hypotec.Web\Views\_ViewImports.cshtml"
using Hypotec.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Project\Hypotec-MGLD\Hypotec.Web\Views\_ViewImports.cshtml"
using Hypotec.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6af813a209c3082a5ea73c758589f25eb742405b", @"/Views/LoanRate/GetLoanRate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e0cb572af3a04e862bb8624c174daedf36e861f", @"/Views/_ViewImports.cshtml")]
    public class Views_LoanRate_GetLoanRate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Hypotec.Service.Dto.LoanRateDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Project\Hypotec-MGLD\Hypotec.Web\Views\LoanRate\GetLoanRate.cshtml"
  
    ViewData["Title"] = "GetLoanRate";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<style>
    #right-panel {
        font-family: ""Roboto"", ""sans-serif"";
        line-height: 30px;
        padding-left: 10px;
    }

        #right-panel select,
        #right-panel input {
            font-size: 15px;
        }

        #right-panel select {
            width: 100%;
        }

        #right-panel i {
            font-size: 12px;
        }

    html,
    body {
        height: 100%;
        margin: 0;
        padding: 0;
    }

    #map {
        height: 100%;
        width: 50%;
    }

    #right-panel {
        float: right;
        width: 48%;
        padding-left: 2%;
    }

    #output {
        font-size: 11px;
    }
</style>



<div id=""right-panel"">
    <div id=""inputs"">
        <pre>
var origin1 = {lat: 55.930, lng: -3.118};
var origin2 = 'Greenwich, England';
var destinationA = 'Stockholm, Sweden';
var destinationB = {lat: 50.087, lng: 14.421};
        </pre>
    </div>
    <div>
        <strong>Results</strong>
    </di");
            WriteLiteral("v>\r\n    <div id=\"output\"></div>\r\n</div>\r\n<div id=\"map\"></div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 71 "E:\Project\Hypotec-MGLD\Hypotec.Web\Views\LoanRate\GetLoanRate.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Hypotec.Service.Dto.LoanRateDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
