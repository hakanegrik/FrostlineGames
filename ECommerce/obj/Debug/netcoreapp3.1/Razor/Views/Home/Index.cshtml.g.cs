#pragma checksum "/Users/macbook/Projects/ECommerce/ECommerce/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b3543d9f92a7bba6b9e9353a098774868f7b834"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/macbook/Projects/ECommerce/ECommerce/Views/_ViewImports.cshtml"
using ECommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/macbook/Projects/ECommerce/ECommerce/Views/Home/Index.cshtml"
using ECommerce.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b3543d9f92a7bba6b9e9353a098774868f7b834", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89fb089828dd866504103bfaeb2b6e1f9939c572", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""btn btn-outline-primary"">

    <a href=""/Home/DiscountProducts/"" class=""btn-btn-warning"">İndirimli Ürünler </a>
</div>


<div class=""btn btn-outline-primary"">

    <a href=""/Admin/Index/"" class=""btn-btn-warning"">Admin Paneli</a>
</div>



<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">Id</th>
            <th scope=""col"">Name</th>
            <th scope=""col"">CategoryId</th>
            <th scope=""col"">Fiyat</th>
            <th scope=""col"">IsActive</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 29 "/Users/macbook/Projects/ECommerce/ECommerce/Views/Home/Index.cshtml"
         foreach (var item in Model.Product)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <th scope=\"row\">");
#nullable restore
#line 32 "/Users/macbook/Projects/ECommerce/ECommerce/Views/Home/Index.cshtml"
                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <td>");
#nullable restore
#line 33 "/Users/macbook/Projects/ECommerce/ECommerce/Views/Home/Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 34 "/Users/macbook/Projects/ECommerce/ECommerce/Views/Home/Index.cshtml"
           Write(item.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 35 "/Users/macbook/Projects/ECommerce/ECommerce/Views/Home/Index.cshtml"
           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 36 "/Users/macbook/Projects/ECommerce/ECommerce/Views/Home/Index.cshtml"
           Write(item.IsActive);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
#nullable restore
#line 38 "/Users/macbook/Projects/ECommerce/ECommerce/Views/Home/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </tbody>\n</table>\n\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
