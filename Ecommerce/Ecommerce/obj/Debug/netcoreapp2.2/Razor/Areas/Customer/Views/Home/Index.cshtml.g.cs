#pragma checksum "C:\Users\Tipu\Desktop\ASP_DOTNET_CORE_MVC\Ecommerce\Ecommerce\Areas\Customer\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d2855b8d2be3cfff52efe89c8d72d7780557ebe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Customer/Views/Home/Index.cshtml", typeof(AspNetCore.Areas_Customer_Views_Home_Index))]
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
#line 1 "C:\Users\Tipu\Desktop\ASP_DOTNET_CORE_MVC\Ecommerce\Ecommerce\Areas\Customer\Views\_ViewImports.cshtml"
using Ecommerce;

#line default
#line hidden
#line 1 "C:\Users\Tipu\Desktop\ASP_DOTNET_CORE_MVC\Ecommerce\Ecommerce\Areas\Customer\Views\Home\Index.cshtml"
using Ecommerce.Models;

#line default
#line hidden
#line 2 "C:\Users\Tipu\Desktop\ASP_DOTNET_CORE_MVC\Ecommerce\Ecommerce\Areas\Customer\Views\Home\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 3 "C:\Users\Tipu\Desktop\ASP_DOTNET_CORE_MVC\Ecommerce\Ecommerce\Areas\Customer\Views\Home\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#line 68 "C:\Users\Tipu\Desktop\ASP_DOTNET_CORE_MVC\Ecommerce\Ecommerce\Areas\Customer\Views\Home\Index.cshtml"
using X.PagedList.Web.Common;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d2855b8d2be3cfff52efe89c8d72d7780557ebe", @"/Areas/Customer/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bbcd7c65731fc074a835809e73fcf2cf9014c29", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Products>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(77, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(108, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\Tipu\Desktop\ASP_DOTNET_CORE_MVC\Ecommerce\Ecommerce\Areas\Customer\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(155, 16, true);
            WriteLiteral("<br />\r\n<br />\r\n");
            EndContext();
            BeginContext(171, 270, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d2855b8d2be3cfff52efe89c8d72d7780557ebe6536", async() => {
                BeginContext(221, 213, true);
                WriteLiteral("\r\n    <div class=\"text-right\">\r\n        <input type=\"text\" name=\"searchBy\" placeholder=\"Search Product\" class=\"form-group\" />\r\n        <input type=\"submit\" value=\"Search\" class=\"btn btn-secondary\" />\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
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
            BeginContext(441, 23, true);
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n");
            EndContext();
#line 20 "C:\Users\Tipu\Desktop\ASP_DOTNET_CORE_MVC\Ecommerce\Ecommerce\Areas\Customer\Views\Home\Index.cshtml"
     foreach (var product in Model)
    {
        if (product.IsAvailabe)
        {

#line default
#line hidden
            BeginContext(552, 258, true);
            WriteLiteral(@"            <div class=""col-4"">
                <div class=""card-body mb-4"">
                    <div class=""card-header"">
                        <h4 style=""text-align:center;"">
                            <b><label style=""font-size:20px; color: blue;"">");
            EndContext();
            BeginContext(811, 12, false);
#line 28 "C:\Users\Tipu\Desktop\ASP_DOTNET_CORE_MVC\Ecommerce\Ecommerce\Areas\Customer\Views\Home\Index.cshtml"
                                                                      Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(823, 97, true);
            WriteLiteral("</label></b>\r\n                        </h4>\r\n                    </div>\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 920, "\"", 940, 1);
#line 31 "C:\Users\Tipu\Desktop\ASP_DOTNET_CORE_MVC\Ecommerce\Ecommerce\Areas\Customer\Views\Home\Index.cshtml"
WriteAttributeValue("", 926, product.Image, 926, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(941, 254, true);
            WriteLiteral(" alt=\"Card Image\" class=\"card-img-top\" style=\"height:200px;\" />\r\n                    <div class=\"card-header\">\r\n                        <div style=\"text-align:center;\">\r\n                            <label style=\"font-size:20px; color: brown;\"><b>Price : ");
            EndContext();
            BeginContext(1196, 13, false);
#line 34 "C:\Users\Tipu\Desktop\ASP_DOTNET_CORE_MVC\Ecommerce\Ecommerce\Areas\Customer\Views\Home\Index.cshtml"
                                                                               Write(product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1209, 131, true);
            WriteLiteral("</b></label>\r\n                        </div>\r\n                        <div style=\"text-align:center\">\r\n                            ");
            EndContext();
            BeginContext(1340, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d2855b8d2be3cfff52efe89c8d72d7780557ebe10884", async() => {
                BeginContext(1425, 11, true);
                WriteLiteral("Add to Cart");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 37 "C:\Users\Tipu\Desktop\ASP_DOTNET_CORE_MVC\Ecommerce\Ecommerce\Areas\Customer\Views\Home\Index.cshtml"
                                                        WriteLiteral(product.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1440, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1470, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d2855b8d2be3cfff52efe89c8d72d7780557ebe13372", async() => {
                BeginContext(1550, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 38 "C:\Users\Tipu\Desktop\ASP_DOTNET_CORE_MVC\Ecommerce\Ecommerce\Areas\Customer\Views\Home\Index.cshtml"
                                                      WriteLiteral(product.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1561, 106, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 43 "C:\Users\Tipu\Desktop\ASP_DOTNET_CORE_MVC\Ecommerce\Ecommerce\Areas\Customer\Views\Home\Index.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(1703, 258, true);
            WriteLiteral(@"            <div class=""col-4"">
                <div class=""card-body mb-4"">
                    <div class=""card-header"">
                        <h4 style=""text-align:center;"">
                            <b><label style=""font-size:20px; color: blue;"">");
            EndContext();
            BeginContext(1962, 12, false);
#line 50 "C:\Users\Tipu\Desktop\ASP_DOTNET_CORE_MVC\Ecommerce\Ecommerce\Areas\Customer\Views\Home\Index.cshtml"
                                                                      Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1974, 97, true);
            WriteLiteral("</label></b>\r\n                        </h4>\r\n                    </div>\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2071, "\"", 2091, 1);
#line 53 "C:\Users\Tipu\Desktop\ASP_DOTNET_CORE_MVC\Ecommerce\Ecommerce\Areas\Customer\Views\Home\Index.cshtml"
WriteAttributeValue("", 2077, product.Image, 2077, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2092, 254, true);
            WriteLiteral(" alt=\"Card Image\" class=\"card-img-top\" style=\"height:200px;\" />\r\n                    <div class=\"card-header\">\r\n                        <div style=\"text-align:center;\">\r\n                            <label style=\"font-size:20px; color: brown;\"><b>Price : ");
            EndContext();
            BeginContext(2347, 13, false);
#line 56 "C:\Users\Tipu\Desktop\ASP_DOTNET_CORE_MVC\Ecommerce\Ecommerce\Areas\Customer\Views\Home\Index.cshtml"
                                                                               Write(product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(2360, 131, true);
            WriteLiteral("</b></label>\r\n                        </div>\r\n                        <div style=\"text-align:center\">\r\n                            ");
            EndContext();
            BeginContext(2491, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d2855b8d2be3cfff52efe89c8d72d7780557ebe18247", async() => {
                BeginContext(2571, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "C:\Users\Tipu\Desktop\ASP_DOTNET_CORE_MVC\Ecommerce\Ecommerce\Areas\Customer\Views\Home\Index.cshtml"
                                                      WriteLiteral(product.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2582, 106, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 64 "C:\Users\Tipu\Desktop\ASP_DOTNET_CORE_MVC\Ecommerce\Ecommerce\Areas\Customer\Views\Home\Index.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(2706, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
            BeginContext(2748, 39, true);
            WriteLiteral("<div class=\"justify-content-end\">\r\n    ");
            EndContext();
            BeginContext(2788, 146, false);
#line 70 "C:\Users\Tipu\Desktop\ASP_DOTNET_CORE_MVC\Ecommerce\Ecommerce\Areas\Customer\Views\Home\Index.cshtml"
Write(Html.PagedListPager(Model, generatePageUrl: c => Href(contentPath: "~/Customer/Home/Index?page=" + c), PagedListRenderOptionsBase.PageNumbersOnly));

#line default
#line hidden
            EndContext();
            BeginContext(2934, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<Products>> Html { get; private set; }
    }
}
#pragma warning restore 1591
