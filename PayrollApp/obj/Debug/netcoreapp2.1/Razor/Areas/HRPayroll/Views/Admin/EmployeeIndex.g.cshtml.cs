#pragma checksum "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae6dc99307f6c9a39f596eab50238cf12352d506"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_HRPayroll_Views_Admin_EmployeeIndex), @"mvc.1.0.view", @"/Areas/HRPayroll/Views/Admin/EmployeeIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/HRPayroll/Views/Admin/EmployeeIndex.cshtml", typeof(AspNetCore.Areas_HRPayroll_Views_Admin_EmployeeIndex))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae6dc99307f6c9a39f596eab50238cf12352d506", @"/Areas/HRPayroll/Views/Admin/EmployeeIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e335acc40c4165e5fba0ad40156250e899745d0", @"/Areas/HRPayroll/Views/_ViewImports.cshtml")]
    public class Areas_HRPayroll_Views_Admin_EmployeeIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 64, true);
            WriteLiteral("<div class=\"main-menu\">\r\n    <header class=\"header\">\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 87, "\"", 126, 1);
#line 4 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeIndex.cshtml"
WriteAttributeValue("", 94, Url.Action("UserIndex","Admin"), 94, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(127, 302, true);
            WriteLiteral(@" class=""logo"">Payroll</a>
        <button type=""button"" class=""button-close fa fa-times js__menu_close""></button>
    </header>
    <div class=""content"">
        <div class=""navigation"">
            <ul class=""menu js__accordion"">
                <li>
                    <a class=""waves-effect""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 429, "\"", 468, 1);
#line 11 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeIndex.cshtml"
WriteAttributeValue("", 436, Url.Action("UserIndex","Admin"), 436, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(469, 166, true);
            WriteLiteral("><i class=\"menu-icon fas fa-users\"></i><span>User</span></a>\r\n                </li>\r\n                <li class=\"current\">\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 635, "\"", 678, 1);
#line 14 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeIndex.cshtml"
WriteAttributeValue("", 642, Url.Action("EmployeeIndex","Admin"), 642, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(679, 153, true);
            WriteLiteral("><i class=\"menu-icon far fa-user\"></i><span>Employee</span></a>\r\n                </li>\r\n                <li>\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 832, "\"", 871, 1);
#line 17 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeIndex.cshtml"
WriteAttributeValue("", 839, Url.Action("RoleIndex","Admin"), 839, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(872, 157, true);
            WriteLiteral("><i class=\"menu-icon fas fa-address-book\"></i><span>Role</span></a>\r\n                </li>\r\n                <li>\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1029, "\"", 1069, 1);
#line 20 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeIndex.cshtml"
WriteAttributeValue("", 1036, Url.Action("Department","Admin"), 1036, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1070, 164, true);
            WriteLiteral("><i class=\"menu-icon fas fa-briefcase\"></i></i><span>Department</span></a>\r\n                </li>\r\n                <li>\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1234, "\"", 1276, 1);
#line 23 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeIndex.cshtml"
WriteAttributeValue("", 1241, Url.Action("CompanyIndex","Admin"), 1241, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1277, 153, true);
            WriteLiteral("><i class=\"menu-icon fas fa-hotel\"></i><span>Company</span></a>\r\n                </li>\r\n                <li>\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1430, "\"", 1471, 1);
#line 26 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeIndex.cshtml"
WriteAttributeValue("", 1437, Url.Action("BranchIndex","Admin"), 1437, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1472, 158, true);
            WriteLiteral("><i class=\"menu-icon fas fa-code-branch\"></i><span>Branch</span></a>\r\n                </li>\r\n                <li>\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1630, "\"", 1673, 1);
#line 29 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeIndex.cshtml"
WriteAttributeValue("", 1637, Url.Action("PositionIndex","Admin"), 1637, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1674, 158, true);
            WriteLiteral("><i class=\"menu-icon fas fa-user-edit\"></i><span>Position</span></a>\r\n                </li>\r\n                <li>\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1832, "\"", 1869, 1);
#line 32 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeIndex.cshtml"
WriteAttributeValue("", 1839, Url.Action("Holiday","Admin"), 1839, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1870, 158, true);
            WriteLiteral("><i class=\"menu-icon fas fa-user-clock\"></i><span>Holiday</span></a>\r\n                </li>\r\n                <li>\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2028, "\"", 2074, 1);
#line 35 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeIndex.cshtml"
WriteAttributeValue("", 2035, Url.Action("StipulationIndex","Admin"), 2035, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2075, 944, true);
            WriteLiteral(@"><i class=""menu-icon fas fa-sort-amount-up-alt""></i><span>Stipulation</span></a>
                </li>
            </ul>
        </div>
    </div>
</div>

<div class=""fixed-navbar"">
    <div class=""pull-left"">
        <button type=""button"" class=""menu-mobile-button glyphicon glyphicon-menu-hamburger js__menu_mobile""></button>
        <h1 class=""page-title"">Employees</h1>
    </div>
    <div class=""pull-right"">
        <div class=""ico-item"">
            <a href=""#"" class=""ico-item fa fa-search js__toggle_open"" data-target=""#searchform-header""></a>
            <div id=""searchform-header"" class=""searchform js__toggle userSearchForm""><input type=""search"" placeholder=""Search..."" class=""input-search"" id=""userSearch""><button onclick=""employeeSearcher()"" class=""fa fa-search button-search"" type=""button""></button></div>
        </div>
        <div class=""ico-item""><label>Admin</label></div>
        <div class=""ico-item""><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3019, "\"", 3058, 1);
#line 53 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeIndex.cshtml"
WriteAttributeValue("", 3026, Url.Action("Signout","Account"), 3026, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3059, 721, true);
            WriteLiteral(@"><p style=""font-size:smaller"">Log Out  <i class=""fas fa-sign-out-alt""></i></p></a></div>
    </div>
</div>
<div id=""wrapper"">
    <div class=""main-content"">
        <div>
            <table id=""example"" class=""display nowrap"" style=""width:100%"">
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>Surname</th>
                        <th>Father Name</th>
                        <th>Birthday</th>
                        <th>Education</th>
                        <th>Marital Status</th>
                        <th>Gender</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 73 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeIndex.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(3853, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(3916, 9, false);
#line 76 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeIndex.cshtml"
                           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3925, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3965, 12, false);
#line 77 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeIndex.cshtml"
                           Write(item.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(3977, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(4017, 15, false);
#line 78 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeIndex.cshtml"
                           Write(item.Fathername);

#line default
#line hidden
            EndContext();
            BeginContext(4032, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(4072, 13, false);
#line 79 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeIndex.cshtml"
                           Write(item.Birthday);

#line default
#line hidden
            EndContext();
            BeginContext(4085, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(4125, 14, false);
#line 80 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeIndex.cshtml"
                           Write(item.Education);

#line default
#line hidden
            EndContext();
            BeginContext(4139, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(4179, 18, false);
#line 81 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeIndex.cshtml"
                           Write(item.MaritalStatus);

#line default
#line hidden
            EndContext();
            BeginContext(4197, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(4237, 11, false);
#line 82 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeIndex.cshtml"
                           Write(item.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(4248, 70, true);
            WriteLiteral("</td>\r\n                            <td><a style=\"display:inline-block\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4318, "\"", 4383, 1);
#line 83 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeIndex.cshtml"
WriteAttributeValue("", 4325, Url.Action("EmployeeDetails","Admin",new { id = item.Id}), 4325, 58, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4384, 70, true);
            WriteLiteral("><i class=\"far fa-edit\"></i></a></td>\r\n                        </tr>\r\n");
            EndContext();
#line 85 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\EmployeeIndex.cshtml"
                    }

#line default
#line hidden
            BeginContext(4477, 82, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
