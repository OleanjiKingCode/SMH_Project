#pragma checksum "C:\Users\USER\source\repos\SMH_Project\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cee124322bb83fdd70fe278bd8395038f9e688bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\USER\source\repos\SMH_Project\Views\_ViewImports.cshtml"
using SMH_Project;

#line default
#line hidden
#line 2 "C:\Users\USER\source\repos\SMH_Project\Views\_ViewImports.cshtml"
using SMH_Project.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cee124322bb83fdd70fe278bd8395038f9e688bf", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c377a3918a9befd423ac2d21d320f506be228c0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 311, true);
            WriteLiteral(@"








<!-- Breadcrumb -->
<!-- Page Title -->
<div class=""row no-margin-padding"">
    <div class=""col-md-6"">
        <h3 class=""block-title"">Quick Statistics</h3>
    </div>
    <div class=""col-md-6"">
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item"">
                ");
            EndContext();
            BeginContext(311, 129, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5dace5afcc48447da32fecf57ab67ce6", async() => {
                BeginContext(367, 69, true);
                WriteLiteral("\r\n                    <span class=\"ti-home\"></span>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(440, 8201, true);
            WriteLiteral(@"
            </li>
            <li class=""breadcrumb-item active"">Dashboard</li>
        </ol>
    </div>
</div>
<!-- /Page Title -->
<!-- /Breadcrumb -->
<!-- Main Content -->
<div class=""container-fluid home"">


    <div class=""row"">
        <!-- Widget Item -->
        <div class=""col-md-4"">
            <div class=""widget-area proclinic-box-shadow color-red"">
                <div class=""widget-left"">
                    <span class=""ti-user""></span>
                </div>
                <div class=""widget-right"">
                    <h4 class=""wiget-title"">Patients</h4>
                    <span class=""numeric color-red"">348</span>
                    <p class=""inc-dec mb-0""><span class=""ti-angle-up""></span> +20% Increased</p>
                </div>
            </div>
        </div>
        <!-- /Widget Item -->
        <!-- Widget Item -->
        <div class=""col-md-4"">
            <div class=""widget-area proclinic-box-shadow color-green"">
                <div class=""widget-");
            WriteLiteral(@"left"">
                    <span class=""ti-bar-chart""></span>
                </div>
                <div class=""widget-right"">
                    <h4 class=""wiget-title"">Appointments</h4>
                    <span class=""numeric color-green"">1585</span>
                    <p class=""inc-dec mb-0""><span class=""ti-angle-down""></span> -15% Decreased</p>
                </div>
            </div>
        </div>
        <!-- /Widget Item -->
        <!-- Widget Item -->
        <div class=""col-md-4"">
            <div class=""widget-area proclinic-box-shadow color-yellow"">
                <div class=""widget-left"">
                    <span class=""ti-money""></span>
                </div>
                <div class=""widget-right"">
                    <h4 class=""wiget-title"">Total Revenue</h4>
                    <span class=""numeric color-yellow"">$7300</span>
                    <p class=""inc-dec mb-0""><span class=""ti-angle-up""></span> +10% Increased</p>
                </div>
            </div>");
            WriteLiteral(@"
        </div>
        <!-- /Widget Item -->
    </div>



    <div class=""row"">
        <!-- Widget Item -->
        <div class=""col-md-12"">
            <div class=""widget-area-2 proclinic-box-shadow"">
                <h3 class=""widget-title"">Appointments</h3>
                <div class=""table-responsive"">
                    <table class=""table table-bordered table-striped"">
                        <thead>
                            <tr>
                                <th>Patient Name</th>
                                <th>Doctor</th>
                                <th>Check-Up</th>
                                <th>Date</th>
                                <th>Time</th>
                                <th>Status</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>Rajesh</td>
                                <td>Manoj Kumar</td>
                         ");
            WriteLiteral(@"       <td>Dental</td>
                                <td>12-10-2018</td>
                                <td>12:10PM</td>
                                <td>
                                    <span class=""badge badge-success"">Completed</span>
                                </td>
                            </tr>
                            <tr>
                                <td>Riya</td>
                                <td>Daniel </td>
                                <td>Ortho</td>
                                <td>12-10-2018</td>
                                <td>1:10PM</td>
                                <td>
                                    <span class=""badge badge-warning"">Pending</span>
                                </td>
                            </tr>
                            <tr>
                                <td>Siri</td>
                                <td>Daniel </td>
                                <td>Ortho</td>
                                <td>12-");
            WriteLiteral(@"10-2018</td>
                                <td>1:30PM</td>
                                <td>
                                    <span class=""badge badge-danger"">Cancelled</span>
                                </td>
                            </tr>
                            <tr>
                                <td>Rajesh</td>
                                <td>Manoj Kumar</td>
                                <td>Dental</td>
                                <td>12-10-2018</td>
                                <td>12:10PM</td>
                                <td>
                                    <span class=""badge badge-success"">Completed</span>
                                </td>
                            </tr>
                            <tr>
                                <td>Riya</td>
                                <td>Daniel </td>
                                <td>Ortho</td>
                                <td>12-10-2018</td>
                                <td>1:10P");
            WriteLiteral(@"M</td>
                                <td>
                                    <span class=""badge badge-warning"">Pending</span>
                                </td>
                            </tr>
                            <tr>
                                <td>Siri</td>
                                <td>Daniel </td>
                                <td>Ortho</td>
                                <td>12-10-2018</td>
                                <td>1:30PM</td>
                                <td>
                                    <span class=""badge badge-danger"">Cancelled</span>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
        <!-- /Widget Item -->
    </div>

    <div class=""row"">
        <!-- Widget Item -->
        <!-- /Widget Item -->
        <!-- Widget Item -->
        <div class=""col-md-6"">
            <div class=");
            WriteLiteral(@"""widget-area-2 progress-status proclinic-box-shadow"">
                <h3 class=""widget-title"">Doctors Availability</h3>
                <div class=""table-responsive"">
                    <table class=""table table-bordered"">
                        <thead>
                            <tr>
                                <th>Doctor</th>
                                <th>Speciality</th>
                                <th>Availability</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>Rajesh</td>
                                <td>Dental</td>
                                <td>
                                    <span class=""badge badge-success"">Available</span>
                                </td>
                            </tr>
                            <tr>
                                <td>Riya</td>
                                <td>Ortho</td>
        ");
            WriteLiteral(@"                        <td>
                                    <span class=""badge badge-warning"">On Leave</span>
                                </td>
                            </tr>
                            <tr>
                                <td>Siri</td>
                                <td>Skin</td>
                                <td>
                                    <span class=""badge badge-danger"">Not Available</span>
                                </td>
                            </tr>
                            <tr>
                                <td>Rajesh</td>
                                <td>Dental</td>
                                <td>
                                    <span class=""badge badge-success"">Available</span>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>

            </div>
        </div>
        <!-- /Widget Item -->

    </div>
            WriteLiteral("\n\r\n</div>");
            EndContext();
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