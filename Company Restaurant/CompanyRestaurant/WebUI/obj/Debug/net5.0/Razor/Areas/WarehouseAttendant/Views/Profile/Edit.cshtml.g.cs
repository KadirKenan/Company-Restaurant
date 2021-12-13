#pragma checksum "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\WarehouseAttendant\Views\Profile\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f482c9c9977b258cd8dff91d356f031c1c8b022f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_WarehouseAttendant_Views_Profile_Edit), @"mvc.1.0.view", @"/Areas/WarehouseAttendant/Views/Profile/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f482c9c9977b258cd8dff91d356f031c1c8b022f", @"/Areas/WarehouseAttendant/Views/Profile/Edit.cshtml")]
    public class Areas_WarehouseAttendant_Views_Profile_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataAccess.Entity.Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\WarehouseAttendant\Views\Profile\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Areas/WarehouseAttendant/Views/Shared/_WarehouseAttendantLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main class=""body-content"">


    <div class=""ms-panel-body"">
        <form asp-action=""Edit"" method=""POST"">
            <div class=""form-row"">
                <div class=""col-md-12 mb-3"">
                    <label asp-for=""IdentityNo"">Kimlik Numarası</label>
                    ");
#nullable restore
#line 15 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\WarehouseAttendant\Views\Profile\Edit.cshtml"
               Write(Html.TextBoxFor(x => x.IdentityNo, new { @class = "form-control", type = "text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-12 mb-3\">\r\n                    <label asp-for=\"FirstName\">Personel Adı</label>\r\n                    ");
#nullable restore
#line 19 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\WarehouseAttendant\Views\Profile\Edit.cshtml"
               Write(Html.TextBoxFor(x => x.FirstName, new { @class = "form-control", type = "text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-12 mb-3\">\r\n                    <label asp-for=\"LastName\">Personel Soyadı</label>\r\n                    ");
#nullable restore
#line 23 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\WarehouseAttendant\Views\Profile\Edit.cshtml"
               Write(Html.TextBoxFor(x => x.LastName, new { @class = "form-control", type = "text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n\r\n                <div class=\"col-md-12 mb-3\">\r\n                    <label asp-for=\"BirthDate\">Doğum Tarihi</label>\r\n                    ");
#nullable restore
#line 29 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\WarehouseAttendant\Views\Profile\Edit.cshtml"
               Write(Html.TextBoxFor(x => x.BirthDate.Date, new { @class = "form-control", type = "datetime" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                </div>\r\n                <div class=\"col-md-12 mb-3\">\r\n                    <label asp-for=\"HomePhone\">Telefon Numarası</label>\r\n                    ");
#nullable restore
#line 35 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\WarehouseAttendant\Views\Profile\Edit.cshtml"
               Write(Html.TextBoxFor(x => x.HomePhone, new { @class = "form-control", type = "text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-12 mb-3\">\r\n                    <label asp-for=\"Email\">Mail Adres</label>\r\n                    ");
#nullable restore
#line 39 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\WarehouseAttendant\Views\Profile\Edit.cshtml"
               Write(Html.TextBoxFor(x => x.Email, new { @class = "form-control", type = "text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-12 mb-3\">\r\n                    <label asp-for=\"Adress\">Adres</label>\r\n                    ");
#nullable restore
#line 43 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\WarehouseAttendant\Views\Profile\Edit.cshtml"
               Write(Html.TextBoxFor(x => x.Adress, new { @class = "form-control", type = "text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-12 mb-3\">\r\n                    <label asp-for=\"Country\">Ülke</label>\r\n                    ");
#nullable restore
#line 47 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\WarehouseAttendant\Views\Profile\Edit.cshtml"
               Write(Html.TextBoxFor(x => x.Country, new { @class = "form-control", type = "text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-12 mb-3\">\r\n                    <label asp-for=\"City\">Şehir</label>\r\n                    ");
#nullable restore
#line 51 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\WarehouseAttendant\Views\Profile\Edit.cshtml"
               Write(Html.TextBoxFor(x => x.City, new { @class = "form-control", type = "text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-12 mb-3\">\r\n                    <label asp-for=\"PostalCode\">Posta Kodu</label>\r\n                    ");
#nullable restore
#line 55 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\WarehouseAttendant\Views\Profile\Edit.cshtml"
               Write(Html.TextBoxFor(x => x.PostalCode, new { @class = "form-control", type = "text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-12 mb-3\">\r\n                    <label asp-for=\"Picture\">Personel Fotoğrafı</label>\r\n                    <div class=\"custom-file\">\r\n\r\n                        ");
#nullable restore
#line 61 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\WarehouseAttendant\Views\Profile\Edit.cshtml"
                   Write(Html.TextBoxFor(x => x.Photo, new { @class = "form-control", type = "file" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </div>\r\n                </div>\r\n                <button class=\"btn btn-primary float-end\" type=\"submit\">Güncelle</button>\r\n\r\n            </div>\r\n        </form>\r\n\r\n    </div>\r\n\r\n</main>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataAccess.Entity.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
