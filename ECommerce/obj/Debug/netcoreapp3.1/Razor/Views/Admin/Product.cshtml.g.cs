#pragma checksum "/Users/macbook/Projects/ECommerce/ECommerce/Views/Admin/Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6ac5f92add3ffb8418728d9dc7a5ec23936fd1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Product), @"mvc.1.0.view", @"/Views/Admin/Product.cshtml")]
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
#line 1 "/Users/macbook/Projects/ECommerce/ECommerce/Views/Admin/Product.cshtml"
using ECommerce.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6ac5f92add3ffb8418728d9dc7a5ec23936fd1b", @"/Views/Admin/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89fb089828dd866504103bfaeb2b6e1f9939c572", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"




<div class=""btn btn-outline-primary"">

    <a href=""/Admin/CreateProduct/"" class=""btn-btn-warning"">Create Product</a>
</div>

<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">Id</th>
            <th scope=""col"">Name</th>
            <th scope=""col"">Price</th>
            <th scope=""col"">CategoryId</th>
            <th scope=""col"">IsActive</th>
            <th scope=""col"">Transactions</th>

        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 26 "/Users/macbook/Projects/ECommerce/ECommerce/Views/Admin/Product.cshtml"
         foreach (var item in Model.Product)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <th scope=\"row\">");
#nullable restore
#line 29 "/Users/macbook/Projects/ECommerce/ECommerce/Views/Admin/Product.cshtml"
                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <td>");
#nullable restore
#line 30 "/Users/macbook/Projects/ECommerce/ECommerce/Views/Admin/Product.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 31 "/Users/macbook/Projects/ECommerce/ECommerce/Views/Admin/Product.cshtml"
               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 32 "/Users/macbook/Projects/ECommerce/ECommerce/Views/Admin/Product.cshtml"
               Write(item.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 33 "/Users/macbook/Projects/ECommerce/ECommerce/Views/Admin/Product.cshtml"
               Write(item.IsActive);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 799, "\"", 833, 2);
            WriteAttributeValue("", 806, "/Admin/EditProduct/", 806, 19, true);
#nullable restore
#line 34 "/Users/macbook/Projects/ECommerce/ECommerce/Views/Admin/Product.cshtml"
WriteAttributeValue("", 825, item.Id, 825, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-btn-warning\">Edit</a></td>\n            </tr>\n");
#nullable restore
#line 36 "/Users/macbook/Projects/ECommerce/ECommerce/Views/Admin/Product.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </tbody>\n</table>\n\n");
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
