#pragma checksum "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\VisitorMap\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "d19336e929fe89f69d58c9745e337553528b621318a0e59fcf75e0bd805a3b34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_VisitorMap_Default), @"mvc.1.0.view", @"/Views/Shared/Components/VisitorMap/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"d19336e929fe89f69d58c9745e337553528b621318a0e59fcf75e0bd805a3b34", @"/Views/Shared/Components/VisitorMap/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6ce2767b5e9aacf9218c5ea7d9b3dff0f71adde816b8961150960e416b571dcd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_VisitorMap_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
	<div class=""col-12"">
		<div class=""card"">
			<div class=""card-body"">
				<h4 class=""card-title"">Ziyaret Edilen Ülkeler</h4>
				<div class=""row"">
					<div class=""col-md-5"">
						<div class=""table-responsive"">
							<table class=""table"">
								<tbody>
									<tr>
										<td>
											<i class=""flag-icon flag-icon-us""></i>
										</td>
										<td>ABD</td>
										<td class=""text-right""> 1500 </td>
										<td class=""text-right font-weight-medium""> 56.35% </td>
									</tr>
									<tr>
										<td>
											<i class=""flag-icon flag-icon-de""></i>
										</td>
										<td>ALMANYA</td>
										<td class=""text-right""> 800 </td>
										<td class=""text-right font-weight-medium""> 33.25% </td>
									</tr>
									<tr>
										<td>
											<i class=""flag-icon flag-icon-au""></i>
										</td>
										<td>AVUSTRALYA</td>
										<td class=""text-right""> 760 </td>
										<td class=""text-right font-weight-medium""> 15");
            WriteLiteral(@".45% </td>
									</tr>
									<tr>
										<td>
											<i class=""flag-icon flag-icon-gb""></i>
										</td>
										<td>İNGİLTERE</td>
										<td class=""text-right""> 450 </td>
										<td class=""text-right font-weight-medium""> 25.00% </td>
									</tr>
									<tr>
										<td>
											<i class=""flag-icon flag-icon-ro""></i>
										</td>
										<td>ROMANYA</td>
										<td class=""text-right""> 620 </td>
										<td class=""text-right font-weight-medium""> 10.25% </td>
									</tr>
									<tr>
										<td>
											<i class=""flag-icon flag-icon-br""></i>
										</td>
										<td>BREZİLYA</td>
										<td class=""text-right""> 230 </td>
										<td class=""text-right font-weight-medium""> 75.00% </td>
									</tr>
								</tbody>
							</table>
						</div>
					</div>
					<div class=""col-md-7"">
						<div id=""audience-map"" class=""vector-map""></div>
					</div>
				</div>
			</div>
		</div>
	</div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
