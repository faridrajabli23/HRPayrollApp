#pragma checksum "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb0cc8746acfa6ea7b31d5edc2fb2f0d70b22b3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_HRPayroll_Views_Admin_EmployeeDetails), @"mvc.1.0.view", @"/Areas/HRPayroll/Views/Admin/EmployeeDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/HRPayroll/Views/Admin/EmployeeDetails.cshtml", typeof(AspNetCore.Areas_HRPayroll_Views_Admin_EmployeeDetails))]
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
#line 1 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\_ViewImports.cshtml"
using PayrollApp.Areas.HRPayroll.Models;

#line default
#line hidden
#line 2 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\_ViewImports.cshtml"
using PayrollApp.Areas.HRPayroll.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb0cc8746acfa6ea7b31d5edc2fb2f0d70b22b3c", @"/Areas/HRPayroll/Views/Admin/EmployeeDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e335acc40c4165e5fba0ad40156250e899745d0", @"/Areas/HRPayroll/Views/_ViewImports.cshtml")]
    public class Areas_HRPayroll_Views_Admin_EmployeeDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WorkPlaceDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 64, true);
            WriteLiteral("<div class=\"main-menu\">\r\n    <header class=\"header\">\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 89, "\"", 128, 1);
#line 4 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeDetails.cshtml"
WriteAttributeValue("", 96, Url.Action("UserIndex","Admin"), 96, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(129, 302, true);
            WriteLiteral(@" class=""logo"">Payroll</a>
        <button type=""button"" class=""button-close fa fa-times js__menu_close""></button>
    </header>
    <div class=""content"">
        <div class=""navigation"">
            <ul class=""menu js__accordion"">
                <li>
                    <a class=""waves-effect""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 431, "\"", 470, 1);
#line 11 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeDetails.cshtml"
WriteAttributeValue("", 438, Url.Action("UserIndex","Admin"), 438, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(471, 166, true);
            WriteLiteral("><i class=\"menu-icon fas fa-users\"></i><span>User</span></a>\r\n                </li>\r\n                <li class=\"current\">\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 637, "\"", 680, 1);
#line 14 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeDetails.cshtml"
WriteAttributeValue("", 644, Url.Action("EmployeeIndex","Admin"), 644, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(681, 153, true);
            WriteLiteral("><i class=\"menu-icon far fa-user\"></i><span>Employee</span></a>\r\n                </li>\r\n                <li>\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 834, "\"", 873, 1);
#line 17 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeDetails.cshtml"
WriteAttributeValue("", 841, Url.Action("RoleIndex","Admin"), 841, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(874, 157, true);
            WriteLiteral("><i class=\"menu-icon fas fa-address-book\"></i><span>Role</span></a>\r\n                </li>\r\n                <li>\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1031, "\"", 1071, 1);
#line 20 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeDetails.cshtml"
WriteAttributeValue("", 1038, Url.Action("Department","Admin"), 1038, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1072, 164, true);
            WriteLiteral("><i class=\"menu-icon fas fa-briefcase\"></i></i><span>Department</span></a>\r\n                </li>\r\n                <li>\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1236, "\"", 1278, 1);
#line 23 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeDetails.cshtml"
WriteAttributeValue("", 1243, Url.Action("CompanyIndex","Admin"), 1243, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1279, 153, true);
            WriteLiteral("><i class=\"menu-icon fas fa-hotel\"></i><span>Company</span></a>\r\n                </li>\r\n                <li>\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1432, "\"", 1473, 1);
#line 26 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeDetails.cshtml"
WriteAttributeValue("", 1439, Url.Action("BranchIndex","Admin"), 1439, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1474, 158, true);
            WriteLiteral("><i class=\"menu-icon fas fa-code-branch\"></i><span>Branch</span></a>\r\n                </li>\r\n                <li>\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1632, "\"", 1675, 1);
#line 29 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeDetails.cshtml"
WriteAttributeValue("", 1639, Url.Action("PositionIndex","Admin"), 1639, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1676, 158, true);
            WriteLiteral("><i class=\"menu-icon fas fa-user-edit\"></i><span>Position</span></a>\r\n                </li>\r\n                <li>\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1834, "\"", 1871, 1);
#line 32 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeDetails.cshtml"
WriteAttributeValue("", 1841, Url.Action("Holiday","Admin"), 1841, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1872, 158, true);
            WriteLiteral("><i class=\"menu-icon fas fa-user-clock\"></i><span>Holiday</span></a>\r\n                </li>\r\n                <li>\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2030, "\"", 2076, 1);
#line 35 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeDetails.cshtml"
WriteAttributeValue("", 2037, Url.Action("StipulationIndex","Admin"), 2037, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2077, 943, true);
            WriteLiteral(@"><i class=""menu-icon fas fa-sort-amount-up-alt""></i><span>Stipulation</span></a>
                </li>
            </ul>
        </div>
    </div>
</div>

<div class=""fixed-navbar"">
    <div class=""pull-left"">
        <button type=""button"" class=""menu-mobile-button glyphicon glyphicon-menu-hamburger js__menu_mobile""></button>
        <h1 class=""page-title"">Employee</h1>
    </div>
    <div class=""pull-right"">
        <div class=""ico-item"">
            <a href=""#"" class=""ico-item fa fa-search js__toggle_open"" data-target=""#searchform-header""></a>
            <div id=""searchform-header"" class=""searchform js__toggle userSearchForm""><input type=""search"" placeholder=""Search..."" class=""input-search"" id=""userSearch""><button onclick=""employeeSearcher()"" class=""fa fa-search button-search"" type=""button""></button></div>
        </div>
        <div class=""ico-item""><label>Admin</label></div>
        <div class=""ico-item""><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3020, "\"", 3059, 1);
#line 53 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeDetails.cshtml"
WriteAttributeValue("", 3027, Url.Action("Signout","Account"), 3027, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3060, 386, true);
            WriteLiteral(@"><p style=""font-size:smaller"">Log Out  <i class=""fas fa-sign-out-alt""></i></p></a></div>
    </div>
</div>
<div id=""wrapper"">
    <div class=""main-content"">
        <div class=""row"">
            <div class=""col-md-3 col-xs-12"">
                <div class=""box-content bordered primary margin-bottom-20"">
                    <div class=""profile-avatar"">
                        ");
            EndContext();
            BeginContext(3446, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "45866c145c434cf981fdaeddf36c9e55", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3456, "~/Admin/uploads/", 3456, 16, true);
#line 62 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeDetails.cshtml"
AddHtmlAttributeValue("", 3472, Model.Photo, 3472, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3493, 38, true);
            WriteLiteral("\r\n                        <h3><strong>");
            EndContext();
            BeginContext(3532, 10, false);
#line 63 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeDetails.cshtml"
                               Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3542, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3544, 13, false);
#line 63 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeDetails.cshtml"
                                           Write(Model.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(3557, 44, true);
            WriteLiteral("</strong></h3>\r\n                        <h4>");
            EndContext();
            BeginContext(3602, 15, false);
#line 64 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeDetails.cshtml"
                       Write(Model.Education);

#line default
#line hidden
            EndContext();
            BeginContext(3617, 596, true);
            WriteLiteral(@"</h4>
                    </div>
                </div>
            </div>
            <div class="" col-md-9 col-xs-12"">
                <div class=""box-content card"">
                    <h4 class=""box-title""><i class=""fa fa-user ico""></i>About</h4>
                    <div class=""card-content"">
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <div class=""row"">
                                    <div class=""col-xs-5""><label>Name:</label></div>
                                    <div class=""col-xs-7"">");
            EndContext();
            BeginContext(4214, 10, false);
#line 76 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeDetails.cshtml"
                                                     Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4224, 334, true);
            WriteLiteral(@"</div>
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""row"">
                                    <div class=""col-xs-5""><label>Surname:</label></div>
                                    <div class=""col-xs-7"">");
            EndContext();
            BeginContext(4559, 13, false);
#line 82 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeDetails.cshtml"
                                                     Write(Model.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(4572, 336, true);
            WriteLiteral(@"</div>
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""row"">
                                    <div class=""col-xs-5""><label>Education:</label></div>
                                    <div class=""col-xs-7"">");
            EndContext();
            BeginContext(4909, 15, false);
#line 88 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeDetails.cshtml"
                                                     Write(Model.Education);

#line default
#line hidden
            EndContext();
            BeginContext(4924, 333, true);
            WriteLiteral(@"</div>
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""row"">
                                    <div class=""col-xs-5""><label>Address</label></div>
                                    <div class=""col-xs-7"">");
            EndContext();
            BeginContext(5258, 13, false);
#line 94 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeDetails.cshtml"
                                                     Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(5271, 341, true);
            WriteLiteral(@"</div>
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""row"">
                                    <div class=""col-xs-5""><label>Marital Status:</label></div>
                                    <div class=""col-xs-7"">");
            EndContext();
            BeginContext(5613, 19, false);
#line 100 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeDetails.cshtml"
                                                     Write(Model.MaritalStatus);

#line default
#line hidden
            EndContext();
            BeginContext(5632, 333, true);
            WriteLiteral(@"</div>
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""row"">
                                    <div class=""col-xs-5""><label>Gender:</label></div>
                                    <div class=""col-xs-7"">");
            EndContext();
            BeginContext(5966, 12, false);
#line 106 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeDetails.cshtml"
                                                     Write(Model.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(5978, 335, true);
            WriteLiteral(@"</div>
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""row"">
                                    <div class=""col-xs-5""><label>Birthday:</label></div>
                                    <div class=""col-xs-7"">");
            EndContext();
            BeginContext(6314, 14, false);
#line 112 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeDetails.cshtml"
                                                     Write(Model.Birthday);

#line default
#line hidden
            EndContext();
            BeginContext(6328, 335, true);
            WriteLiteral(@"</div>
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""row"">
                                    <div class=""col-xs-5""><label>Position:</label></div>
                                    <div class=""col-xs-7"">");
            EndContext();
            BeginContext(6664, 14, false);
#line 118 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeDetails.cshtml"
                                                     Write(Model.Position);

#line default
#line hidden
            EndContext();
            BeginContext(6678, 336, true);
            WriteLiteral(@"</div>
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""row"">
                                    <div class=""col-xs-5""><label>Department</label></div>
                                    <div class=""col-xs-7"">");
            EndContext();
            BeginContext(7015, 16, false);
#line 124 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeDetails.cshtml"
                                                     Write(Model.Department);

#line default
#line hidden
            EndContext();
            BeginContext(7031, 334, true);
            WriteLiteral(@"</div>
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""row"">
                                    <div class=""col-xs-5""><label>Company:</label></div>
                                    <div class=""col-xs-7"">");
            EndContext();
            BeginContext(7366, 13, false);
#line 130 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeDetails.cshtml"
                                                     Write(Model.Company);

#line default
#line hidden
            EndContext();
            BeginContext(7379, 332, true);
            WriteLiteral(@"</div>
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""row"">
                                    <div class=""col-xs-5""><label>Salary</label></div>
                                    <div class=""col-xs-7"">");
            EndContext();
            BeginContext(7712, 12, false);
#line 136 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeDetails.cshtml"
                                                     Write(Model.Salary);

#line default
#line hidden
            EndContext();
            BeginContext(7724, 672, true);
            WriteLiteral(@"</div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-xs-12"">
                <table id=""oldWorkPlaces"" class=""display nowrap"" style=""width:100%"">
                    <thead>
                        <tr>
                            <th>Company name</th>
                            <th>Entry date</th>
                            <th>Resignation date</th>
                            <th>Resignation reason</th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 154 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeDetails.cshtml"
                         foreach (var item in Model.OldWorkPlaces)
                        {

#line default
#line hidden
            BeginContext(8491, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(8562, 9, false);
#line 157 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeDetails.cshtml"
                               Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(8571, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(8615, 14, false);
#line 158 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeDetails.cshtml"
                               Write(item.EntryDate);

#line default
#line hidden
            EndContext();
            BeginContext(8629, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(8673, 12, false);
#line 159 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeDetails.cshtml"
                               Write(item.EndDate);

#line default
#line hidden
            EndContext();
            BeginContext(8685, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(8729, 14, false);
#line 160 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeDetails.cshtml"
                               Write(item.EndReason);

#line default
#line hidden
            EndContext();
            BeginContext(8743, 42, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n");
            EndContext();
#line 162 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeDetails.cshtml"
                        }

#line default
#line hidden
            BeginContext(8812, 114, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WorkPlaceDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591