#pragma checksum "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\Invoice\UpdateInvoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3b71ca6c0c84f96543461fdcdbef318e8c1a02f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Invoice_UpdateInvoice), @"mvc.1.0.view", @"/Areas/Admin/Views/Invoice/UpdateInvoice.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3b71ca6c0c84f96543461fdcdbef318e8c1a02f", @"/Areas/Admin/Views/Invoice/UpdateInvoice.cshtml")]
    public class Areas_Admin_Views_Invoice_UpdateInvoice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataAccess.Entity.CustomerOrder>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/Order/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ms-body ms-aside-left-open ms-primary-theme ms-has-quickbar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\Invoice\UpdateInvoice.cshtml"
  
    ViewData["Title"] = "UpdateInvoice";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3b71ca6c0c84f96543461fdcdbef318e8c1a02f4213", async() => {
                WriteLiteral("\r\n    <main class=\"body-content\">\r\n        <div class=\"ms-panel-header\">\r\n            <h6>");
#nullable restore
#line 9 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\Invoice\UpdateInvoice.cshtml"
           Write(Model.TableNo);

#line default
#line hidden
#nullable disable
                WriteLiteral(" BİLGİLERİ</h6>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3b71ca6c0c84f96543461fdcdbef318e8c1a02f4846", async() => {
                    WriteLiteral("Faturalandırma Menü -->");
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
            <div class=""card"">
                <form asp-action=""GetOrder"" method=""POST"">
                    <div class=""form-row"">
                        <div class=""col-md-12 mb-3"">
                            <div class=""col-md-12 mb-2"">
                                <label asp-for=""CompanyName""><strong>  Sipariş Numarası:</strong></label>
                            </div>
                            <div class=""col-md-12 mb-2"">
                                ");
#nullable restore
#line 21 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\Invoice\UpdateInvoice.cshtml"
                           Write(Html.TextBoxFor(x => x.Id, new { @class = "form-control", type = "text" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-md-12 mb-3"">
                            <div class=""col-md-12 mb-2 float-right"">
                                <label asp-for=""ContactName""><strong>  Tarih:</strong></label>
                            </div>
                            <div class=""col-md-12 mb-2"">
                                ");
#nullable restore
#line 29 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\Invoice\UpdateInvoice.cshtml"
                           Write(Html.TextBoxFor(x => x.CreatedDate, new { @class = "form-control", type = "date" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-md-12 mb-3"">
                            <div class=""col-md-12 mb-2"">
                                <label asp-for=""ContactTitle""><strong>  Masa Numarası:</strong></label>
                            </div>
                            <div class=""col-md-12 mb-2"">
                                ");
#nullable restore
#line 37 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\Invoice\UpdateInvoice.cshtml"
                           Write(Html.TextBoxFor(x => x.TableNo, new { @class = "form-control", type = "date" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-md-12 mb-3"">
                            <div class=""col-md-12 mb-2"">
                                <label asp-for=""Phone""><strong>  Personel:</strong></label>
                            </div>
                            <div class=""col-md-12 mb-2"">
                                ");
#nullable restore
#line 45 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\Invoice\UpdateInvoice.cshtml"
                           Write(Html.TextBoxFor(x => x.Employee.FirstName, new { @class = "form-control", type = "date" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 45 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\Invoice\UpdateInvoice.cshtml"
                                                                                                                       Write(Html.TextBoxFor(x => x.Employee.LastName, new { @class = "form-control", type = "date" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </div>
                        </div>

                        <div class=""col-md-12 mb-3"">
                            <div class=""col-md-12 mb-2"">
                                <label asp-for=""Fax""><strong>  Siparişler:</strong></label>
                            </div>
                            <div class=""col-md-12 mb-2"">
                                ");
#nullable restore
#line 54 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\Invoice\UpdateInvoice.cshtml"
                           Write(Html.TextBoxFor(x => x.MenuProducts, new { @class = "form-control", type = "date" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-md-12 mb-3"">
                            <div class=""col-md-12 mb-2"">
                                <label asp-for=""Adress""><strong>  TUTAR:</strong></label>
                            </div>
                            <div class=""col-md-12 mb-2"">
                                ");
#nullable restore
#line 62 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\Invoice\UpdateInvoice.cshtml"
                           Write(Html.TextBoxFor(x => x.Price, new { @class = "form-control", type = "date" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n                    </div>\r\n\r\n\r\n                </form>\r\n            </div>\r\n        </div>\r\n    </main>\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataAccess.Entity.CustomerOrder> Html { get; private set; }
    }
}
#pragma warning restore 1591
