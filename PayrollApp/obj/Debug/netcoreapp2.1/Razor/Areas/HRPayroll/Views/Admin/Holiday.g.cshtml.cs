#pragma checksum "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\Holiday.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be2e83473ebc9ae28e2f933831892124f1573892"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_HRPayroll_Views_Admin_Holiday), @"mvc.1.0.view", @"/Areas/HRPayroll/Views/Admin/Holiday.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/HRPayroll/Views/Admin/Holiday.cshtml", typeof(AspNetCore.Areas_HRPayroll_Views_Admin_Holiday))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be2e83473ebc9ae28e2f933831892124f1573892", @"/Areas/HRPayroll/Views/Admin/Holiday.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e335acc40c4165e5fba0ad40156250e899745d0", @"/Areas/HRPayroll/Views/_ViewImports.cshtml")]
    public class Areas_HRPayroll_Views_Admin_Holiday : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WorkPlace>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 64, true);
            WriteLiteral("<div class=\"main-menu\">\r\n    <header class=\"header\">\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 88, "\"", 127, 1);
#line 4 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\Holiday.cshtml"
WriteAttributeValue("", 95, Url.Action("UserIndex","Admin"), 95, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(128, 302, true);
            WriteLiteral(@" class=""logo"">Payroll</a>
        <button type=""button"" class=""button-close fa fa-times js__menu_close""></button>
    </header>
    <div class=""content"">
        <div class=""navigation"">
            <ul class=""menu js__accordion"">
                <li>
                    <a class=""waves-effect""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 430, "\"", 469, 1);
#line 11 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\Holiday.cshtml"
WriteAttributeValue("", 437, Url.Action("UserIndex","Admin"), 437, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(470, 150, true);
            WriteLiteral("><i class=\"menu-icon fas fa-users\"></i><span>User</span></a>\r\n                </li>\r\n                <li>\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 620, "\"", 663, 1);
#line 14 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\Holiday.cshtml"
WriteAttributeValue("", 627, Url.Action("EmployeeIndex","Admin"), 627, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(664, 153, true);
            WriteLiteral("><i class=\"menu-icon far fa-user\"></i><span>Employee</span></a>\r\n                </li>\r\n                <li>\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 817, "\"", 856, 1);
#line 17 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\Holiday.cshtml"
WriteAttributeValue("", 824, Url.Action("RoleIndex","Admin"), 824, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(857, 157, true);
            WriteLiteral("><i class=\"menu-icon fas fa-address-book\"></i><span>Role</span></a>\r\n                </li>\r\n                <li>\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1014, "\"", 1054, 1);
#line 20 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\Holiday.cshtml"
WriteAttributeValue("", 1021, Url.Action("Department","Admin"), 1021, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1055, 164, true);
            WriteLiteral("><i class=\"menu-icon fas fa-briefcase\"></i></i><span>Department</span></a>\r\n                </li>\r\n                <li>\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1219, "\"", 1261, 1);
#line 23 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\Holiday.cshtml"
WriteAttributeValue("", 1226, Url.Action("CompanyIndex","Admin"), 1226, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1262, 153, true);
            WriteLiteral("><i class=\"menu-icon fas fa-hotel\"></i><span>Company</span></a>\r\n                </li>\r\n                <li>\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1415, "\"", 1456, 1);
#line 26 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\Holiday.cshtml"
WriteAttributeValue("", 1422, Url.Action("BranchIndex","Admin"), 1422, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1457, 158, true);
            WriteLiteral("><i class=\"menu-icon fas fa-code-branch\"></i><span>Branch</span></a>\r\n                </li>\r\n                <li>\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1615, "\"", 1658, 1);
#line 29 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\Holiday.cshtml"
WriteAttributeValue("", 1622, Url.Action("PositionIndex","Admin"), 1622, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1659, 174, true);
            WriteLiteral("><i class=\"menu-icon fas fa-user-edit\"></i><span>Position</span></a>\r\n                </li>\r\n                <li class=\"current\">\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1833, "\"", 1870, 1);
#line 32 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\Holiday.cshtml"
WriteAttributeValue("", 1840, Url.Action("Holiday","Admin"), 1840, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1871, 158, true);
            WriteLiteral("><i class=\"menu-icon fas fa-user-clock\"></i><span>Holiday</span></a>\r\n                </li>\r\n                <li>\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2029, "\"", 2075, 1);
#line 35 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\Holiday.cshtml"
WriteAttributeValue("", 2036, Url.Action("StipulationIndex","Admin"), 2036, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2076, 942, true);
            WriteLiteral(@"><i class=""menu-icon fas fa-sort-amount-up-alt""></i><span>Stipulation</span></a>
                </li>
            </ul>
        </div>
    </div>
</div>

<div class=""fixed-navbar"">
    <div class=""pull-left"">
        <button type=""button"" class=""menu-mobile-button glyphicon glyphicon-menu-hamburger js__menu_mobile""></button>
        <h1 class=""page-title"">Holiday</h1>
    </div>
    <div class=""pull-right"">
        <div class=""ico-item"">
            <a href=""#"" class=""ico-item fa fa-search js__toggle_open"" data-target=""#searchform-header""></a>
            <div id=""searchform-header"" class=""searchform js__toggle userSearchForm""><input type=""search"" placeholder=""Search..."" class=""input-search"" id=""userSearch""><button onclick=""employeeSearcher()"" class=""fa fa-search button-search"" type=""button""></button></div>
        </div>
        <div class=""ico-item""><label>Admin</label></div>
        <div class=""ico-item""><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3018, "\"", 3057, 1);
#line 53 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\Holiday.cshtml"
WriteAttributeValue("", 3025, Url.Action("Signout","Account"), 3025, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3058, 721, true);
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
#line 73 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\Holiday.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(3852, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(3915, 18, false);
#line 76 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\Holiday.cshtml"
                           Write(item.Employee.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3933, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3973, 21, false);
#line 77 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\Holiday.cshtml"
                           Write(item.Employee.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(3994, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(4034, 24, false);
#line 78 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\Holiday.cshtml"
                           Write(item.Employee.Fathername);

#line default
#line hidden
            EndContext();
            BeginContext(4058, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(4098, 22, false);
#line 79 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\Holiday.cshtml"
                           Write(item.Employee.Birthday);

#line default
#line hidden
            EndContext();
            BeginContext(4120, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(4160, 23, false);
#line 80 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\Holiday.cshtml"
                           Write(item.Employee.Education);

#line default
#line hidden
            EndContext();
            BeginContext(4183, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(4223, 27, false);
#line 81 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\Holiday.cshtml"
                           Write(item.Employee.MaritalStatus);

#line default
#line hidden
            EndContext();
            BeginContext(4250, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(4290, 20, false);
#line 82 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\Holiday.cshtml"
                           Write(item.Employee.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(4310, 70, true);
            WriteLiteral("</td>\r\n                            <td><a style=\"display:inline-block\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4380, "\"", 4449, 1);
#line 83 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\Holiday.cshtml"
WriteAttributeValue("", 4387, Url.Action("HolidayAdd","Admin",new { id = item.Employee.Id}), 4387, 62, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4450, 70, true);
            WriteLiteral("><i class=\"fas fa-plus\"></i></a></td>\r\n                        </tr>\r\n");
            EndContext();
#line 85 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\Holiday.cshtml"
                    }

#line default
#line hidden
            BeginContext(4543, 82, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WorkPlace>> Html { get; private set; }
    }
}
#pragma warning restore 1591
