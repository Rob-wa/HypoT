#pragma checksum "E:\Project\Hypotec-MGLD\Hypotec.Web\Views\Account\StartRefinance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89629c96218f670bf24f1992b4cf37c958d746b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_StartRefinance), @"mvc.1.0.view", @"/Views/Account/StartRefinance.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89629c96218f670bf24f1992b4cf37c958d746b1", @"/Views/Account/StartRefinance.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e0cb572af3a04e862bb8624c174daedf36e861f", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_StartRefinance : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\Project\Hypotec-MGLD\Hypotec.Web\Views\Account\StartRefinance.cshtml"
  
    ViewData["Title"] = "StartRefinance";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""careerDetailsPage"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-12"" id=""divpagefirstr"">
                <div class=""questionlist"">
                    <div class=""questionText"">
                        <h2>Why do you want to <span class=""blue-text"">refinance?</span></h2>
                    </div>
                    <ul class=""p-0 m-0"">
                        <li>
                            <div class=""form-check"">
                                <input class=""form-check-input"" type=""radio"" name=""exampleRadios"" id=""exampleRadios19"" value=""option19"">
                                <label class=""form-check-label"" for=""exampleRadios19"">
                                    Lower my monthly payment
                                </label>
                            </div>
                        </li>
                        <li>
                            <div class=""form-check"">
                                <input class=");
            WriteLiteral(@"""form-check-input"" type=""radio"" name=""exampleRadios"" id=""exampleRadios20"" value=""option20"">
                                <label class=""form-check-label"" for=""exampleRadios20"">
                                    Take cash out to pay for other expenses (home improvement, emergency fund, college tuition)
                                </label>
                            </div>
                        </li>
                        <li>
                            <div class=""form-check"">
                                <input class=""form-check-input"" type=""radio"" name=""exampleRadios"" id=""exampleRadios21"" value=""option21"">
                                <label class=""form-check-label"" for=""exampleRadios21"">
                                    Pay off my existing mortgage sooner
                                </label>
                            </div>
                        </li>
                        <li>
                            <div class=""form-check"">
                             ");
            WriteLiteral(@"   <input class=""form-check-input"" type=""radio"" name=""exampleRadios"" id=""exampleRadios22"" value=""option22"">
                                <label class=""form-check-label"" for=""exampleRadios22"">
                                    Consolidate high-interest debts into a single payment
                                </label>
                            </div>
                        </li>
                        <li>
                            <div class=""form-check"">
                                <input class=""form-check-input"" type=""radio"" name=""exampleRadios"" id=""exampleRadios23"" value=""option23"">
                                <label class=""form-check-label"" for=""exampleRadios23"">
                                    Other
                                </label>
                            </div>
                        </li>
                    </ul>
                </div>

                <div class=""questionlist"" id=""div1r"">
                    <div class=""questionText mt-3"">
    ");
            WriteLiteral(@"                    <h2>Explain in your own words?</h2>
                        <input type=""text"" class=""form-control"" id=""explainWord"">
                    </div>
                </div>
                <div class=""wzrdbtn"">
                    <button class=""btn"" id=""btnNextR"" onclick=""NextPageR();"" disabled>Next</button>
                </div>
            </div>
            <div class=""col-md-12"" id=""divpagesecondR"">
                <div class=""questionlist"" id=""div2"">
                    <div></div>
                    <div class=""col-md-8"">
                        <div class=""questionText mt-3"">
                            <h2>
                                Add your property to personalize rates
                            </h2>
                            <div class=""col-md-12 px-0"">
                                <div class=""form-group"">
                                    <div class=""col-md-8 px-0"">
                                        <label");
            BeginWriteAttribute("for", " for=\"", 4160, "\"", 4166, 0);
            EndWriteAttribute();
            WriteLiteral(@">Address </label>
                                        <input type=""text"" id=""addPropertyRateAdd"" class=""form-control"" />

                                    </div>
                                </div>
                                <div class=""form-group"" id=""divaptunit"">
                                    <div class=""col-md-4 px-0"">
                                        <label");
            BeginWriteAttribute("for", " for=\"", 4565, "\"", 4571, 0);
            EndWriteAttribute();
            WriteLiteral(@">Apt/Unit</label>
                                        <input type=""text"" id=""aptunit"" class=""form-control"" />
                                    </div>
                                </div>
                            </div>
                            <div id=""openProp"">
                                <div class=""form-group"">
                                    <div class=""col-md-4 px-0"">
                                        <label");
            BeginWriteAttribute("for", " for=\"", 5026, "\"", 5032, 0);
            EndWriteAttribute();
            WriteLiteral(@">City </label>
                                        <input type=""text"" id=""City"" class=""form-control"" />

                                    </div>
                                    <div class=""col-md-4 px-0"">
                                        <label");
            BeginWriteAttribute("for", " for=\"", 5300, "\"", 5306, 0);
            EndWriteAttribute();
            WriteLiteral(@">State </label>
                                        <input type=""text"" id=""State"" class=""form-control"" />

                                    </div>
                                    <div class=""col-md-4 px-0"">
                                        <label");
            BeginWriteAttribute("for", " for=\"", 5576, "\"", 5582, 0);
            EndWriteAttribute();
            WriteLiteral(@">Zip Code </label>
                                        <input type=""text"" id=""zipcode"" class=""form-control"" />

                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>

                </div>
                <div class=""wzrdbtn"">
                    <button class=""btn"" id=""btnPrevious1"" onclick=""PreviousPage1();"">previous</button>
                    <button class=""btn"" id=""btnNextPager2"" onclick=""NextPager2();"" disabled>Next</button>

                </div>
            </div>
            <div class=""col-md-12"" id=""divpagesecondThird"">
                <div class=""questionlist"">
                    <div class=""questionText"">
                        <h2>Tell us more about the property you <span class=""blue-text"">are refinancing?</span></h2>
                    </div>
                    <ul class=""p-0 m-0"">
                        <li>
                            <d");
            WriteLiteral(@"iv class=""form-check"">
                                <input class=""form-check-input"" type=""radio"" name=""exampleRadios2"" id=""exampleRadios24"" value=""option24"">
                                <label class=""form-check-label2"" for=""exampleRadios24"">
                                    Primary residence
                                </label>
                            </div>

                        </li>
                        <li>
                            <div class=""form-check"">
                                <input class=""form-check-input"" type=""radio"" name=""exampleRadios2"" id=""exampleRadios25"" value=""option25"">
                                <label class=""form-check-label2"" for=""exampleRadios25"">
                                    Second home
                                </label>
                            </div>
                        </li>
                        <li>
                            <div class=""form-check"">
                                <input class=""form-c");
            WriteLiteral(@"heck-input"" type=""radio"" name=""exampleRadios2"" id=""exampleRadios26"" value=""option26"">
                                <label class=""form-check-label2"" for=""exampleRadios26"">
                                    Investment
                                </label>
                            </div>
                        </li>

                    </ul>
                </div>
                <div class=""questionlist"">
                    <div class=""questionText"">
                        <h2>What property type  <span class=""blue-text"">would this be?</span></h2>
                    </div>
                    <ul class=""p-0 m-0"">
                        <li>
                            <div class=""form-check"">
                                <input class=""form-check-input"" type=""radio"" name=""exampleRadios3"" id=""exampleRadios27"" value=""option27"">
                                <label class=""form-check-label3"" for=""exampleRadios27"">
                                    Single Family
             ");
            WriteLiteral(@"                   </label>
                            </div>
                        </li>
                        <li>
                            <div class=""form-check"">
                                <input class=""form-check-input"" type=""radio"" name=""exampleRadios3"" id=""exampleRadios28"" value=""optio28"">
                                <label class=""form-check-label3"" for=""exampleRadios28"">
                                    Townhouse or Condo
                                </label>
                            </div>
                        </li>
                        <li>
                            <div class=""form-check"">
                                <input class=""form-check-input"" type=""radio"" name=""exampleRadios3"" id=""exampleRadios29"" value=""option29"">
                                <label class=""form-check-label"" for=""exampleRadios29"">
                                    2 to 4 units
                                </label>
                            </div>
             ");
            WriteLiteral(@"           </li>
                        <li>
                            <div class=""form-check"">
                                <input class=""form-check-input"" type=""radio"" name=""exampleRadios3"" id=""exampleRadios30"" value=""option30"">
                                <label class=""form-check-label"" for=""exampleRadios30"">
                                    Cooperative
                                </label>
                            </div>
                        </li>

                    </ul>
                    <div class=""questionText mt-3"">
                        <h2>Estimated home value?</h2>
                        <div class=""input-group"">
                            <div class=""input-group-prepend"">
                                <div class=""input-group-text border-right-0 bg-transparent""><i class=""fas fa-dollar-sign""></i></div>
                            </div>

                            <input type=""text"" class=""form-control border-left-0""");
            BeginWriteAttribute("value", " value=\"", 10671, "\"", 10679, 0);
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Amount"" id=""extimatedHomeVal"" />
                        </div>

                    </div>
                    <div class=""wzrdbtn"">
                        <button class=""btn"" id=""btnPrevious2"" onclick=""PreviousPage2();"">previous</button>
                        <a type=""button""");
            BeginWriteAttribute("href", " href=\'", 10981, "\'", 11024, 1);
#nullable restore
#line 208 "E:\Project\Hypotec-MGLD\Hypotec.Web\Views\Account\StartRefinance.cshtml"
WriteAttributeValue("", 10988, Url.Action("GetStarted", "Account"), 10988, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn\" id=\"btnNextPageToRefinance\" disabled>\r\n                            Next\r\n\r\n                        </a>\r\n");
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<script type=""text/javascript"" src=""https://maps.googleapis.com/maps/api/js?sensor=false&libraries=places&key=AIzaSyD95mg60xSmPy1bY-CjxaOW12Vl6Pt_qSQ""></script>
<script type=""text/javascript"">
    google.maps.event.addDomListener(window, 'load', function () {
        var places = new google.maps.places.Autocomplete(document.getElementById('addPropertyRateAdd'));
        google.maps.event.addListener(places, 'place_changed', function () {
            var place = places.getPlace();
            for (var i = 0; i < place.address_components.length; i++) {
                for (var j = 0; j < place.address_components[i].types.length; j++) {

                    if (place.address_components[i].types[j] == ""postal_code"") {
                        $('#zipcode').val(place.address_components[i].long_name);
                    }
                    if (place.address_components[i].types[j] == ""adminis");
            WriteLiteral(@"trative_area_level_1"") {
                        $('#State').val(place.address_components[i].long_name);
                    }
                    if (place.address_components[i].types[j] === ""locality"") {
                        $('#City').val(place.address_components[i].long_name);
                    }
                }
            }
            //document.getElementById('txtAddress').value = place.formatted_address;
            //document.getElementById('txtLatitude').value = place.geometry.location.lat();
            //document.getElementById('txtLongitude').value = place.geometry.location.lng();
        });
    });
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
