#pragma checksum "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Areas\Admin\Views\User\ReservationUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "660e321c9c744f023657960624482751337a8eed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_ReservationUser), @"mvc.1.0.view", @"/Areas/Admin/Views/User/ReservationUser.cshtml")]
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
#nullable restore
#line 1 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCore.Entity.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCore.DTOs.AnnouncementDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCore.Mvc.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCore.Mvc.CQRS.Results.DestinationResults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCore.Mvc.CQRS.Commands.DestinationCommands;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCore.Mvc.CQRS.Results.GuideResults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCore.Mvc.CQRS.Commands.GuideCommands;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"660e321c9c744f023657960624482751337a8eed", @"/Areas/Admin/Views/User/ReservationUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"835cf37a47e6333c61750767958262e0331d33c2", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_User_ReservationUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Reservation>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Areas\Admin\Views\User\ReservationUser.cshtml"
  
    ViewData["Title"] = "ReservationUser";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Kullanıcının Geçmiş Rezervasyonları </h1>

<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Misafir Ad Soyad</th>
        <th>Rota</th>
        <th>Kişi Sayısı</th>
        <th>Tarih</th>
        <th>Detaylar</th>
    </tr>
");
#nullable restore
#line 21 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Areas\Admin\Views\User\ReservationUser.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n");
#nullable restore
#line 24 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Areas\Admin\Views\User\ReservationUser.cshtml"
              count += 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 25 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Areas\Admin\Views\User\ReservationUser.cshtml"
           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>###</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Areas\Admin\Views\User\ReservationUser.cshtml"
           Write(item.Destination.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Areas\Admin\Views\User\ReservationUser.cshtml"
           Write(item.PersonCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Areas\Admin\Views\User\ReservationUser.cshtml"
            Write(((DateTime)item.ReservationDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a class=\"btn btn-outline-primary\">Detaylar</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 32 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Areas\Admin\Views\User\ReservationUser.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Reservation>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
