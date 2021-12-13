#pragma checksum "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\AppUser\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd676f05e22fca2e78de6581ddd410acdba452e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AppUser_Register), @"mvc.1.0.view", @"/Areas/Admin/Views/AppUser/Register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd676f05e22fca2e78de6581ddd410acdba452e0", @"/Areas/Admin/Views/AppUser/Register.cshtml")]
    public class Areas_Admin_Views_AppUser_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebUI.Models.ViewModels.RegisterVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/AppUser/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\AppUser\Register.cshtml"
  
    ViewData["Title"] = "Register";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<main class=\"body-content\">\r\n\r\n    <div class=\"ms-panel-header\">\r\n        <h6> Kullanıcı Personel Kayıt Formu</h6>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd676f05e22fca2e78de6581ddd410acdba452e03811", async() => {
                WriteLiteral("Kullanıcı Personel Listesi");
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
       
            <div class=""container"">
                <div class=""card bg-light"">
                    <div asp-validation-summary=""All"" class=""text-danger"">
                        
                    </div>
                    <form asp-action=""Register"" asp-controller=""AppUser"" method=""post"">
                        <div class=""form-group input-group"">
                            <div class=""input-group-prepend"">
                                <span class=""input-group-text"">
                                    <i class=""fa fa-envelope""></i>
                                </span>
                            </div>
                            <span asp-validation-for=""Email"" class=""text-danger""></span>
                            <input asp-for=""Email"" class=""form-control"" placeholder=""Mail adres"">
                        </div>

                        
                        <div class=""form-group input-group"">
                     ");
            WriteLiteral(@"       <div class=""input-group-prepend"">
                                <span class=""input-group-text"">
                                    <i class=""fa fa-user""></i>
                                </span>
                            </div>
                            <span asp-validation-for=""UserName"" class=""text-danger""></span>
                            <input asp-for=""UserName"" class=""form-control"" placeholder=""Kullanıcı Adı"">
                        </div>

                        <div class=""form-group input-group"">
                            <div class=""input-group-prepend"">
                                <span class=""input-group-text"">
                                    <i class=""fa fa-lock""></i>
                                </span>
                            </div>
                            <span asp-validation-for=""Password"" class=""text-danger""></span>
                            <input asp-for=""Password"" class=""form-control"" placeholder=""Şifre"">
                       ");
            WriteLiteral(@" </div>

                        <div class=""form-group input-group"">
                            <div class=""input-group-prepend"">
                                <span class=""input-group-text"">
                                    <i class=""fa fa-lock""></i>
                                </span>
                            </div>
                            <span asp-validation-for=""ConfirmPassword"" class=""text-danger""></span>
                            <input asp-for=""ConfirmPassword"" class=""form-control"" placeholder=""Şifre(Tekrar)"">
                        </div>

                        <div class=""form-group input-group"">
                            <div class=""input-group-prepend"">
                                <span class=""input-group-text"">
                                    <i class=""fa fa-paint-roller""></i>
                                </span>
                            </div>
                            <label");
            BeginWriteAttribute("asp-for", " asp-for=\"", 3382, "\"", 3403, 1);
#nullable restore
#line 67 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\AppUser\Register.cshtml"
WriteAttributeValue("", 3392, Model.Role, 3392, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></label>
                            <select asp-for=""Input.Role"" class=""form-control"">
                                <option selected value=""1"">Visitor</option>
                                <option value=""2"">Chef</option>
                                <option value=""2"">Waiter</option>
                                <option value=""2"">WarehouseAttendant</option>
                                <option value=""2"">Admin</option>
                            </select>
                            <span asp-validation-for=""Input.Role"" class=""text-danger""></span>
                        </div>


                        <button type=""submit"">Kullanıcı Oluştur</button>

                    </form>

                </div>

            </div>

        </div>
   
</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebUI.Models.ViewModels.RegisterVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
