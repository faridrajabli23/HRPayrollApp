#pragma checksum "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3642c9ea1a838a822d45d1f1d5280547bbe4a2c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_HRPayroll_Views_Employee_Index), @"mvc.1.0.view", @"/Areas/HRPayroll/Views/Employee/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/HRPayroll/Views/Employee/Index.cshtml", typeof(AspNetCore.Areas_HRPayroll_Views_Employee_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3642c9ea1a838a822d45d1f1d5280547bbe4a2c", @"/Areas/HRPayroll/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e335acc40c4165e5fba0ad40156250e899745d0", @"/Areas/HRPayroll/Views/_ViewImports.cshtml")]
    public class Areas_HRPayroll_Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PayrollApp.Areas.HRPayroll.Models.Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 72, true);
            WriteLiteral("\r\n    \r\n<div class=\"main-menu\">\r\n    <header class=\"header\">\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 129, "\"", 167, 1);
#line 6 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Employee\Index.cshtml"
WriteAttributeValue("", 136, Url.Action("Index","Employee"), 136, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(168, 318, true);
            WriteLiteral(@" class=""logo"">Payroll</a>
        <button type=""button"" class=""button-close fa fa-times js__menu_close""></button>
    </header>
    <div class=""content"">
        <div class=""navigation"">
            <ul class=""menu js__accordion"">
                <li class=""current"">
                    <a class=""waves-effect""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 486, "\"", 524, 1);
#line 13 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Employee\Index.cshtml"
WriteAttributeValue("", 493, Url.Action("Index","Employee"), 493, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(525, 154, true);
            WriteLiteral("><i class=\"menu-icon fas fa-users\"></i><span>Employee</span></a>\r\n                </li>\r\n                <li>\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 679, "\"", 726, 1);
#line 16 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Employee\Index.cshtml"
WriteAttributeValue("", 686, Url.Action("WorkPlaceIndex","Employee"), 686, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(727, 156, true);
            WriteLiteral("><i class=\"menu-icon fas fa-list\"></i><span>Work Places</span></a>\r\n                </li>\r\n                <li>\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 883, "\"", 928, 1);
#line 19 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Employee\Index.cshtml"
WriteAttributeValue("", 890, Url.Action("OldWorkIndex","Employee"), 890, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(929, 168, true);
            WriteLiteral("><i class=\"menu-icon fas fa-address-card\"></i><span>Old Work Places</span></a>\r\n                </li>\r\n                <li>\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1097, "\"", 1141, 1);
#line 22 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Employee\Index.cshtml"
WriteAttributeValue("", 1104, Url.Action("AbsentTable","Employee"), 1104, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1142, 928, true);
            WriteLiteral(@"><i class=""menu-icon fas fa-clipboard""></i><span>Absent table</span></a>
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
            <div id=""searchform-header"" class=""searchform js__toggle employeeSearchForm""><input type=""search"" placeholder=""Search..."" class=""input-search"" id=""employeeSearch""><button onclick=""asd()"" class=""fa fa-search button-search"" type=""button""></button></div>
        </div>
        <div class=""ico-item""><label>HR</label></div>
        <div class=""ico-item""><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2070, "\"", 2109, 1);
#line 40 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Employee\Index.cshtml"
WriteAttributeValue("", 2077, Url.Action("Signout","Account"), 2077, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2110, 981, true);
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
                        <th>Address</th>
                        <th>Register Address</th>
                        <th>Passport Id</th>
                        <th>PassportExp Date</th>
                        <th>Education</th>
                        <th>Marital Status</th>
                        <th>Gender</th>
                        <th></th>
                        <th></th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 66 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Employee\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(3164, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(3227, 9, false);
#line 69 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Employee\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3236, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3276, 12, false);
#line 70 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Employee\Index.cshtml"
                           Write(item.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(3288, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3328, 15, false);
#line 71 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Employee\Index.cshtml"
                           Write(item.Fathername);

#line default
#line hidden
            EndContext();
            BeginContext(3343, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3383, 13, false);
#line 72 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Employee\Index.cshtml"
                           Write(item.Birthday);

#line default
#line hidden
            EndContext();
            BeginContext(3396, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3436, 12, false);
#line 73 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Employee\Index.cshtml"
                           Write(item.Address);

#line default
#line hidden
            EndContext();
            BeginContext(3448, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3488, 20, false);
#line 74 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Employee\Index.cshtml"
                           Write(item.RegisterAddress);

#line default
#line hidden
            EndContext();
            BeginContext(3508, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3548, 15, false);
#line 75 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Employee\Index.cshtml"
                           Write(item.PassportId);

#line default
#line hidden
            EndContext();
            BeginContext(3563, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3603, 20, false);
#line 76 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Employee\Index.cshtml"
                           Write(item.PassportExpDate);

#line default
#line hidden
            EndContext();
            BeginContext(3623, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3663, 14, false);
#line 77 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Employee\Index.cshtml"
                           Write(item.Education);

#line default
#line hidden
            EndContext();
            BeginContext(3677, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3717, 18, false);
#line 78 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Employee\Index.cshtml"
                           Write(item.MaritalStatus);

#line default
#line hidden
            EndContext();
            BeginContext(3735, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3775, 11, false);
#line 79 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Employee\Index.cshtml"
                           Write(item.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(3786, 70, true);
            WriteLiteral("</td>\r\n                            <td><a style=\"display:inline-block\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3856, "\"", 3913, 1);
#line 80 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Employee\Index.cshtml"
WriteAttributeValue("", 3863, Url.Action("Edit","Employee",new { id = item.Id}), 3863, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3914, 102, true);
            WriteLiteral("><i class=\"far fa-edit\"></i></a></td>\r\n                            <td><a style=\"display:inline-block\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4016, "\"", 4075, 1);
#line 81 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Employee\Index.cshtml"
WriteAttributeValue("", 4023, Url.Action("Delete","Employee",new { id = item.Id}), 4023, 52, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4076, 107, true);
            WriteLiteral("><i class=\"far fa-trash-alt\"></i></a></td>\r\n                            <td><a style=\"display:inline-block\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4183, "\"", 4243, 1);
#line 82 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Employee\Index.cshtml"
WriteAttributeValue("", 4190, Url.Action("Details","Employee",new { id = item.Id}), 4190, 53, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4244, 70, true);
            WriteLiteral("><i class=\"fas fa-info\"></i></a></td>\r\n                        </tr>\r\n");
            EndContext();
#line 84 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Employee\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(4337, 83, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n            <a class=\"btn btn-info\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4420, "\"", 4456, 1);
#line 87 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Employee\Index.cshtml"
WriteAttributeValue("", 4427, Url.Action("Add","Employee"), 4427, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4457, 58, true);
            WriteLiteral(">Add</a>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PayrollApp.Areas.HRPayroll.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
