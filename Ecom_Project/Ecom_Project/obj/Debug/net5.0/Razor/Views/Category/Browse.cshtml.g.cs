#pragma checksum "D:\d drive\MY PROFILE\Projects\C#\Online Commodity Application\Ecom_Project\Ecom_Project\Views\Category\Browse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42b51acf38363212b1add122cac78fb14a54ba51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Browse), @"mvc.1.0.view", @"/Views/Category/Browse.cshtml")]
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
#line 1 "D:\d drive\MY PROFILE\Projects\C#\Online Commodity Application\Ecom_Project\Ecom_Project\Views\_ViewImports.cshtml"
using Ecom_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\d drive\MY PROFILE\Projects\C#\Online Commodity Application\Ecom_Project\Ecom_Project\Views\_ViewImports.cshtml"
using Ecom_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42b51acf38363212b1add122cac78fb14a54ba51", @"/Views/Category/Browse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d64a082a019ece1ab17188e1aee5d33b6830259b", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Browse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Ecom_Project.Models.Item>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("250"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\d drive\MY PROFILE\Projects\C#\Online Commodity Application\Ecom_Project\Ecom_Project\Views\Category\Browse.cshtml"
  
    ViewData["Title"] = "Browse";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Browse: ");
#nullable restore
#line 7 "D:\d drive\MY PROFILE\Projects\C#\Online Commodity Application\Ecom_Project\Ecom_Project\Views\Category\Browse.cshtml"
       Write(ViewBag.categoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<div class=\"row ml-3\">\r\n");
#nullable restore
#line 9 "D:\d drive\MY PROFILE\Projects\C#\Online Commodity Application\Ecom_Project\Ecom_Project\Views\Category\Browse.cshtml"
     foreach (var item in Model)
    {
        if (item.CategoryId == ViewBag.id)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card ml-5 shadow-lg p-3 mb-5 bg-white rounded\" style=\"        width: 18rem; margin-top: 10vh;\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "42b51acf38363212b1add122cac78fb14a54ba515670", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 383, "~/Images/", 383, 9, true);
#nullable restore
#line 14 "D:\d drive\MY PROFILE\Projects\C#\Online Commodity Application\Ecom_Project\Ecom_Project\Views\Category\Browse.cshtml"
AddHtmlAttributeValue("", 392, item.itemURl, 392, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">");
#nullable restore
#line 16 "D:\d drive\MY PROFILE\Projects\C#\Online Commodity Application\Ecom_Project\Ecom_Project\Views\Category\Browse.cshtml"
                              Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <p class=\"card-text\"><strong>Price: </strong>");
#nullable restore
#line 17 "D:\d drive\MY PROFILE\Projects\C#\Online Commodity Application\Ecom_Project\Ecom_Project\Views\Category\Browse.cshtml"
                                                    Write(item.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <a class=\"btn btn-warning\"");
            BeginWriteAttribute("href", " href=\"", 663, "\"", 728, 1);
#nullable restore
#line 18 "D:\d drive\MY PROFILE\Projects\C#\Online Commodity Application\Ecom_Project\Ecom_Project\Views\Category\Browse.cshtml"
WriteAttributeValue("", 670, Url.Action("Details","Category",new { id = item.ItemId }), 670, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">View Details </a>\r\n\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 22 "D:\d drive\MY PROFILE\Projects\C#\Online Commodity Application\Ecom_Project\Ecom_Project\Views\Category\Browse.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<hr />\r\n<div class=\"mt-5\">\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 839, "\"", 903, 1);
#nullable restore
#line 27 "D:\d drive\MY PROFILE\Projects\C#\Online Commodity Application\Ecom_Project\Ecom_Project\Views\Category\Browse.cshtml"
WriteAttributeValue("", 846, Url.Action("Index",new { category=ViewBag.categoryName}), 846, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Ecom_Project.Models.Item>> Html { get; private set; }
    }
}
#pragma warning restore 1591
