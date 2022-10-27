#pragma checksum "C:\Users\Admin\Desktop\Project_C#\MyShop\MyShop\MyShop\Pages\Main\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8bc52f27ed97d43f5d1a1882518e223054624d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Main_Cart), @"mvc.1.0.razor-page", @"/Pages/Main/Cart.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8bc52f27ed97d43f5d1a1882518e223054624d1", @"/Pages/Main/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Main_Cart : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button is-text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Main/Main", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Checkout/CustomerInformation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button is-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/cart/cart.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div  id=\"app\" class=\"section\">\r\n    <div class=\"container\">\r\n        <div class=\"columns\">\r\n            <div class=\"column is-8 is-offset-2\">\r\n");
#nullable restore
#line 10 "C:\Users\Admin\Desktop\Project_C#\MyShop\MyShop\MyShop\Pages\Main\Cart.cshtml"
                 foreach (var product in Model.Cart)
                {
                    var image_path = $"/Image/{product.Image}";

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"level\"");
            BeginWriteAttribute("id", " id=\"", 372, "\"", 401, 2);
            WriteAttributeValue("", 377, "product-", 377, 8, true);
#nullable restore
#line 13 "C:\Users\Admin\Desktop\Project_C#\MyShop\MyShop\MyShop\Pages\Main\Cart.cshtml"
WriteAttributeValue("", 385, product.StockId, 385, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"level-item\">\r\n                            <figure class=\"image is-128x128\">\r\n                                 <img");
            BeginWriteAttribute("src", " src=\"", 555, "\"", 572, 1);
#nullable restore
#line 16 "C:\Users\Admin\Desktop\Project_C#\MyShop\MyShop\MyShop\Pages\Main\Cart.cshtml"
WriteAttributeValue("", 561, image_path, 561, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Placeholder image"">
                            </figure>
                        </div>
                        <div class=""level-item"">
                                <div class=""columns is-gapless is-multiline has-text-centered"">
                                <div class=""column is-12 title"">");
#nullable restore
#line 21 "C:\Users\Admin\Desktop\Project_C#\MyShop\MyShop\MyShop\Pages\Main\Cart.cshtml"
                                                           Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                <div class=\"column is-6\">");
#nullable restore
#line 22 "C:\Users\Admin\Desktop\Project_C#\MyShop\MyShop\MyShop\Pages\Main\Cart.cshtml"
                                                    Write(product.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                <div class=\"column is-6\">");
#nullable restore
#line 23 "C:\Users\Admin\Desktop\Project_C#\MyShop\MyShop\MyShop\Pages\Main\Cart.cshtml"
                                                    Write(product.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                            </div>
                        </div>
                        <div class=""level-item"">
                            <div class=""columns has-text-centered is-gapless is-mobile is-multiline"">
                                <div class=""column is-4"">
                                        <button class=""button"" type=""button"" ");
            WriteLiteral("@click=\"removeOneFromCart(");
#nullable restore
#line 29 "C:\Users\Admin\Desktop\Project_C#\MyShop\MyShop\MyShop\Pages\Main\Cart.cshtml"
                                                                                                   Write(product.StockId);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 29 "C:\Users\Admin\Desktop\Project_C#\MyShop\MyShop\MyShop\Pages\Main\Cart.cshtml"
                                                                                                                     Write(product.RealPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(")\">-</button>\r\n                                </div>\r\n                                <div class=\"column is-4 align-self-center has-text-centered\"");
            BeginWriteAttribute("id", " id=\"", 1627, "\"", 1648, 1);
#nullable restore
#line 31 "C:\Users\Admin\Desktop\Project_C#\MyShop\MyShop\MyShop\Pages\Main\Cart.cshtml"
WriteAttributeValue("", 1632, product.StockId, 1632, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 32 "C:\Users\Admin\Desktop\Project_C#\MyShop\MyShop\MyShop\Pages\Main\Cart.cshtml"
                               Write(product.Qty);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"column\">\r\n                                    <button class=\"button is-4\" ");
            WriteLiteral("@click=\"getAllQty(");
#nullable restore
#line 35 "C:\Users\Admin\Desktop\Project_C#\MyShop\MyShop\MyShop\Pages\Main\Cart.cshtml"
                                                                              Write(product.AllQty);

#line default
#line hidden
#nullable disable
            WriteLiteral(");addOneToCart(");
#nullable restore
#line 35 "C:\Users\Admin\Desktop\Project_C#\MyShop\MyShop\MyShop\Pages\Main\Cart.cshtml"
                                                                                                            Write(product.StockId);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 35 "C:\Users\Admin\Desktop\Project_C#\MyShop\MyShop\MyShop\Pages\Main\Cart.cshtml"
                                                                                                                              Write(product.RealPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(")\" type=\"button\">+</button>\r\n                                </div>\r\n                                <div class=\"column is-12\">\r\n                                    <a class=\"has-text-danger\" ");
            WriteLiteral("@click=\"removeAllFromCart(");
#nullable restore
#line 38 "C:\Users\Admin\Desktop\Project_C#\MyShop\MyShop\MyShop\Pages\Main\Cart.cshtml"
                                                                                     Write(product.StockId);

#line default
#line hidden
#nullable disable
            WriteLiteral(")\">Remove</a>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"level-item\">\r\n                            <p>$<span");
            BeginWriteAttribute("id", " id=\"", 2390, "\"", 2417, 2);
            WriteAttributeValue("", 2395, "price-", 2395, 6, true);
#nullable restore
#line 43 "C:\Users\Admin\Desktop\Project_C#\MyShop\MyShop\MyShop\Pages\Main\Cart.cshtml"
WriteAttributeValue("", 2401, product.StockId, 2401, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 43 "C:\Users\Admin\Desktop\Project_C#\MyShop\MyShop\MyShop\Pages\Main\Cart.cshtml"
                                                              Write(product.RealPrice * product.Qty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 46 "C:\Users\Admin\Desktop\Project_C#\MyShop\MyShop\MyShop\Pages\Main\Cart.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"has-text-right\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8bc52f27ed97d43f5d1a1882518e223054624d112258", async() => {
                WriteLiteral("Сontinue shopping");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8bc52f27ed97d43f5d1a1882518e223054624d113526", async() => {
                WriteLiteral("Checkout");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n     ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8bc52f27ed97d43f5d1a1882518e223054624d114962", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyShop.Pages.Main.CartModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyShop.Pages.Main.CartModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyShop.Pages.Main.CartModel>)PageContext?.ViewData;
        public MyShop.Pages.Main.CartModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591