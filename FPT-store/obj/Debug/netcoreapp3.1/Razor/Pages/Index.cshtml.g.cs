#pragma checksum "D:\Code\PRN292-Code\PRN292-SE1406-WebBanDienThoai\FPT-store\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49ccc17cee15b07bdabaa327026f4d80109b6f91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FPT_store.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace FPT_store.Pages
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
#line 1 "D:\Code\PRN292-Code\PRN292-SE1406-WebBanDienThoai\FPT-store\Pages\_ViewImports.cshtml"
using FPT_store;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49ccc17cee15b07bdabaa327026f4d80109b6f91", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"997d53a5e40ae7d336c328235b4e347d7be58038", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("list-group-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "FilterProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Products/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Code\PRN292-Code\PRN292-SE1406-WebBanDienThoai\FPT-store\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";
    Layout = "Shared/_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n</div>\r\n\r\n\r\n<div class=\"container\">\r\n\r\n    <div class=\"row\">\r\n\r\n        <div class=\"col-lg-3\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49ccc17cee15b07bdabaa327026f4d80109b6f914564", async() => {
                WriteLiteral(@"
                <h2>Search Product</h2>
                <input type=""text"" class=""form-control"">

                <div class=""dropdown-divider""></div>

                <div class=""list-group"">
                    <a href=""#"" class=""list-group-item"">Category 1</a>
                    <a href=""#"" class=""list-group-item"">Category 2</a>
                    <a href=""#"" class=""list-group-item"">Category 3</a>
                </div>

                <div class=""dropdown-divider""></div>
                <h3>Brand</h3>
                <div class=""list-group"">
");
#nullable restore
#line 33 "D:\Code\PRN292-Code\PRN292-SE1406-WebBanDienThoai\FPT-store\Pages\Index.cshtml"
                     foreach (var brand in Model.Brands)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49ccc17cee15b07bdabaa327026f4d80109b6f915714", async() => {
#nullable restore
#line 35 "D:\Code\PRN292-Code\PRN292-SE1406-WebBanDienThoai\FPT-store\Pages\Index.cshtml"
                                                                                                             Write(brand.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.PageHandler = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Brand", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "D:\Code\PRN292-Code\PRN292-SE1406-WebBanDienThoai\FPT-store\Pages\Index.cshtml"
                                                                                         WriteLiteral(brand.Name);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Brand"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Brand", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Brand"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 36 "D:\Code\PRN292-Code\PRN292-SE1406-WebBanDienThoai\FPT-store\Pages\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n\r\n                <div class=\"dropdown-divider\"></div>\r\n\r\n                <div class=\"list-group\">\r\n                    <a class=\"list-group-item\">Brand</a>\r\n                </div>\r\n            ");
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
            WriteLiteral(@"
        </div>
        <!-- /.col-lg-3 -->

        <div class=""col-lg-9"">

            <div id=""carouselExampleIndicators"" class=""carousel slide my-4"" data-ride=""carousel"">
                <ol class=""carousel-indicators"">
                    <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
                    <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
                    <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
                </ol>
                <div class=""carousel-inner"" role=""listbox"">
                    <div class=""carousel-item active"">
                        <img class=""d-block img-fluid"" src=""https://images.idgesg.net/images/article/2020/10/apple-oct-2020-event-100860961-large.jpg"" alt=""First slide"">
                    </div>
                    <div class=""carousel-item"">
                        <img class=""d-block img-fluid"" src=""https://photo.techrum.vn/images/2020/02/07/4XbcVU.jpg"" alt=");
            WriteLiteral(@"""Second slide"">
                    </div>
                    <div class=""carousel-item"">
                        <img class=""d-block img-fluid"" src=""https://mediaonlinevn.com/wp-content/uploads/2019/06/oppo-reno-10x-zoom.jpg"" alt=""Third slide"">
                    </div>
                </div>
                <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                    <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Previous</span>
                </a>
                <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
                    <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Next</span>
                </a>
            </div>

            <div class=""row"">

");
#nullable restore
#line 79 "D:\Code\PRN292-Code\PRN292-SE1406-WebBanDienThoai\FPT-store\Pages\Index.cshtml"
                 foreach (var product in Model.Products)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-4 col-md-6 mb-4\">\r\n                        <div class=\"card h-100 pt-3\">\r\n                            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 3512, "\"", 3532, 1);
#nullable restore
#line 83 "D:\Code\PRN292-Code\PRN292-SE1406-WebBanDienThoai\FPT-store\Pages\Index.cshtml"
WriteAttributeValue("", 3518, product.Image, 3518, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3533, "\"", 3539, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                            <div class=\"card-body\">\r\n                                <h4 class=\"card-title\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49ccc17cee15b07bdabaa327026f4d80109b6f9112927", async() => {
#nullable restore
#line 87 "D:\Code\PRN292-Code\PRN292-SE1406-WebBanDienThoai\FPT-store\Pages\Index.cshtml"
                                                                                       Write(product.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 87 "D:\Code\PRN292-Code\PRN292-SE1406-WebBanDienThoai\FPT-store\Pages\Index.cshtml"
                                                                   WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </h4>\r\n                                <h5>");
#nullable restore
#line 89 "D:\Code\PRN292-Code\PRN292-SE1406-WebBanDienThoai\FPT-store\Pages\Index.cshtml"
                               Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            </div>\r\n                            <div class=\"card-footer\">\r\n                                <small>Category: ");
#nullable restore
#line 92 "D:\Code\PRN292-Code\PRN292-SE1406-WebBanDienThoai\FPT-store\Pages\Index.cshtml"
                                            Write(product.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 96 "D:\Code\PRN292-Code\PRN292-SE1406-WebBanDienThoai\FPT-store\Pages\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 98 "D:\Code\PRN292-Code\PRN292-SE1406-WebBanDienThoai\FPT-store\Pages\Index.cshtml"
                 if (Model.Products.Count == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h4 class=\"text-danger\">Not found product suitable</h4>\r\n");
#nullable restore
#line 101 "D:\Code\PRN292-Code\PRN292-SE1406-WebBanDienThoai\FPT-store\Pages\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <!-- /.row -->\r\n\r\n        </div>\r\n        <!-- /.col-lg-9 -->\r\n\r\n    </div>\r\n    <!-- /.row -->\r\n\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 116 "D:\Code\PRN292-Code\PRN292-SE1406-WebBanDienThoai\FPT-store\Pages\Index.cshtml"
     if (!string.IsNullOrEmpty(Model.Message))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script>\r\n        alert(\"");
#nullable restore
#line 119 "D:\Code\PRN292-Code\PRN292-SE1406-WebBanDienThoai\FPT-store\Pages\Index.cshtml"
          Write(Model.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral("\")\r\n    </script>\r\n");
#nullable restore
#line 121 "D:\Code\PRN292-Code\PRN292-SE1406-WebBanDienThoai\FPT-store\Pages\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
