#pragma checksum "C:\Users\shukuma\learn\Programming\C#\AspNetCoreFundamentals\OdeToFood\OdeToFood\Pages\Restaurants\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edecec8af6f32bc70f4d9c23810c431ff1866016"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OdeToFood.Pages.Restaurants.Pages_Restaurants_List), @"mvc.1.0.razor-page", @"/Pages/Restaurants/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Restaurants/List.cshtml", typeof(OdeToFood.Pages.Restaurants.Pages_Restaurants_List), null)]
namespace OdeToFood.Pages.Restaurants
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\shukuma\learn\Programming\C#\AspNetCoreFundamentals\OdeToFood\OdeToFood\Pages\_ViewImports.cshtml"
using OdeToFood;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edecec8af6f32bc70f4d9c23810c431ff1866016", @"/Pages/Restaurants/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0820fb6dbe507f6ce740cdfd07cdc5236e4275df", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Restaurants_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 51, true);
            WriteLiteral("\r\n<h1>Restaurants</h1>  \r\n\r\n<table class=\"table\">\r\n");
            EndContext();
#line 9 "C:\Users\shukuma\learn\Programming\C#\AspNetCoreFundamentals\OdeToFood\OdeToFood\Pages\Restaurants\List.cshtml"
     foreach(var restaurant in Model.Restaurants)
    {

#line default
#line hidden
            BeginContext(141, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(172, 15, false);
#line 12 "C:\Users\shukuma\learn\Programming\C#\AspNetCoreFundamentals\OdeToFood\OdeToFood\Pages\Restaurants\List.cshtml"
           Write(restaurant.Name);

#line default
#line hidden
            EndContext();
            BeginContext(187, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(211, 19, false);
#line 13 "C:\Users\shukuma\learn\Programming\C#\AspNetCoreFundamentals\OdeToFood\OdeToFood\Pages\Restaurants\List.cshtml"
           Write(restaurant.Location);

#line default
#line hidden
            EndContext();
            BeginContext(230, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(254, 18, false);
#line 14 "C:\Users\shukuma\learn\Programming\C#\AspNetCoreFundamentals\OdeToFood\OdeToFood\Pages\Restaurants\List.cshtml"
           Write(restaurant.Cuisine);

#line default
#line hidden
            EndContext();
            BeginContext(272, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 16 "C:\Users\shukuma\learn\Programming\C#\AspNetCoreFundamentals\OdeToFood\OdeToFood\Pages\Restaurants\List.cshtml"
    }

#line default
#line hidden
            BeginContext(301, 19, true);
            WriteLiteral("</table>\r\n\r\n\r\n<div>");
            EndContext();
            BeginContext(321, 13, false);
#line 20 "C:\Users\shukuma\learn\Programming\C#\AspNetCoreFundamentals\OdeToFood\OdeToFood\Pages\Restaurants\List.cshtml"
Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(334, 8, true);
            WriteLiteral("</div>  ");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ListModel>)PageContext?.ViewData;
        public ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591