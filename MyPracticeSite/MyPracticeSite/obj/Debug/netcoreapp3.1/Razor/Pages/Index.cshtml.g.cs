#pragma checksum "D:\Documents\Code\MyPracticeSite\MyPracticeSite\MyPracticeSite\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37c680d216c6b67897162fdebc6eb33bab422d62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyPracticeSite.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace MyPracticeSite.Pages
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
#line 1 "D:\Documents\Code\MyPracticeSite\MyPracticeSite\MyPracticeSite\Pages\_ViewImports.cshtml"
using MyPracticeSite;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37c680d216c6b67897162fdebc6eb33bab422d62", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e7b84c2e8cadf9c1ca45ee7e14727c91c95a4e4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Documents\Code\MyPracticeSite\MyPracticeSite\MyPracticeSite\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37c680d216c6b67897162fdebc6eb33bab422d623101", async() => {
                WriteLiteral("\r\n        <link href=\"https://fonts.googleapis.com/css?family=Press+Start+2P&display=swap\" rel=\"stylesheet\">\r\n        <link href=\"https://fonts.googleapis.com/css?family=Fascinate&display=swap\" rel=\"stylesheet\">\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">This Is A Practice Website</h1>\r\n    <p>This Project\'s <a href=\"https://github.com/thelastphysician/MyPracticeSite\">Github</a>.</p>\r\n</div>\r\n\r\n<div class=\"card-columns\">\r\n");
#nullable restore
#line 17 "D:\Documents\Code\MyPracticeSite\MyPracticeSite\MyPracticeSite\Pages\Index.cshtml"
 foreach (var product in Model.Products)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <a href =\"/ProductPage\">\r\n        \r\n        <div class=\"card\">\r\n");
#nullable restore
#line 23 "D:\Documents\Code\MyPracticeSite\MyPracticeSite\MyPracticeSite\Pages\Index.cshtml"
              
                var ret = product.AvrRatings;
                if (ret == -1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h5 class=\"card-rating\"> No Rating</h5>\r\n");
#nullable restore
#line 28 "D:\Documents\Code\MyPracticeSite\MyPracticeSite\MyPracticeSite\Pages\Index.cshtml"
                }
                else
                {
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h5 class=\"card-rating\"> ");
#nullable restore
#line 35 "D:\Documents\Code\MyPracticeSite\MyPracticeSite\MyPracticeSite\Pages\Index.cshtml"
                                        Write(ret);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n");
#nullable restore
#line 36 "D:\Documents\Code\MyPracticeSite\MyPracticeSite\MyPracticeSite\Pages\Index.cshtml"
                }

            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card-img\"");
            BeginWriteAttribute("style", " style=\"", 1156, "\"", 1203, 3);
            WriteAttributeValue("", 1164, "background-image:url(\'", 1164, 22, true);
#nullable restore
#line 39 "D:\Documents\Code\MyPracticeSite\MyPracticeSite\MyPracticeSite\Pages\Index.cshtml"
WriteAttributeValue("", 1186, product.Image, 1186, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1200, "\');", 1200, 3, true);
            EndWriteAttribute();
            WriteLiteral("> </div>\r\n            <div class=\"card-body\">\r\n\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 42 "D:\Documents\Code\MyPracticeSite\MyPracticeSite\MyPracticeSite\Pages\Index.cshtml"
                                  Write(product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n\r\n\r\n\r\n                <! –– and the comment closes with ––>\r\n            </div>\r\n\r\n\r\n        </div>\r\n        </a>\r\n");
#nullable restore
#line 53 "D:\Documents\Code\MyPracticeSite\MyPracticeSite\MyPracticeSite\Pages\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
