#pragma checksum "C:\Users\Tipu\Desktop\ASP_DOTNET_CORE_MVC\Ecommerce\Ecommerce\Areas\Admin\Views\Role\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ede9da19ce669b66cdadc526c479d89f2875105"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Role_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/Role/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Role/Delete.cshtml", typeof(AspNetCore.Areas_Admin_Views_Role_Delete))]
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
#line 1 "C:\Users\Tipu\Desktop\ASP_DOTNET_CORE_MVC\Ecommerce\Ecommerce\Areas\Admin\Views\_ViewImports.cshtml"
using Ecommerce;

#line default
#line hidden
#line 2 "C:\Users\Tipu\Desktop\ASP_DOTNET_CORE_MVC\Ecommerce\Ecommerce\Areas\Admin\Views\_ViewImports.cshtml"
using Ecommerce.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ede9da19ce669b66cdadc526c479d89f2875105", @"/Areas/Admin/Views/Role/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bbcd7c65731fc074a835809e73fcf2cf9014c29", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Role_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("role-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Tipu\Desktop\ASP_DOTNET_CORE_MVC\Ecommerce\Ecommerce\Areas\Admin\Views\Role\Delete.cshtml"
  
    ViewData["Title"] = "Delete Role";

#line default
#line hidden
            BeginContext(49, 70, true);
            WriteLiteral("<br />\r\n<h1 class=\"text-info text-center\">Delete Role</h1>\r\n<br />\r\n\r\n");
            EndContext();
            BeginContext(119, 1076, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ede9da19ce669b66cdadc526c479d89f28751055926", async() => {
                BeginContext(204, 135, true);
                WriteLiteral("\r\n\r\n    <div class=\"form-group row\">\r\n        <div class=\"col-2\"> </div>\r\n        <div class=\"col-8\">\r\n            <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 339, "\"", 358, 1);
#line 14 "C:\Users\Tipu\Desktop\ASP_DOTNET_CORE_MVC\Ecommerce\Ecommerce\Areas\Admin\Views\Role\Delete.cshtml"
WriteAttributeValue("", 347, ViewBag.Id, 347, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(359, 240, true);
                WriteLiteral(" name=\"id\" />\r\n        </div>\r\n    </div>\r\n\r\n\r\n    <div class=\"form-group row\">\r\n        <div class=\"col-2\">\r\n            <b><label class=\"control-label\">Role Name</label></b>\r\n        </div>\r\n        <div class=\"col-8\">\r\n            <input");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 599, "\"", 620, 1);
#line 24 "C:\Users\Tipu\Desktop\ASP_DOTNET_CORE_MVC\Ecommerce\Ecommerce\Areas\Admin\Views\Role\Delete.cshtml"
WriteAttributeValue("", 607, ViewBag.Name, 607, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(621, 276, true);
                WriteLiteral(@" name=""name"" id=""name"" class=""form-control"" readonly=""readonly"" />
        </div>
    </div>


    <div class=""form-group  row"">
        <div class=""col-2"">
        </div>
        <div class=""col-8"">
            <h3 style=""color:red;"">Are you sure you want to delete ");
                EndContext();
                BeginContext(898, 12, false);
#line 33 "C:\Users\Tipu\Desktop\ASP_DOTNET_CORE_MVC\Ecommerce\Ecommerce\Areas\Admin\Views\Role\Delete.cshtml"
                                                              Write(ViewBag.Name);

#line default
#line hidden
                EndContext();
                BeginContext(910, 106, true);
                WriteLiteral("?</h3>\r\n            <br />\r\n            <input type=\"submit\" value=\"Delete\" class=\"btn btn-outline-danger\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1016, "\"", 1081, 8);
                WriteAttributeValue("", 1026, "return", 1026, 6, true);
                WriteAttributeValue(" ", 1032, "confirm(\'Do", 1033, 12, true);
                WriteAttributeValue(" ", 1044, "you", 1045, 4, true);
                WriteAttributeValue(" ", 1048, "want", 1049, 5, true);
                WriteAttributeValue(" ", 1053, "to", 1054, 3, true);
                WriteAttributeValue(" ", 1056, "delete", 1057, 7, true);
#line 35 "C:\Users\Tipu\Desktop\ASP_DOTNET_CORE_MVC\Ecommerce\Ecommerce\Areas\Admin\Views\Role\Delete.cshtml"
WriteAttributeValue(" ", 1063, ViewBag.Name, 1064, 13, false);

#line default
#line hidden
                WriteAttributeValue("", 1077, "?\');", 1077, 4, true);
                EndWriteAttribute();
                BeginContext(1082, 17, true);
                WriteLiteral(" />\r\n            ");
                EndContext();
                BeginContext(1099, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ede9da19ce669b66cdadc526c479d89f28751059393", async() => {
                    BeginContext(1150, 4, true);
                    WriteLiteral("Back");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1158, 30, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1195, 14, true);
            WriteLiteral("\r\n\r\n<br />\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1227, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 44 "C:\Users\Tipu\Desktop\ASP_DOTNET_CORE_MVC\Ecommerce\Ecommerce\Areas\Admin\Views\Role\Delete.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
                BeginContext(1297, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
