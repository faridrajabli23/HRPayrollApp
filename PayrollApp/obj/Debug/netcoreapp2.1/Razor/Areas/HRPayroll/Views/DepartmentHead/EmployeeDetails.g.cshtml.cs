#pragma checksum "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\DepartmentHead\EmployeeDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7afe3319ddd501c202cca50da273c215087d5faf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_HRPayroll_Views_DepartmentHead_EmployeeDetails), @"mvc.1.0.view", @"/Areas/HRPayroll/Views/DepartmentHead/EmployeeDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/HRPayroll/Views/DepartmentHead/EmployeeDetails.cshtml", typeof(AspNetCore.Areas_HRPayroll_Views_DepartmentHead_EmployeeDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7afe3319ddd501c202cca50da273c215087d5faf", @"/Areas/HRPayroll/Views/DepartmentHead/EmployeeDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e335acc40c4165e5fba0ad40156250e899745d0", @"/Areas/HRPayroll/Views/_ViewImports.cshtml")]
    public class Areas_HRPayroll_Views_DepartmentHead_EmployeeDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdminEmployeeModel>
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
            BeginContext(27, 64, true);
            WriteLiteral("<div class=\"main-menu\">\r\n    <header class=\"header\">\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 91, "\"", 143, 1);
#line 4 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\DepartmentHead\EmployeeDetails.cshtml"
WriteAttributeValue("", 98, Url.Action("EmployeeIndex","DepartmentHead"), 98, 45, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(144, 318, true);
            WriteLiteral(@" class=""logo"">Payroll</a>
        <button type=""button"" class=""button-close fa fa-times js__menu_close""></button>
    </header>
    <div class=""content"">
        <div class=""navigation"">
            <ul class=""menu js__accordion"">
                <li class=""current"">
                    <a class=""waves-effect""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 462, "\"", 514, 1);
#line 11 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\DepartmentHead\EmployeeDetails.cshtml"
WriteAttributeValue("", 469, Url.Action("EmployeeIndex","DepartmentHead"), 469, 45, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(515, 905, true);
            WriteLiteral(@"><i class=""menu-icon fas fa-users""></i><span>Employee</span></a>
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
            <div id=""searchform-header"" class=""searchform js__toggle userSearchForm""><input type=""search"" placeholder=""Search..."" class=""input-search"" id=""userSearch""><button class=""fa fa-search button-search"" type=""button""></button></div>
        </div>
        <div class=""ico-item""><label>Department</label></div>
        <div class=""ico-item""><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1420, "\"", 1459, 1);
#line 30 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\DepartmentHead\EmployeeDetails.cshtml"
WriteAttributeValue("", 1427, Url.Action("Signout","Account"), 1427, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1460, 386, true);
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
            BeginContext(1846, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3f8f7b5d7e7d43c09f3741d32011a186", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1856, "~/Admin/uploads/", 1856, 16, true);
#line 39 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\DepartmentHead\EmployeeDetails.cshtml"
AddHtmlAttributeValue("", 1872, Model.WorkPlace.Employee.Photo, 1872, 31, false);

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
            BeginContext(1912, 38, true);
            WriteLiteral("\r\n                        <h3><strong>");
            EndContext();
            BeginContext(1951, 29, false);
#line 40 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\DepartmentHead\EmployeeDetails.cshtml"
                               Write(Model.WorkPlace.Employee.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1980, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1982, 32, false);
#line 40 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\DepartmentHead\EmployeeDetails.cshtml"
                                                              Write(Model.WorkPlace.Employee.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(2014, 44, true);
            WriteLiteral("</strong></h3>\r\n                        <h4>");
            EndContext();
            BeginContext(2059, 34, false);
#line 41 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\DepartmentHead\EmployeeDetails.cshtml"
                       Write(Model.WorkPlace.Employee.Education);

#line default
#line hidden
            EndContext();
            BeginContext(2093, 596, true);
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
            BeginContext(2690, 29, false);
#line 53 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\DepartmentHead\EmployeeDetails.cshtml"
                                                     Write(Model.WorkPlace.Employee.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2719, 334, true);
            WriteLiteral(@"</div>
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""row"">
                                    <div class=""col-xs-5""><label>Surname:</label></div>
                                    <div class=""col-xs-7"">");
            EndContext();
            BeginContext(3054, 32, false);
#line 59 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\DepartmentHead\EmployeeDetails.cshtml"
                                                     Write(Model.WorkPlace.Employee.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(3086, 336, true);
            WriteLiteral(@"</div>
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""row"">
                                    <div class=""col-xs-5""><label>Education:</label></div>
                                    <div class=""col-xs-7"">");
            EndContext();
            BeginContext(3423, 34, false);
#line 65 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\DepartmentHead\EmployeeDetails.cshtml"
                                                     Write(Model.WorkPlace.Employee.Education);

#line default
#line hidden
            EndContext();
            BeginContext(3457, 333, true);
            WriteLiteral(@"</div>
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""row"">
                                    <div class=""col-xs-5""><label>Address</label></div>
                                    <div class=""col-xs-7"">");
            EndContext();
            BeginContext(3791, 32, false);
#line 71 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\DepartmentHead\EmployeeDetails.cshtml"
                                                     Write(Model.WorkPlace.Employee.Address);

#line default
#line hidden
            EndContext();
            BeginContext(3823, 341, true);
            WriteLiteral(@"</div>
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""row"">
                                    <div class=""col-xs-5""><label>Marital Status:</label></div>
                                    <div class=""col-xs-7"">");
            EndContext();
            BeginContext(4165, 38, false);
#line 77 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\DepartmentHead\EmployeeDetails.cshtml"
                                                     Write(Model.WorkPlace.Employee.MaritalStatus);

#line default
#line hidden
            EndContext();
            BeginContext(4203, 333, true);
            WriteLiteral(@"</div>
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""row"">
                                    <div class=""col-xs-5""><label>Gender:</label></div>
                                    <div class=""col-xs-7"">");
            EndContext();
            BeginContext(4537, 31, false);
#line 83 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\DepartmentHead\EmployeeDetails.cshtml"
                                                     Write(Model.WorkPlace.Employee.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(4568, 335, true);
            WriteLiteral(@"</div>
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""row"">
                                    <div class=""col-xs-5""><label>Birthday:</label></div>
                                    <div class=""col-xs-7"">");
            EndContext();
            BeginContext(4904, 33, false);
#line 89 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\DepartmentHead\EmployeeDetails.cshtml"
                                                     Write(Model.WorkPlace.Employee.Birthday);

#line default
#line hidden
            EndContext();
            BeginContext(4937, 684, true);
            WriteLiteral(@"</div>
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""row"">
                                    <div class=""col-xs-5""><label>Phone:</label></div>
                                    <div class=""col-xs-7"">+994-55-837-56-78</div>
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""row"">
                                    <div class=""col-xs-5""><label>Position:</label></div>
                                    <div class=""col-xs-7"">");
            EndContext();
            BeginContext(5622, 29, false);
#line 101 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\DepartmentHead\EmployeeDetails.cshtml"
                                                     Write(Model.WorkPlace.Position.Name);

#line default
#line hidden
            EndContext();
            BeginContext(5651, 336, true);
            WriteLiteral(@"</div>
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""row"">
                                    <div class=""col-xs-5""><label>Department</label></div>
                                    <div class=""col-xs-7"">");
            EndContext();
            BeginContext(5988, 48, false);
#line 107 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\DepartmentHead\EmployeeDetails.cshtml"
                                                     Write(Model.WorkPlace.Position.Company.Department.Name);

#line default
#line hidden
            EndContext();
            BeginContext(6036, 334, true);
            WriteLiteral(@"</div>
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""row"">
                                    <div class=""col-xs-5""><label>Company:</label></div>
                                    <div class=""col-xs-7"">");
            EndContext();
            BeginContext(6371, 37, false);
#line 113 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\DepartmentHead\EmployeeDetails.cshtml"
                                                     Write(Model.WorkPlace.Position.Company.Name);

#line default
#line hidden
            EndContext();
            BeginContext(6408, 332, true);
            WriteLiteral(@"</div>
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""row"">
                                    <div class=""col-xs-5""><label>Salary</label></div>
                                    <div class=""col-xs-7"">");
            EndContext();
            BeginContext(6741, 31, false);
#line 119 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\DepartmentHead\EmployeeDetails.cshtml"
                                                     Write(Model.WorkPlace.Position.Salary);

#line default
#line hidden
            EndContext();
            BeginContext(6772, 672, true);
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
#line 137 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\DepartmentHead\EmployeeDetails.cshtml"
                         foreach (var item in Model.OldWorkPlaces)
                        {

#line default
#line hidden
            BeginContext(7539, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(7610, 9, false);
#line 140 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\DepartmentHead\EmployeeDetails.cshtml"
                               Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(7619, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(7663, 14, false);
#line 141 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\DepartmentHead\EmployeeDetails.cshtml"
                               Write(item.EntryDate);

#line default
#line hidden
            EndContext();
            BeginContext(7677, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(7721, 12, false);
#line 142 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\DepartmentHead\EmployeeDetails.cshtml"
                               Write(item.EndDate);

#line default
#line hidden
            EndContext();
            BeginContext(7733, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(7777, 14, false);
#line 143 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\DepartmentHead\EmployeeDetails.cshtml"
                               Write(item.EndReason);

#line default
#line hidden
            EndContext();
            BeginContext(7791, 42, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n");
            EndContext();
#line 145 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\DepartmentHead\EmployeeDetails.cshtml"
                        }

#line default
#line hidden
            BeginContext(7860, 116, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdminEmployeeModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
