#pragma checksum "D:\Code\Temp\PRN-Test\FPT-store\FPT-store\Pages\Orders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b7a10de13c1c3490b7ded4391cb96e59ff34bbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FPT_store.Pages.Orders.Pages_Orders_Index), @"mvc.1.0.razor-page", @"/Pages/Orders/Index.cshtml")]
namespace FPT_store.Pages.Orders
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Code\Temp\PRN-Test\FPT-store\FPT-store\Pages\_ViewImports.cshtml"
using FPT_store;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b7a10de13c1c3490b7ded4391cb96e59ff34bbf", @"/Pages/Orders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"997d53a5e40ae7d336c328235b4e347d7be58038", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Orders_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Code\Temp\PRN-Test\FPT-store\FPT-store\Pages\Orders\Index.cshtml"
  
    ViewData["Title"] = "Search order";
    Layout = "Shared/_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b7a10de13c1c3490b7ded4391cb96e59ff34bbf4093", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"handler\" value=\"Search\">\r\n    <input type=\"text\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 225, "\"", 233, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b7a10de13c1c3490b7ded4391cb96e59ff34bbf4613", async() => {
                    WriteLiteral("Search");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 15 "D:\Code\Temp\PRN-Test\FPT-store\FPT-store\Pages\Orders\Index.cshtml"
 if (Model.Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-12\">\r\n            <ul class=\"list-group\">\r\n                <li class=\"list-group-item\">Order Id: ");
#nullable restore
#line 20 "D:\Code\Temp\PRN-Test\FPT-store\FPT-store\Pages\Orders\Index.cshtml"
                                                 Write(Model.Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item\">Customer Email: ");
#nullable restore
#line 21 "D:\Code\Temp\PRN-Test\FPT-store\FPT-store\Pages\Orders\Index.cshtml"
                                                       Write(Model.Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item\">Create Date: ");
#nullable restore
#line 22 "D:\Code\Temp\PRN-Test\FPT-store\FPT-store\Pages\Orders\Index.cshtml"
                                                    Write(Model.Model.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            </ul>\r\n\r\n        </div>\r\n");
#nullable restore
#line 26 "D:\Code\Temp\PRN-Test\FPT-store\FPT-store\Pages\Orders\Index.cshtml"
         if (Model.Model.OrderDetails != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""row"">
                <h3 class=""text-primary my-5"">Order Detail: </h3>
                <div class=""col-12"">
                    <table class=""table"">
                        <thead>
                        <tr>
                            <th scope=""col"">Prouduct name</th>
                            <th scope=""col"">Price</th>
                            <th scope=""col"">Quantity</th>
                            <th scope=""col"">Amount</th>
                        </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 41 "D:\Code\Temp\PRN-Test\FPT-store\FPT-store\Pages\Orders\Index.cshtml"
                         foreach (var orderDetail in Model.Model.OrderDetails)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 44 "D:\Code\Temp\PRN-Test\FPT-store\FPT-store\Pages\Orders\Index.cshtml"
                               Write(orderDetail.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 45 "D:\Code\Temp\PRN-Test\FPT-store\FPT-store\Pages\Orders\Index.cshtml"
                               Write(orderDetail.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 46 "D:\Code\Temp\PRN-Test\FPT-store\FPT-store\Pages\Orders\Index.cshtml"
                               Write(orderDetail.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 47 "D:\Code\Temp\PRN-Test\FPT-store\FPT-store\Pages\Orders\Index.cshtml"
                               Write(orderDetail.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 49 "D:\Code\Temp\PRN-Test\FPT-store\FPT-store\Pages\Orders\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 54 "D:\Code\Temp\PRN-Test\FPT-store\FPT-store\Pages\Orders\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 57 "D:\Code\Temp\PRN-Test\FPT-store\FPT-store\Pages\Orders\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3 class=\"text-danger\">Not Found Order</h3>\r\n");
#nullable restore
#line 61 "D:\Code\Temp\PRN-Test\FPT-store\FPT-store\Pages\Orders\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 65 "D:\Code\Temp\PRN-Test\FPT-store\FPT-store\Pages\Orders\Index.cshtml"
     if (!string.IsNullOrEmpty(Model.Message))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script>alert(\"");
#nullable restore
#line 67 "D:\Code\Temp\PRN-Test\FPT-store\FPT-store\Pages\Orders\Index.cshtml"
                  Write(Model.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral("\")</script>\r\n");
#nullable restore
#line 68 "D:\Code\Temp\PRN-Test\FPT-store\FPT-store\Pages\Orders\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FPT_store.Pages.Orders.Index> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FPT_store.Pages.Orders.Index> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FPT_store.Pages.Orders.Index>)PageContext?.ViewData;
        public FPT_store.Pages.Orders.Index Model => ViewData.Model;
    }
}
#pragma warning restore 1591
