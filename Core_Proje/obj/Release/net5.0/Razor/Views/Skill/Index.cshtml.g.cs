#pragma checksum "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Skill\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "24bab23c1301ccc5c92af6e32576b4d26f95e27793eaef274baec96fc83800e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Skill_Index), @"mvc.1.0.view", @"/Views/Skill/Index.cshtml")]
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
#line 1 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
using EntityLater.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"24bab23c1301ccc5c92af6e32576b4d26f95e27793eaef274baec96fc83800e5", @"/Views/Skill/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6ce2767b5e9aacf9218c5ea7d9b3dff0f71adde816b8961150960e416b571dcd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Skill_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Skills>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
  
	ViewData["Title"] = "Index";
	Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Light table -->
<div class=""table-responsive"">
	<table class=""table align-items-center table-flush"">
		<thead class=""thead-light"">
			<tr>
				<th scope=""col"" class=""sort"" data-sort=""name"">#</th>
				<th scope=""col"" class=""sort"" data-sort=""budget"">Başlık</th>
				<th scope=""col"" class=""sort"" data-sort=""status"">Oran</th>
				<th scope=""col"">Sil</th>
				<th scope=""col"" class=""sort"" data-sort=""completion"">Düzenle</th>
				<th scope=""col""></th>
			</tr>
		</thead>
		<tbody class=""list"">

");
#nullable restore
#line 22 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
    foreach (var item in Model)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<tr>\r\n\t\t\t\t\t<th>\r\n\t\t\t\t\t\t");
#nullable restore
#line 26 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
 Write(item.SkillID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</th>\r\n\t\t\t\t\t<td class=\"budget\">\r\n\t\t\t\t\t\t");
#nullable restore
#line 29 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
 Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</td>\r\n\r\n\t\t\t\t\t<td>\r\n\t\t\t\t\t\t<div class=\"d-flex align-items-center\">\r\n\t\t\t\t\t\t\t<span class=\"completion mr-2\">");
#nullable restore
#line 34 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
                                Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n\t\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t\t<div class=\"progress\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"progress-bar bg-success\" role=\"progressbar\"");
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 1028, "\"", 1056, 2);
#nullable restore
#line 37 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
WriteAttributeValue("", 1044, item.Value, 1044, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1055, "%", 1055, 1, true);
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\"\r\n\t\t\t\t\t\t\t\t\t\t aria-valuemax=\"100\"");
            BeginWriteAttribute("style", " style=\"", 1107, "\"", 1134, 3);
            WriteAttributeValue("", 1115, "width:", 1115, 6, true);
#nullable restore
#line 38 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
WriteAttributeValue(" ", 1121, item.Value, 1122, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1133, "%", 1133, 1, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</td>\r\n\t\t\t\t\t<td><a");
            BeginWriteAttribute("href", " href=\"", 1212, "\"", 1251, 2);
            WriteAttributeValue("", 1219, "/Skill/DeleteSkill/", 1219, 19, true);
#nullable restore
#line 43 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
WriteAttributeValue("", 1238, item.SkillID, 1238, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a> </td>\r\n\t\t\t\t\t<td><a");
            BeginWriteAttribute("href", " href=\"", 1302, "\"", 1339, 2);
            WriteAttributeValue("", 1309, "/Skill/EditSkill/", 1309, 17, true);
#nullable restore
#line 44 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
WriteAttributeValue("", 1326, item.SkillID, 1326, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-light\">Düzenle</a> </td>\r\n\t\t\t\t</tr>\r\n");
#nullable restore
#line 46 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</tbody>\r\n\t</table>\r\n\t<br />\r\n\r\n\t<a href=\"/Skill/AddSkill/\" class=\"btn btn-primary\">Yetenek Ekle</a>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Skills>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591