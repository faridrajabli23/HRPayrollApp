#pragma checksum "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\CompanyEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8afa2b7c48391d5476d71e41d4424386d32b63ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_HRPayroll_Views_Admin_CompanyEdit), @"mvc.1.0.view", @"/Areas/HRPayroll/Views/Admin/CompanyEdit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/HRPayroll/Views/Admin/CompanyEdit.cshtml", typeof(AspNetCore.Areas_HRPayroll_Views_Admin_CompanyEdit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8afa2b7c48391d5476d71e41d4424386d32b63ca", @"/Areas/HRPayroll/Views/Admin/CompanyEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e335acc40c4165e5fba0ad40156250e899745d0", @"/Areas/HRPayroll/Views/_ViewImports.cshtml")]
    public class Areas_HRPayroll_Views_Admin_CompanyEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CompanyEditViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("department"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size:small"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("visibility:hidden"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-lg-6 col-xs-12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 66, true);
            WriteLiteral("\r\n<div class=\"main-menu\">\r\n    <header class=\"header\">\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 95, "\"", 134, 1);
#line 5 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\CompanyEdit.cshtml"
WriteAttributeValue("", 102, Url.Action("UserIndex","Admin"), 102, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(135, 302, true);
            WriteLiteral(@" class=""logo"">Payroll</a>
        <button type=""button"" class=""button-close fa fa-times js__menu_close""></button>
    </header>
    <div class=""content"">
        <div class=""navigation"">
            <ul class=""menu js__accordion"">
                <li>
                    <a class=""waves-effect""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 437, "\"", 476, 1);
#line 12 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\CompanyEdit.cshtml"
WriteAttributeValue("", 444, Url.Action("UserIndex","Admin"), 444, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(477, 150, true);
            WriteLiteral("><i class=\"menu-icon fas fa-users\"></i><span>User</span></a>\r\n                </li>\r\n                <li>\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 627, "\"", 670, 1);
#line 15 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\CompanyEdit.cshtml"
WriteAttributeValue("", 634, Url.Action("EmployeeIndex","Admin"), 634, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(671, 153, true);
            WriteLiteral("><i class=\"menu-icon far fa-user\"></i><span>Employee</span></a>\r\n                </li>\r\n                <li>\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 824, "\"", 863, 1);
#line 18 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\CompanyEdit.cshtml"
WriteAttributeValue("", 831, Url.Action("RoleIndex","Admin"), 831, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(864, 157, true);
            WriteLiteral("><i class=\"menu-icon fas fa-address-book\"></i><span>Role</span></a>\r\n                </li>\r\n                <li>\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1021, "\"", 1061, 1);
#line 21 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\CompanyEdit.cshtml"
WriteAttributeValue("", 1028, Url.Action("Department","Admin"), 1028, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1062, 180, true);
            WriteLiteral("><i class=\"menu-icon fas fa-briefcase\"></i></i><span>Department</span></a>\r\n                </li>\r\n                <li class=\"current\">\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1242, "\"", 1284, 1);
#line 24 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\CompanyEdit.cshtml"
WriteAttributeValue("", 1249, Url.Action("CompanyIndex","Admin"), 1249, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1285, 153, true);
            WriteLiteral("><i class=\"menu-icon fas fa-hotel\"></i><span>Company</span></a>\r\n                </li>\r\n                <li>\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1438, "\"", 1479, 1);
#line 27 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\CompanyEdit.cshtml"
WriteAttributeValue("", 1445, Url.Action("BranchIndex","Admin"), 1445, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1480, 158, true);
            WriteLiteral("><i class=\"menu-icon fas fa-code-branch\"></i><span>Branch</span></a>\r\n                </li>\r\n                <li>\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1638, "\"", 1681, 1);
#line 30 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\CompanyEdit.cshtml"
WriteAttributeValue("", 1645, Url.Action("PositionIndex","Admin"), 1645, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1682, 158, true);
            WriteLiteral("><i class=\"menu-icon fas fa-user-edit\"></i><span>Position</span></a>\r\n                </li>\r\n                <li>\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1840, "\"", 1877, 1);
#line 33 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\CompanyEdit.cshtml"
WriteAttributeValue("", 1847, Url.Action("Holiday","Admin"), 1847, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1878, 158, true);
            WriteLiteral("><i class=\"menu-icon fas fa-user-clock\"></i><span>Holiday</span></a>\r\n                </li>\r\n                <li>\r\n                    <a class=\"waves-effect\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2036, "\"", 2082, 1);
#line 36 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\CompanyEdit.cshtml"
WriteAttributeValue("", 2043, Url.Action("StipulationIndex","Admin"), 2043, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2083, 947, true);
            WriteLiteral(@"><i class=""menu-icon fas fa-sort-amount-up-alt""></i><span>Stipulation</span></a>
                </li>
            </ul>
        </div>
    </div>
</div>

<div class=""fixed-navbar"">
    <div class=""pull-left"">
        <button type=""button"" class=""menu-mobile-button glyphicon glyphicon-menu-hamburger js__menu_mobile""></button>
        <h1 class=""page-title"">Company Edit</h1>
    </div>
    <div class=""pull-right"">
        <div class=""ico-item"">
            <a href=""#"" class=""ico-item fa fa-search js__toggle_open"" data-target=""#searchform-header""></a>
            <div id=""searchform-header"" class=""searchform js__toggle userSearchForm""><input type=""search"" placeholder=""Search..."" class=""input-search"" id=""userSearch""><button onclick=""employeeSearcher()"" class=""fa fa-search button-search"" type=""button""></button></div>
        </div>
        <div class=""ico-item""><label>Admin</label></div>
        <div class=""ico-item""><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3030, "\"", 3069, 1);
#line 54 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\CompanyEdit.cshtml"
WriteAttributeValue("", 3037, Url.Action("Signout","Account"), 3037, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3070, 201, true);
            WriteLiteral("><p style=\"font-size:smaller\">Log Out  <i class=\"fas fa-sign-out-alt\"></i></p></a></div>\r\n    </div>\r\n</div>\r\n<div id=\"wrapper\">\r\n    <div class=\"main-content\">\r\n        <div class=\"row\">\r\n            ");
            EndContext();
            BeginContext(3271, 1263, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83337916e0334a849142344ab1008242", async() => {
                BeginContext(3348, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(3366, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6f65a6d8d2c4afaa9fc037f57085ebf", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 61 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\CompanyEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3412, 64, true);
                WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    ");
                EndContext();
                BeginContext(3476, 74, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e1ddd2aa4b14e8e8b19f21c561f2843", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 63 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\CompanyEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.DepartmentId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3550, 69, true);
                WriteLiteral("\r\n                    <label>Department</label>\r\n                    ");
                EndContext();
                BeginContext(3619, 318, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3bf49d715dd948468a600fa23fcbc869", async() => {
                    BeginContext(3694, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 66 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\CompanyEdit.cshtml"
                         foreach (var department in Model.Departments)
                        {

#line default
#line hidden
                    BeginContext(3795, 28, true);
                    WriteLiteral("                            ");
                    EndContext();
                    BeginContext(3823, 56, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f644f53b44f74064b82bed5f529730a1", async() => {
                        BeginContext(3855, 15, false);
#line 68 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\CompanyEdit.cshtml"
                                                      Write(department.Name);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#line 68 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\CompanyEdit.cshtml"
                               WriteLiteral(department.Id);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(3879, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 69 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\CompanyEdit.cshtml"
                        }

#line default
#line hidden
                    BeginContext(3908, 20, true);
                    WriteLiteral("                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#line 65 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\CompanyEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.DepartmentId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3937, 129, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Name</label>\r\n                    ");
                EndContext();
                BeginContext(4066, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8b7f790afecd4b428d51a9d7c62a3a4a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 74 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\CompanyEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4123, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(4145, 83, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4670f91c22b4b70b2dcfbfec6196e30", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 75 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\CompanyEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4228, 42, true);
                WriteLiteral("\r\n                </div>\r\n                ");
                EndContext();
                BeginContext(4270, 99, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "eda5082f68e9460d9525d031f205e2ea", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 77 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\CompanyEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
#line 77 "C:\Users\FARID\source\repos\LastTask\PayrollApp\Areas\HRPayroll\Views\Admin\CompanyEdit.cshtml"
                                                    WriteLiteral(Model.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4369, 158, true);
                WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    <button class=\"btn btn-info\" type=\"submit\">Edit</button>\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4534, 36, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CompanyEditViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
