#pragma checksum "C:\Users\fatih\source\repos\TraversalCore\TraversalCore.Mvc\Areas\Admin\Views\Destination\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc495592b571639d47cffdf0de8b49d08144acd1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Destination_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Destination/Index.cshtml")]
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
#line 1 "C:\Users\fatih\source\repos\TraversalCore\TraversalCore.Mvc\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCore.Entity.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc495592b571639d47cffdf0de8b49d08144acd1", @"/Areas/Admin/Views/Destination/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ed9da65a21ed06c81ca50f8008c81b31399a43e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Destination_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Destination>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\fatih\source\repos\TraversalCore\TraversalCore.Mvc\Areas\Admin\Views\Destination\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Tur Rotaları</h1>

<table class=""table table-bordered table-striped"">
   <thead>
      <tr>
          <th>#</th>
          <th>Şehir</th>
          <th>Fiyat</th>
          <th>Kapasite</th>
          <th>Sitede Gör</th>
          <th>Sil</th>
          <th>Güncelle</th>
      </tr>
");
#nullable restore
#line 21 "C:\Users\fatih\source\repos\TraversalCore\TraversalCore.Mvc\Areas\Admin\Views\Destination\Index.cshtml"
       foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 24 "C:\Users\fatih\source\repos\TraversalCore\TraversalCore.Mvc\Areas\Admin\Views\Destination\Index.cshtml"
               Write(item.DestinationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\fatih\source\repos\TraversalCore\TraversalCore.Mvc\Areas\Admin\Views\Destination\Index.cshtml"
               Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\fatih\source\repos\TraversalCore\TraversalCore.Mvc\Areas\Admin\Views\Destination\Index.cshtml"
               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\fatih\source\repos\TraversalCore\TraversalCore.Mvc\Areas\Admin\Views\Destination\Index.cshtml"
               Write(item.Capacity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 682, "\"", 740, 2);
            WriteAttributeValue("", 689, "/Destination/DestinationDetails/", 689, 32, true);
#nullable restore
#line 28 "C:\Users\fatih\source\repos\TraversalCore\TraversalCore.Mvc\Areas\Admin\Views\Destination\Index.cshtml"
WriteAttributeValue("", 721, item.DestinationId, 721, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Sitede Gör</a></td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 814, "\"", 877, 2);
            WriteAttributeValue("", 821, "/Admin/Destination/DeleteDestination/", 821, 37, true);
#nullable restore
#line 29 "C:\Users\fatih\source\repos\TraversalCore\TraversalCore.Mvc\Areas\Admin\Views\Destination\Index.cshtml"
WriteAttributeValue("", 858, item.DestinationId, 858, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 946, "\"", 1009, 2);
            WriteAttributeValue("", 953, "/Admin/Destination/UpdateDestination/", 953, 37, true);
#nullable restore
#line 30 "C:\Users\fatih\source\repos\TraversalCore\TraversalCore.Mvc\Areas\Admin\Views\Destination\Index.cshtml"
WriteAttributeValue("", 990, item.DestinationId, 990, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a></td>\r\n                \r\n            </tr>\n");
#nullable restore
#line 33 "C:\Users\fatih\source\repos\TraversalCore\TraversalCore.Mvc\Areas\Admin\Views\Destination\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("   </thead>\r\n</table>\r\n\r\n<a  href=\"/Admin/Destination/AddDestination\" class=\"btn btn-outline-primary\"> Yeni Tur Rotası </a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Destination>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
