#pragma checksum "D:\d drive\MY PROFILE\Projects\C#\Online Commodity Application\Ecom_Project\Ecom_Project\Views\Checkout\OrderHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4dab1fcfcc7b5091490e6a02a822066e528a5540"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout_OrderHistory), @"mvc.1.0.view", @"/Views/Checkout/OrderHistory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4dab1fcfcc7b5091490e6a02a822066e528a5540", @"/Views/Checkout/OrderHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d64a082a019ece1ab17188e1aee5d33b6830259b", @"/Views/_ViewImports.cshtml")]
    public class Views_Checkout_OrderHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Ecom_Project.Models.OrderDetail>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\d drive\MY PROFILE\Projects\C#\Online Commodity Application\Ecom_Project\Ecom_Project\Views\Checkout\OrderHistory.cshtml"
  
    ViewData["Title"] = "OrderDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h3>Previous Order History</h3>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "D:\d drive\MY PROFILE\Projects\C#\Online Commodity Application\Ecom_Project\Ecom_Project\Views\Checkout\OrderHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.Item));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "D:\d drive\MY PROFILE\Projects\C#\Online Commodity Application\Ecom_Project\Ecom_Project\Views\Checkout\OrderHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\d drive\MY PROFILE\Projects\C#\Online Commodity Application\Ecom_Project\Ecom_Project\Views\Checkout\OrderHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.unitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "D:\d drive\MY PROFILE\Projects\C#\Online Commodity Application\Ecom_Project\Ecom_Project\Views\Checkout\OrderHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.Order.OrderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "D:\d drive\MY PROFILE\Projects\C#\Online Commodity Application\Ecom_Project\Ecom_Project\Views\Checkout\OrderHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.Order.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 30 "D:\d drive\MY PROFILE\Projects\C#\Online Commodity Application\Ecom_Project\Ecom_Project\Views\Checkout\OrderHistory.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 34 "D:\d drive\MY PROFILE\Projects\C#\Online Commodity Application\Ecom_Project\Ecom_Project\Views\Checkout\OrderHistory.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 37 "D:\d drive\MY PROFILE\Projects\C#\Online Commodity Application\Ecom_Project\Ecom_Project\Views\Checkout\OrderHistory.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 40 "D:\d drive\MY PROFILE\Projects\C#\Online Commodity Application\Ecom_Project\Ecom_Project\Views\Checkout\OrderHistory.cshtml"
                   Write(Html.DisplayFor(modelItem => item.unitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 44 "D:\d drive\MY PROFILE\Projects\C#\Online Commodity Application\Ecom_Project\Ecom_Project\Views\Checkout\OrderHistory.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Order.OrderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 47 "D:\d drive\MY PROFILE\Projects\C#\Online Commodity Application\Ecom_Project\Ecom_Project\Views\Checkout\OrderHistory.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Order.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 51 "D:\d drive\MY PROFILE\Projects\C#\Online Commodity Application\Ecom_Project\Ecom_Project\Views\Checkout\OrderHistory.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Ecom_Project.Models.OrderDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
