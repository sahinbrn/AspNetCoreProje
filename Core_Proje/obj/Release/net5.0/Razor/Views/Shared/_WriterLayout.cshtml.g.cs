#pragma checksum "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Shared\_WriterLayout.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1725ae52b95a89b115e6832e897c28c587eaab135e9c4e4c26e0b05a2bf84022"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__WriterLayout), @"mvc.1.0.view", @"/Views/Shared/_WriterLayout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"1725ae52b95a89b115e6832e897c28c587eaab135e9c4e4c26e0b05a2bf84022", @"/Views/Shared/_WriterLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6ce2767b5e9aacf9218c5ea7d9b3dff0f71adde816b8961150960e416b571dcd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__WriterLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Shared\_WriterLayout.cshtml"
  
	Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
#nullable restore
#line 7 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Shared\_WriterLayout.cshtml"
Write(await Html.PartialAsync("/Areas/Writer/Views/Default/HeadPartial.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1725ae52b95a89b115e6832e897c28c587eaab135e9c4e4c26e0b05a2bf840223797", async() => {
                WriteLiteral("\r\n\t<div class=\"container-scroller\">\r\n\t\r\n\t\t");
#nullable restore
#line 12 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Shared\_WriterLayout.cshtml"
Write(await Html.PartialAsync("/Areas/Writer/Views/Default/NavBarPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\r\n\t\t<div class=\"container-fluid page-body-wrapper\">\r\n\t\t\r\n\t\t\t");
#nullable restore
#line 16 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Shared\_WriterLayout.cshtml"
Write(await Html.PartialAsync("/Areas/Writer/Views/Default/SideBarPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\r\n\t\t\t<div class=\"main-panel\">\r\n\t\t\t\t<div class=\"content-wrapper\">\r\n\t\t\t\t\t\r\n\t\t\t\t\t\t");
#nullable restore
#line 21 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Shared\_WriterLayout.cshtml"
 Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\t\t\t\t\r\n\t\t\t\t</div>\r\n\t\t\t\t");
#nullable restore
#line 25 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Shared\_WriterLayout.cshtml"
Write(await Html.PartialAsync("/Areas/Writer/Views/Default/FooterPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n\t");
#nullable restore
#line 29 "C:\Users\sahin\source\repos\Core_Proje\Core_Proje\Views\Shared\_WriterLayout.cshtml"
Write(await Html.PartialAsync("/Areas/Writer/Views/Default/ScriptsPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
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
