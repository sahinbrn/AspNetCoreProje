#pragma checksum "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\testimonial\EditTestimonial.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a71d48f42d5abac5193220d5413518b283206e8e7a0882671fcabeda1586129e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_testimonial_EditTestimonial), @"mvc.1.0.view", @"/Views/testimonial/EditTestimonial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a71d48f42d5abac5193220d5413518b283206e8e7a0882671fcabeda1586129e", @"/Views/testimonial/EditTestimonial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6ce2767b5e9aacf9218c5ea7d9b3dff0f71adde816b8961150960e416b571dcd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_testimonial_EditTestimonial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLater.Concrete.Testimonials>
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
#line 2 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\testimonial\EditTestimonial.cshtml"
  
    ViewData["Title"] = "EditTestimonial";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\testimonial\EditTestimonial.cshtml"
 using (Html.BeginForm("EditTestimonial", "Testimonial", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-12 grid-margin stretch-card\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n\r\n                <b> <h3 class=\"card-description\"> Proje Düzenleme Paneli </h3></b>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a71d48f42d5abac5193220d5413518b283206e8e7a0882671fcabeda1586129e4631", async() => {
                WriteLiteral("\r\n                    ");
#nullable restore
#line 15 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\testimonial\EditTestimonial.cshtml"
               Write(Html.HiddenFor(x => x.TestimonialID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <br />\r\n                    <b> ");
#nullable restore
#line 17 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\testimonial\EditTestimonial.cshtml"
                   Write(Html.Label("Ad Soyad"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</b>\r\n                    ");
#nullable restore
#line 18 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\testimonial\EditTestimonial.cshtml"
               Write(Html.TextBoxFor(x => x.ClientName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <br />\r\n                    <b> ");
#nullable restore
#line 20 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\testimonial\EditTestimonial.cshtml"
                   Write(Html.Label("Şirket"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</b>\r\n                    ");
#nullable restore
#line 21 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\testimonial\EditTestimonial.cshtml"
               Write(Html.TextBoxFor(x => x.Company, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <br />\r\n                    <b> ");
#nullable restore
#line 23 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\testimonial\EditTestimonial.cshtml"
                   Write(Html.Label("Unvan"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</b>\r\n                    ");
#nullable restore
#line 24 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\testimonial\EditTestimonial.cshtml"
               Write(Html.TextBoxFor(x => x.Title, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <br />\r\n                    <label><strong>Resim Yolu</strong></label>\r\n                    ");
#nullable restore
#line 27 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\testimonial\EditTestimonial.cshtml"
               Write(Html.TextBoxFor(x => x.ImageUrl, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <br />\r\n                    <b> ");
#nullable restore
#line 29 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\testimonial\EditTestimonial.cshtml"
                   Write(Html.Label("Değerlendirme"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</b>\r\n                    ");
#nullable restore
#line 30 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\testimonial\EditTestimonial.cshtml"
               Write(Html.TextAreaFor(x => x.Comment,8,3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <button type=\"submit\" class=\"btn btn-primary mr-2\">Kaydet</button>\r\n                ");
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
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 36 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\testimonial\EditTestimonial.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLater.Concrete.Testimonials> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
