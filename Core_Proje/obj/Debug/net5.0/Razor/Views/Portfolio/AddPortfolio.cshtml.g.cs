#pragma checksum "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Portfolio\AddPortfolio.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f8293577dc94325f48c863318064086faa7ab62f0be2811c490feef88fe340c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Portfolio_AddPortfolio), @"mvc.1.0.view", @"/Views/Portfolio/AddPortfolio.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"f8293577dc94325f48c863318064086faa7ab62f0be2811c490feef88fe340c7", @"/Views/Portfolio/AddPortfolio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6ce2767b5e9aacf9218c5ea7d9b3dff0f71adde816b8961150960e416b571dcd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Portfolio_AddPortfolio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLater.Concrete.Portfolios>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forms-sample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
  
	ViewData["Title"] = "AddPortfolio";
	Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
 using (Html.BeginForm("AddPortfolio", "Portfolio", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\"col-12 grid-margin stretch-card\">\r\n\t\t<div class=\"card\">\r\n\t\t\t<div class=\"card-body\">\r\n\r\n\t\t\t\t<b> <h3 class=\"card-description\"> Yeni Proje Ekleme Paneli </h3></b>\r\n\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8293577dc94325f48c863318064086faa7ab62f0be2811c490feef88fe340c74554", async() => {
                WriteLiteral("\r\n\t\t\t\t\t<b> ");
#nullable restore
#line 15 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
    Write(Html.Label("Proje Başlığı"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</b>\r\n\t\t\t\t\t");
#nullable restore
#line 16 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t");
#nullable restore
#line 17 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.ValidationMessageFor(x => x.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t<br />\r\n\t\t\t\t\t<label><strong>Görsel 1</strong></label>\r\n\t\t\t\t\t");
#nullable restore
#line 20 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.TextBoxFor(x => x.ImageUrl, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t");
#nullable restore
#line 21 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.ValidationMessageFor(x => x.ImageUrl));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t<br />\r\n\r\n\t\t\t\t\t<label><strong>Görsel2</strong></label>\r\n\t\t\t\t\t");
#nullable restore
#line 25 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.TextBoxFor(x => x.ImageUrl2, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t");
#nullable restore
#line 26 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.ValidationMessageFor(x => x.ImageUrl2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t<br />\r\n\r\n\t\t\t\t\t<label><strong>Proje Url</strong></label>\r\n\t\t\t\t\t");
#nullable restore
#line 30 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.TextBoxFor(x => x.ProjectUrl, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t");
#nullable restore
#line 31 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.ValidationMessageFor(x => x.ProjectUrl));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t<br />\r\n\r\n\t\t\t\t\t<label><strong>Fiyat</strong></label>\r\n\t\t\t\t\t");
#nullable restore
#line 35 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.TextBoxFor(x => x.Price, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t");
#nullable restore
#line 36 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.ValidationMessageFor(x => x.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t<br />\r\n\r\n\t\t\t\t\t<label><strong>Tamamlanma Oranı</strong></label>\r\n\t\t\t\t\t");
#nullable restore
#line 40 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.TextBoxFor(x => x.Value, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t");
#nullable restore
#line 41 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.ValidationMessageFor(x => x.Value));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t<br />\r\n\r\n\t\t\t\t\t<button class=\"btn btn-success\">Kaydet</button>\r\n\r\n\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n");
#nullable restore
#line 50 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLater.Concrete.Portfolios> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
