#pragma checksum "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\UserIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97ecaa3a777ccd7d190339d1057ec0efe1b83271"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_HRPayroll_Views_Admin_UserIndex), @"mvc.1.0.view", @"/Areas/HRPayroll/Views/Admin/UserIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/HRPayroll/Views/Admin/UserIndex.cshtml", typeof(AspNetCore.Areas_HRPayroll_Views_Admin_UserIndex))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97ecaa3a777ccd7d190339d1057ec0efe1b83271", @"/Areas/HRPayroll/Views/Admin/UserIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e335acc40c4165e5fba0ad40156250e899745d0", @"/Areas/HRPayroll/Views/_ViewImports.cshtml")]
    public class Areas_HRPayroll_Views_Admin_UserIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 68, true);
            WriteLiteral("\r\n\r\n<div class=\"main-menu\">\r\n    <header class=\"header\">\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 90, "\"", 129, 1);
#line 6 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\UserIndex.cshtml"
WriteAttributeValue("", 97, Url.Action("UserIndex","Admin"), 97, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(130, 318, true);
            WriteLiteral(@" class=""logo"">Payroll</a>
        <button type=""button"" class=""button-close fa fa-times js__menu_close""></button>
    </header>
    <div class=""content"">
        <div class=""navigation"">
            <ul class=""menu js__accordion"">
                <li class=""current"">
                    <a class=""waves-effect""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 448, "\"", 487, 1);
#line 13 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\UserIndex.cshtml"
WriteAttributeValue("", 455, Url.Action("UserIndex","Admin"), 455, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(488, 150, true);
            WriteLiteral("><i class=\"menu-icon fas fa-users\"></i><span>User</span></a>\r\n                </li>\r\n                <li>\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 638, "\"", 681, 1);
#line 16 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\UserIndex.cshtml"
WriteAttributeValue("", 645, Url.Action("EmployeeIndex","Admin"), 645, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(682, 153, true);
            WriteLiteral("><i class=\"menu-icon far fa-user\"></i><span>Employee</span></a>\r\n                </li>\r\n                <li>\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 835, "\"", 874, 1);
#line 19 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\UserIndex.cshtml"
WriteAttributeValue("", 842, Url.Action("RoleIndex","Admin"), 842, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(875, 157, true);
            WriteLiteral("><i class=\"menu-icon fas fa-address-book\"></i><span>Role</span></a>\r\n                </li>\r\n                <li>\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1032, "\"", 1072, 1);
#line 22 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\UserIndex.cshtml"
WriteAttributeValue("", 1039, Url.Action("Department","Admin"), 1039, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1073, 164, true);
            WriteLiteral("><i class=\"menu-icon fas fa-briefcase\"></i></i><span>Department</span></a>\r\n                </li>\r\n                <li>\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1237, "\"", 1279, 1);
#line 25 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\UserIndex.cshtml"
WriteAttributeValue("", 1244, Url.Action("CompanyIndex","Admin"), 1244, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1280, 153, true);
            WriteLiteral("><i class=\"menu-icon fas fa-hotel\"></i><span>Company</span></a>\r\n                </li>\r\n                <li>\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1433, "\"", 1474, 1);
#line 28 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\UserIndex.cshtml"
WriteAttributeValue("", 1440, Url.Action("BranchIndex","Admin"), 1440, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1475, 158, true);
            WriteLiteral("><i class=\"menu-icon fas fa-code-branch\"></i><span>Branch</span></a>\r\n                </li>\r\n                <li>\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1633, "\"", 1676, 1);
#line 31 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\UserIndex.cshtml"
WriteAttributeValue("", 1640, Url.Action("PositionIndex","Admin"), 1640, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1677, 158, true);
            WriteLiteral("><i class=\"menu-icon fas fa-user-edit\"></i><span>Position</span></a>\r\n                </li>\r\n                <li>\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1835, "\"", 1872, 1);
#line 34 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\UserIndex.cshtml"
WriteAttributeValue("", 1842, Url.Action("Holiday","Admin"), 1842, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1873, 158, true);
            WriteLiteral("><i class=\"menu-icon fas fa-user-clock\"></i><span>Holiday</span></a>\r\n                </li>\r\n                <li>\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2031, "\"", 2077, 1);
#line 37 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\UserIndex.cshtml"
WriteAttributeValue("", 2038, Url.Action("StipulationIndex","Admin"), 2038, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2078, 940, true);
            WriteLiteral(@"><i class=""menu-icon fas fa-sort-amount-up-alt""></i><span>Stipulation</span></a>
                </li>
            </ul>
        </div>
    </div>
</div>

<div class=""fixed-navbar"">
    <div class=""pull-left"">
        <button type=""button"" class=""menu-mobile-button glyphicon glyphicon-menu-hamburger js__menu_mobile""></button>
        <h1 class=""page-title"">Users</h1>
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
#line 55 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\UserIndex.cshtml"
WriteAttributeValue("", 3025, Url.Action("Signout","Account"), 3025, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3058, 663, true);
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
                        <th>Username</th>
                        <th>Email</th>
                        <th>Phone Number</th>
                        <th></th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 74 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\UserIndex.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(3794, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(3849, 9, false);
#line 77 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\UserIndex.cshtml"
                       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3858, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(3894, 12, false);
#line 78 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\UserIndex.cshtml"
                       Write(item.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(3906, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(3942, 13, false);
#line 79 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\UserIndex.cshtml"
                       Write(item.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(3955, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(3991, 10, false);
#line 80 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\UserIndex.cshtml"
                       Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(4001, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(4037, 16, false);
#line 81 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\UserIndex.cshtml"
                       Write(item.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(4053, 37, true);
            WriteLiteral("</td>\r\n                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4090, "\"", 4149, 1);
#line 82 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\UserIndex.cshtml"
WriteAttributeValue("", 4097, Url.Action("UserEdit","Admin",new { id = item.Id }), 4097, 52, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4150, 69, true);
            WriteLiteral("><i class=\"far fa-edit\"></i></a></td>\r\n                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4219, "\"", 4280, 1);
#line 83 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\UserIndex.cshtml"
WriteAttributeValue("", 4226, Url.Action("UserDelete","Admin",new { id = item.Id }), 4226, 54, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4281, 71, true);
            WriteLiteral("><i class=\"far fa-trash-alt\"></i></a></td>\r\n                    </tr>\r\n");
            EndContext();
#line 85 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\UserIndex.cshtml"
                    }

#line default
#line hidden
            BeginContext(4375, 83, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n            <a class=\"btn btn-info\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4458, "\"", 4500, 1);
#line 88 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\UserIndex.cshtml"
WriteAttributeValue("", 4465, Url.Action("RegisterUser","Admin"), 4465, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4501, 62, true);
            WriteLiteral(">Sign up</a>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
