#pragma checksum "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Chef\Views\StorageProduct\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e99fbfc687c79cc25ba880c5cdf029dae8e194e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Chef_Views_StorageProduct_Index), @"mvc.1.0.view", @"/Areas/Chef/Views/StorageProduct/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e99fbfc687c79cc25ba880c5cdf029dae8e194e4", @"/Areas/Chef/Views/StorageProduct/Index.cshtml")]
    public class Areas_Chef_Views_StorageProduct_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DataAccess.Entity.StorageProduct>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Chef/Home"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Chef\Views\StorageProduct\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Chef/Views/Shared/_ChefLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main class=""body-content"">
    <div class=""ms-content-wrapper"">
        <div class=""row"">
            <div class=""col-md-9"">
                <nav aria-label=""breadcrumb"">
                    <ol class=""breadcrumb pl-0"">
                        <li class=""breadcrumb-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e99fbfc687c79cc25ba880c5cdf029dae8e194e43611", async() => {
                WriteLiteral("<i class=\"material-icons\">home</i> AnaSayfa");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                        <li class=""breadcrumb-item active"" aria-current=""page"">Depo Ürünleri</li>
                    </ol>
                </nav>
            </div>
            
            <div class=""col-md-12"">
                <div class=""col-12"">
                    <div class=""ms-panel"">
                        <div class=""ms-panel-header"">
                            <h6>Depo Ürün Listesi</h6>

                        </div>
                        <div class=""ms-panel-body"">

                            <div class=""table-responsive"">
                                <table class=""table table-hover thead-primary"">
                                    <thead>
                                        <tr>
                                            <th scope=""col"">Görsel</th>
                                            <th scope=""col"">Ürün ID</th>
                                            <th scope=""col"">Ürün Adı</th>
                                            <th scope=""col"">");
            WriteLiteral(@"Fiyat(Alış)</th>
                                            <th scope=""col"">Stok</th>
                                            <th scope=""col"">Birim</th>
                                            <th scope=""col"">Kategori Adı</th>
                                            <th scope=""col"">Verilen Sipariş</th>
                                            <th scope=""col""></th>

                                        </tr>
                                    </thead>
                                    <tbody>

");
#nullable restore
#line 46 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Chef\Views\StorageProduct\Index.cshtml"
                                         foreach (var storageProduct in Model)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <th scope=\"row\">");
#nullable restore
#line 49 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Chef\Views\StorageProduct\Index.cshtml"
                                                       Write(storageProduct.ProductImagePath);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                            <td><h6>");
#nullable restore
#line 50 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Chef\Views\StorageProduct\Index.cshtml"
                                               Write(storageProduct.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6></td>\r\n                                            <td><h6>");
#nullable restore
#line 51 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Chef\Views\StorageProduct\Index.cshtml"
                                               Write(storageProduct.StorageProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6></td>\r\n                                            <td><h6>");
#nullable restore
#line 52 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Chef\Views\StorageProduct\Index.cshtml"
                                               Write(storageProduct.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</h6></td>\r\n");
#nullable restore
#line 53 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Chef\Views\StorageProduct\Index.cshtml"
                                             if (storageProduct.UnitsInStock != 0)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <td><h6>");
#nullable restore
#line 55 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Chef\Views\StorageProduct\Index.cshtml"
                                                   Write(storageProduct.UnitsInStock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6></td>\r\n");
#nullable restore
#line 56 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Chef\Views\StorageProduct\Index.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td ><h4 class=\"color-red\">");
#nullable restore
#line 59 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Chef\Views\StorageProduct\Index.cshtml"
                                                              Write(storageProduct.UnitsInStock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></td>\r\n");
#nullable restore
#line 60 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Chef\Views\StorageProduct\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td><h6>");
#nullable restore
#line 61 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Chef\Views\StorageProduct\Index.cshtml"
                                               Write(storageProduct.QuantityPerUnit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6></td>\r\n                                            <td>");
#nullable restore
#line 62 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Chef\Views\StorageProduct\Index.cshtml"
                                           Write(storageProduct.StorageCategory.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td><h6>");
#nullable restore
#line 63 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Chef\Views\StorageProduct\Index.cshtml"
                                               Write(storageProduct.UnitsOnOrder);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6></td>\r\n\r\n                                        </tr>\r\n");
#nullable restore
#line 66 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Chef\Views\StorageProduct\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</main>



");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DataAccess.Entity.StorageProduct>> Html { get; private set; }
    }
}
#pragma warning restore 1591
