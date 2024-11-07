#pragma checksum "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Areas\Writer\Views\Default\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7f6233418936090f39e0729afab0218305e8fe84be29cad6bb92df338a601624"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Default_Index), @"mvc.1.0.view", @"/Areas/Writer/Views/Default/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
using EntityLater.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"7f6233418936090f39e0729afab0218305e8fe84be29cad6bb92df338a601624", @"/Areas/Writer/Views/Default/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"bedd53a138b069785550fa10c8b08d3652affa513a594c43af8203f4666e40ff", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Writer_Views_Default_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Announcement>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
  
    string color="";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Duyurular</h4>
        
            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Başlık.</th>
                            <th>Tarih</th>
                            <th>Tür</th>
                            <th>Detaylar</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 28 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
                         foreach(var item in Model){
                            if(item.Status=="Yeni Yazı")
                            {
                                color = "badge badge-info";
                            }
                            if (item.Status == "Yeni Proje")
                            {
                                color = "badge badge-warning";
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                            <td>");
#nullable restore
#line 38 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
                           Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 39 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 40 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
                            Write(((DateTime)item.Date).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><label");
            BeginWriteAttribute("class", " class=\"", 1479, "\"", 1493, 1);
#nullable restore
#line 41 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
WriteAttributeValue("", 1487, color, 1487, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 41 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
                                                 Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1560, "\"", 1611, 2);
            WriteAttributeValue("", 1567, "/Writer/Default/AnnouncementDetails/", 1567, 36, true);
#nullable restore
#line 42 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
WriteAttributeValue("", 1603, item.ID, 1603, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\">Detaylar</a></td>\r\n                        </tr>\r\n");
#nullable restore
#line 44 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                     \r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Announcement>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591