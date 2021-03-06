#pragma checksum "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Order\AddOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "577618b56951840a0e0e42973e406f38b71a2c8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Waiter_Views_Order_AddOrder), @"mvc.1.0.view", @"/Areas/Waiter/Views/Order/AddOrder.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"577618b56951840a0e0e42973e406f38b71a2c8a", @"/Areas/Waiter/Views/Order/AddOrder.cshtml")]
    public class Areas_Waiter_Views_Order_AddOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DataAccess.Entity.MenuProduct>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Waiter/Table/AddTable"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/hazırcss/assets/img/foodtech/food-1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("card_img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("350"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("275"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Order\AddOrder.cshtml"
  
    ViewData["Title"] = "AddOder";
    Layout = "~/Areas/Waiter/Views/Shared/_WaiterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<main class=""body-content"">
    <div class=""ms-panel-header"">
        <h6> Sipariş Formu</h6>
    </div>
    <div class=""ms-panel-body"">
        <form asp-action=""AddOrder"" asp-controller=""Order"" method=""POST"">
            <div class=""form-row"">
                <div class=""col-md-12 mb-3"">
                    <label class=""text-center"">Masa Numarası Seçiniz</label>
                    <div class=""input-group"">
                        <select class=""col-md-3"" name=""masaId"" >
");
#nullable restore
#line 19 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Order\AddOrder.cshtml"
                             foreach (var item in ViewBag.Table)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 783, "\"", 799, 1);
#nullable restore
#line 21 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Order\AddOrder.cshtml"
WriteAttributeValue("", 791, item.Id, 791, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Masa Numarası : ");
#nullable restore
#line 21 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Order\AddOrder.cshtml"
                                                                    Write(item.TableNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 22 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Order\AddOrder.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n\r\n                    </div>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "577618b56951840a0e0e42973e406f38b71a2c8a6966", async() => {
                WriteLiteral("Masa Açma");
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
            WriteLiteral("\r\n                </div>\r\n                \r\n");
#nullable restore
#line 29 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Order\AddOrder.cshtml"
                 foreach (var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-4 col-md-6 col-sm-6 \">\r\n                        <div class=\"ms-card\">\r\n                            <div class=\"ms-card-img\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "577618b56951840a0e0e42973e406f38b71a2c8a8634", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            <div class=""ms-card-body "">
                                <div class=""input-group"">
                                    <div class=""wrapper-new2 "">
                                        <div >
                                            <h6><strong >");
#nullable restore
#line 39 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Order\AddOrder.cshtml"
                                                    Write(item.MenuName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h6>\r\n                                            <span >");
#nullable restore
#line 40 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Order\AddOrder.cshtml"
                                              Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                            <button >Fiyat : ");
#nullable restore
#line 41 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Order\AddOrder.cshtml"
                                                        Write(item.MenuPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</button>\r\n                                            <input type=\"text\" name=\"menuId\"");
            BeginWriteAttribute("value", " value=\"", 2018, "\"", 2034, 1);
#nullable restore
#line 42 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Order\AddOrder.cshtml"
WriteAttributeValue("", 2026, item.Id, 2026, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden=\"hidden\" />\r\n                                            <br />\r\n                                            <label > ");
#nullable restore
#line 44 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Order\AddOrder.cshtml"
                                                Write(Html.CheckBox("Siparis", @item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Siparişe Ekle</label>
                                        </div>
                                       
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 52 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Order\AddOrder.cshtml"

                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <button class=\"btn btn-secondary float-right\" type=\"submit\">Sipariş Oluştur</button>\r\n\r\n        </form>\r\n\r\n    </div>\r\n\r\n</main>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DataAccess.Entity.MenuProduct>> Html { get; private set; }
    }
}
#pragma warning restore 1591
