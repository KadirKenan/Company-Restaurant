#pragma checksum "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Menu\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3140cde8e6101b952830c07891f0c68fb98a391"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Waiter_Views_Menu_Index), @"mvc.1.0.view", @"/Areas/Waiter/Views/Menu/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3140cde8e6101b952830c07891f0c68fb98a391", @"/Areas/Waiter/Views/Menu/Index.cshtml")]
    public class Areas_Waiter_Views_Menu_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DataAccess.Entity.MenuProduct>>
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
#line 2 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Menu\Index.cshtml"
  
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3140cde8e6101b952830c07891f0c68fb98a3913567", async() => {
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


            
                <form asp-action=""AddTable"" asp-controller=""Table"" method=""POST"">
");
#nullable restore
#line 23 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Menu\Index.cshtml"
                     for (int i = 1; i < 30; i++)
                    {


                        foreach (var menu in Model)
                        {

                            if (menu.MenuCategoryId == i)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""card float-left"" style=""width: 18rem;"" >
                                    <img src=""..."" class=""card-img-top"" alt=""..."">
                                    <div class=""card-body"">
                                        <h5 class=""card-title"">");
#nullable restore
#line 35 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Menu\Index.cshtml"
                                                          Write(menu.MenuName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                        <p class=\"card-text\">");
#nullable restore
#line 36 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Menu\Index.cshtml"
                                                        Write(menu.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                    <ul class=\"list-group list-group-flush\">\r\n                                        <li class=\"list-group-item\">");
#nullable restore
#line 39 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Menu\Index.cshtml"
                                                               Write(menu.MenuCategory.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                        <li class=\"list-group-item\">");
#nullable restore
#line 40 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Menu\Index.cshtml"
                                                               Write(menu.MenuPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL </li>\r\n\r\n\r\n");
#nullable restore
#line 43 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Menu\Index.cshtml"
                                         if (menu.StockStatus)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li class=\"list-group-item\">Mevcut</li>\r\n");
#nullable restore
#line 46 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Menu\Index.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li class=\"list-group-item\"><strong>Şuan Ürün Mevcut Değildir!!!</strong></li>\r\n");
#nullable restore
#line 50 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Menu\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </ul>\r\n                                    \r\n                                </div>\r\n");
#nullable restore
#line 55 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Menu\Index.cshtml"
                            }
                        }

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </form>\r\n            </div>\r\n          </div>\r\n        \r\n</main>\r\n");
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