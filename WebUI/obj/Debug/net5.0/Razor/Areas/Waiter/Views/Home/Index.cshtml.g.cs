#pragma checksum "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31c7a27c15e0141e9eb02a5afa806e85ef8dc390"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Waiter_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Waiter/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31c7a27c15e0141e9eb02a5afa806e85ef8dc390", @"/Areas/Waiter/Views/Home/Index.cshtml")]
    public class Areas_Waiter_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DataAccess.Entity.MenuProduct>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Waiter/Home"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Waiter/Views/Shared/_WaiterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main class=""body-content"">
    <div class=""ms-content-wrapper"">
        <div class=""row"">
            <div class=""col-md-12"">
                <nav aria-label=""breadcrumb"">
                    <ol class=""breadcrumb pl-0"">
                        <li class=""breadcrumb-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31c7a27c15e0141e9eb02a5afa806e85ef8dc3903567", async() => {
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

                        <li class=""breadcrumb-item active"" aria-current=""page"">Menü</li>
                    </ol>
                </nav>
            </div>
            <div class=""col-md-12"">
                <div class=""col-12"">
                    <div class=""ms-panel"">
                        <div class=""ms-panel-header"">
                            <h6> Menü </h6>

                        </div>
                        <div class=""ms-panel-body"">

                            <div class=""table-responsive"">
                                <table class=""table w-100 thead-primary dataTable no-footer"" role=""grid"" style=""width: 1099px;"">
                                    <thead>
                                        <tr role=""row"">
                                            <th class=""sorting_asc"" tabindex=""0"" aria-controls=""data-table-4"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""Customer ID: activate to sort column descending"" style=""width: 156px;"">
             ");
            WriteLiteral(@"                                   Menü Görsel
                                            </th>
                                            <th class=""sorting"" tabindex=""0"" aria-controls=""data-table-4"" rowspan=""1"" colspan=""1"" aria-label=""Customer Name: activate to sort column ascending"" style=""width: 196px;"">
                                                Menü ID
                                            </th>
                                            <th class=""sorting"" tabindex=""0"" aria-controls=""data-table-4"" rowspan=""1"" colspan=""1"" aria-label=""Customer Name: activate to sort column ascending"" style=""width: 196px;"">
                                                Menü Adı
                                            </th>
                                            <th class=""sorting"" tabindex=""0"" aria-controls=""data-table-4"" rowspan=""1"" colspan=""1"" aria-label=""Email ID: activate to sort column ascending"" style=""width: 153px;"">
                                                Kategori Adı
   ");
            WriteLiteral(@"                                         </th>
                                            <th class=""sorting"" tabindex=""0"" aria-controls=""data-table-4"" rowspan=""1"" colspan=""1"" aria-label=""Ordered Item: activate to sort column ascending"" style=""width: 162px;"">
                                                Stok Durumu
                                            </th>
                                            <th class=""sorting"" tabindex=""0"" aria-controls=""data-table-4"" rowspan=""1"" colspan=""1"" aria-label=""Bill: activate to sort column ascending"" style=""width: 61px;"">
                                                Fiyat
                                            </th>
                                            <th></th>

                                        </tr>
                                    </thead>
                                    <tbody>
");
#nullable restore
#line 55 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Home\Index.cshtml"
                                         foreach (var menuProduct in Model)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <tr role=""row"" class=""odd"">
                                                <td><img src=""../../assets/img/foodtech/customer-3.jpg"" style=""width:50px; height:30px;""></td>
                                                <td class=""sorting_1"">");
#nullable restore
#line 59 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Home\Index.cshtml"
                                                                 Write(menuProduct.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 60 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Home\Index.cshtml"
                                               Write(menuProduct.MenuName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 61 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Home\Index.cshtml"
                                               Write(menuProduct.MenuCategory.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>\r\n");
#nullable restore
#line 63 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Home\Index.cshtml"
                                                     if (@menuProduct.StockStatus == true)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <span>Mevcut</span>\r\n");
#nullable restore
#line 66 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Home\Index.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <span><strong>Mevcut Değil</strong></span>\r\n");
#nullable restore
#line 70 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Home\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </td>\r\n                                                <td>");
#nullable restore
#line 72 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Home\Index.cshtml"
                                               Write(menuProduct.MenuPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</td>\r\n\r\n                                            </tr>\r\n");
#nullable restore
#line 75 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Home\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </tbody>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DataAccess.Entity.MenuProduct>> Html { get; private set; }
    }
}
#pragma warning restore 1591