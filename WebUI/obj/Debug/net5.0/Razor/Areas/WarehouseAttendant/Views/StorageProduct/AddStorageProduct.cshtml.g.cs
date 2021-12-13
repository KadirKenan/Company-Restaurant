#pragma checksum "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\WarehouseAttendant\Views\StorageProduct\AddStorageProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bfd892de7c0ddd03dfb1ad1077b7b5bdab6efab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_WarehouseAttendant_Views_StorageProduct_AddStorageProduct), @"mvc.1.0.view", @"/Areas/WarehouseAttendant/Views/StorageProduct/AddStorageProduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bfd892de7c0ddd03dfb1ad1077b7b5bdab6efab", @"/Areas/WarehouseAttendant/Views/StorageProduct/AddStorageProduct.cshtml")]
    public class Areas_WarehouseAttendant_Views_StorageProduct_AddStorageProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataAccess.Entity.StorageProduct>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/WarehouseAttendant/StorageProduct/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\WarehouseAttendant\Views\StorageProduct\AddStorageProduct.cshtml"
  
    ViewData["Title"] = "AddStorageProduct";
    Layout = "~/Areas/WarehouseAttendant/Views/Shared/_WarehouseAttendantLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main class=\"body-content\">\r\n\r\n    <div class=\"ms-panel-header\">\r\n        <h6> Depo Ürünü Ekleme Formu</h6>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bfd892de7c0ddd03dfb1ad1077b7b5bdab6efab4035", async() => {
                WriteLiteral("Depo Ürünler Listesi");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <div class=""ms-panel-body"">
        <form asp-action=""AddStorageProduct"" asp-controller=""StorageProduct"" method=""POST"">
            <div class=""form-row"">
                <div class=""col-md-12 mb-3"">
                    <label for=""validationCustom18"">Ürün Adı</label>
                    <input name=""StorageProductName"" type=""text"" class=""form-control"" placeholder=""Ürün adını giriniz..."" />
                </div>
                <div class=""col-md-12 mb-3"">
                    <label for=""validationCustom18"">Fiyat</label>
                    <input name=""UnitPrice"" type=""number"" class=""form-control"" />
                </div>
                <div class=""col-md-12 mb-3"">
                    <label for=""validationCustom18"">Stok</label>
                    <input name=""UnitsInStock"" type=""number"" class=""form-control"" />
                </div>
                <div class=""col-md-12 mb-3"">
                    <label sp-for=""QuantityPerUnit"">Birim</label>
                    <div cl");
            WriteLiteral("ass=\"input-group\">\r\n                        <select name=\"QuantityPerUnit\" class=\"form-control\">\r\n                            <option value=\"0\">");
#nullable restore
#line 32 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\WarehouseAttendant\Views\StorageProduct\AddStorageProduct.cshtml"
                                         Write(DataAccess.Enum.QuantityPerUnit.Kilogram);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n                            <option value=\"1\">");
#nullable restore
#line 33 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\WarehouseAttendant\Views\StorageProduct\AddStorageProduct.cshtml"
                                         Write(DataAccess.Enum.QuantityPerUnit.Gram);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n                            <option value=\"2\">");
#nullable restore
#line 34 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\WarehouseAttendant\Views\StorageProduct\AddStorageProduct.cshtml"
                                         Write(DataAccess.Enum.QuantityPerUnit.Litre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n                            <option value=\"3\">");
#nullable restore
#line 35 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\WarehouseAttendant\Views\StorageProduct\AddStorageProduct.cshtml"
                                         Write(DataAccess.Enum.QuantityPerUnit.Fıçı);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n                            <option value=\"4\">");
#nullable restore
#line 36 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\WarehouseAttendant\Views\StorageProduct\AddStorageProduct.cshtml"
                                         Write(DataAccess.Enum.QuantityPerUnit.Şişe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n                            <option value=\"5\">");
#nullable restore
#line 37 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\WarehouseAttendant\Views\StorageProduct\AddStorageProduct.cshtml"
                                         Write(DataAccess.Enum.QuantityPerUnit.Paket);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n                            <option value=\"6\">");
#nullable restore
#line 38 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\WarehouseAttendant\Views\StorageProduct\AddStorageProduct.cshtml"
                                         Write(DataAccess.Enum.QuantityPerUnit.Kutu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n                            <option value=\"7\">");
#nullable restore
#line 39 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\WarehouseAttendant\Views\StorageProduct\AddStorageProduct.cshtml"
                                         Write(DataAccess.Enum.QuantityPerUnit.Teneke);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n                            <option value=\"8\">");
#nullable restore
#line 40 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\WarehouseAttendant\Views\StorageProduct\AddStorageProduct.cshtml"
                                         Write(DataAccess.Enum.QuantityPerUnit.Kasa);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</option>
                        </select>
                    </div>
                </div>
                <div class=""col-md-6 mb-3"">
                    <label for=""validationCustom22"">Kategori Seçiniz</label>
                    <div class=""input-group"">
                        ");
#nullable restore
#line 47 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\WarehouseAttendant\Views\StorageProduct\AddStorageProduct.cshtml"
                   Write(Html.DropDownListFor(x => x.StorageCategoryId, (SelectList)ViewBag.Categories, new { @class = " form-control m-bot15" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-6 mb-3\">\r\n                    <label for=\"validationCustom22\">Tedarikçi Seçiniz</label>\r\n                    <div class=\"input-group\">\r\n                        ");
#nullable restore
#line 53 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\WarehouseAttendant\Views\StorageProduct\AddStorageProduct.cshtml"
                   Write(Html.DropDownListFor(x => x.SupplierId, (SelectList)ViewBag.Supplier, new { @class = " form-control m-bot15" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""col-md-12 mb-3"">
                    <label for=""validationCustom12"">Ürün Görseli</label>
                    <div class=""custom-file"">
                        <input type=""file"" class=""custom-file-input"" id=""validatedCustomFile"">
                        <input name=""ProductImagePath"" type=""file"" class=""form-control"" />
                    </div>
                </div>
                <button class=""btn btn-primary float-end"" type=""submit"">Kaydet</button>
            </div>
        </form>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataAccess.Entity.StorageProduct> Html { get; private set; }
    }
}
#pragma warning restore 1591