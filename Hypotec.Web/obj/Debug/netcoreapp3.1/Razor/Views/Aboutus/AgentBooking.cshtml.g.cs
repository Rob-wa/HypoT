#pragma checksum "E:\Project\Hypotec-MGLD\Hypotec.Web\Views\Aboutus\AgentBooking.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcb7dd5c7f7a7c2b2d04d73b38640921bc56cfa0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Aboutus_AgentBooking), @"mvc.1.0.view", @"/Views/Aboutus/AgentBooking.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcb7dd5c7f7a7c2b2d04d73b38640921bc56cfa0", @"/Views/Aboutus/AgentBooking.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e0cb572af3a04e862bb8624c174daedf36e861f", @"/Views/_ViewImports.cshtml")]
    public class Views_Aboutus_AgentBooking : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Project\Hypotec-MGLD\Hypotec.Web\Views\Aboutus\AgentBooking.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcb7dd5c7f7a7c2b2d04d73b38640921bc56cfa03414", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcb7dd5c7f7a7c2b2d04d73b38640921bc56cfa04473", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 13 "E:\Project\Hypotec-MGLD\Hypotec.Web\Views\Aboutus\AgentBooking.cshtml"
     using (Html.BeginForm("Index", "Home", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <table border=\"0\" cellpadding=\"5\" cellspacing=\"0\">\r\n            <tr>\r\n                <td>Location</td>\r\n                <td>");
#nullable restore
#line 18 "E:\Project\Hypotec-MGLD\Hypotec.Web\Views\Aboutus\AgentBooking.cshtml"
               Write(Html.TextBox("txtLocation"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Address</td>\r\n                <td>");
#nullable restore
#line 22 "E:\Project\Hypotec-MGLD\Hypotec.Web\Views\Aboutus\AgentBooking.cshtml"
               Write(Html.TextBox("txtAddress"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Latitude</td>\r\n                <td>");
#nullable restore
#line 26 "E:\Project\Hypotec-MGLD\Hypotec.Web\Views\Aboutus\AgentBooking.cshtml"
               Write(Html.TextBox("txtLatitude"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Longitude</td>\r\n                <td>");
#nullable restore
#line 30 "E:\Project\Hypotec-MGLD\Hypotec.Web\Views\Aboutus\AgentBooking.cshtml"
               Write(Html.TextBox("txtLongitude"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td></td>\r\n                <td><input type=\"submit\" value=\"Submit\" /></td>\r\n            </tr>\r\n        </table>\r\n");
#nullable restore
#line 37 "E:\Project\Hypotec-MGLD\Hypotec.Web\Views\Aboutus\AgentBooking.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <script type=""text/javascript"" src=""https://maps.googleapis.com/maps/api/js?sensor=false&libraries=places&key=AIzaSyCvc4mkPDRa1B2tlQT6pQGzgSkhqHx9wQg""></script>
    <script type=""text/javascript"">
        google.maps.event.addDomListener(window, 'load', function () {
            var places = new google.maps.places.Autocomplete(document.getElementById('txtLocation'));
            google.maps.event.addListener(places, 'place_changed', function () {
                var place = places.getPlace();
                document.getElementById('txtAddress').value = place.formatted_address;
                document.getElementById('txtLatitude').value = place.geometry.location.lat();
                document.getElementById('txtLongitude').value = place.geometry.location.lng();
            });
        });
    </script>
");
#nullable restore
#line 50 "E:\Project\Hypotec-MGLD\Hypotec.Web\Views\Aboutus\AgentBooking.cshtml"
     if (ViewBag.Message != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script type=\"text/javascript\">\r\n            window.onload = function(){\r\n                alert(\"");
#nullable restore
#line 54 "E:\Project\Hypotec-MGLD\Hypotec.Web\Views\Aboutus\AgentBooking.cshtml"
                  Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\r\n            };\r\n        </script>\r\n");
#nullable restore
#line 57 "E:\Project\Hypotec-MGLD\Hypotec.Web\Views\Aboutus\AgentBooking.cshtml"
    }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
