#pragma checksum "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\StatisticsDashBoard2\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "dff2709aba99d1f72b1aa537cd29fd09545285a825060a2daf2d307afa292272"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_StatisticsDashBoard2_Default), @"mvc.1.0.view", @"/Views/Shared/Components/StatisticsDashBoard2/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"dff2709aba99d1f72b1aa537cd29fd09545285a825060a2daf2d307afa292272", @"/Views/Shared/Components/StatisticsDashBoard2/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6ce2767b5e9aacf9218c5ea7d9b3dff0f71adde816b8961150960e416b571dcd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_StatisticsDashBoard2_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-sm-4 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h5>Proje Sayısı</h5>
                <div class=""row"">
                    <div class=""col-8 col-sm-12 col-xl-8 my-auto"">
                        <div class=""d-flex d-sm-block d-md-flex align-items-center"">
                            <h2 class=""mb-0"">");
#nullable restore
#line 10 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\StatisticsDashBoard2\Default.cshtml"
                                        Write(ViewBag.v1);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                            <p class=""text-success ml-2 mb-0 font-weight-medium"">+3.5%</p>
                        </div>
                        <h6 class=""text-muted font-weight-normal"">Tamamlanan Proje Sayısı</h6>
                    </div>
                    <div class=""col-4 col-sm-12 col-xl-4 text-center text-xl-right"">
                        <i class=""icon-lg mdi mdi-codepen text-primary ml-auto""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-sm-4 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h5>Mesaj Sayısı</h5>
                <div class=""row"">
                    <div class=""col-8 col-sm-12 col-xl-8 my-auto"">
                        <div class=""d-flex d-sm-block d-md-flex align-items-center"">
                            <h2 class=""mb-0"">$45850</h2>
                            <p class=""text-success ml-2 mb-0 font-weight-medium"">");
#nullable restore
#line 30 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\StatisticsDashBoard2\Default.cshtml"
                                                                            Write(ViewBag.v2);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div>
                        <h6 class=""text-muted font-weight-normal"">Toplam Mesaj Sayısı</h6>
                    </div>
                    <div class=""col-4 col-sm-12 col-xl-4 text-center text-xl-right"">
                        <i class=""icon-lg mdi mdi-wallet-travel text-danger ml-auto""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-sm-4 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h5>Hizmetler</h5>
                <div class=""row"">
                    <div class=""col-8 col-sm-12 col-xl-8 my-auto"">
                        <div class=""d-flex d-sm-block d-md-flex align-items-center"">
                            <h2 class=""mb-0"">");
#nullable restore
#line 48 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\StatisticsDashBoard2\Default.cshtml"
                                        Write(ViewBag.v3);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                            <p class=""text-danger ml-2 mb-0 font-weight-medium"">-2.1% </p>
                        </div>
                        <h6 class=""text-muted font-weight-normal"">Verilen Hizmet Sayısı</h6>
                    </div>
                    <div class=""col-4 col-sm-12 col-xl-4 text-center text-xl-right"">
                        <i class=""icon-lg mdi mdi-monitor text-success ml-auto""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
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
