#pragma checksum "/Users/macbook/Projects/ECommerce/ECommerce/Views/Admin/EditDiscount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b868b54b05abd2e6d0bfa0e3ba143509d0bc695"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_EditDiscount), @"mvc.1.0.view", @"/Views/Admin/EditDiscount.cshtml")]
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
#line 1 "/Users/macbook/Projects/ECommerce/ECommerce/Views/Admin/EditDiscount.cshtml"
using ECommerce.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b868b54b05abd2e6d0bfa0e3ba143509d0bc695", @"/Views/Admin/EditDiscount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89fb089828dd866504103bfaeb2b6e1f9939c572", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_EditDiscount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DiscountViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h2>Edit Discount</h2>\n\n");
#nullable restore
#line 6 "/Users/macbook/Projects/ECommerce/ECommerce/Views/Admin/EditDiscount.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/macbook/Projects/ECommerce/ECommerce/Views/Admin/EditDiscount.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-horizontal\">\n    <hr />\n    ");
#nullable restore
#line 12 "/Users/macbook/Projects/ECommerce/ECommerce/Views/Admin/EditDiscount.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    ");
#nullable restore
#line 13 "/Users/macbook/Projects/ECommerce/ECommerce/Views/Admin/EditDiscount.cshtml"
Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 16 "/Users/macbook/Projects/ECommerce/ECommerce/Views/Admin/EditDiscount.cshtml"
   Write(Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 18 "/Users/macbook/Projects/ECommerce/ECommerce/Views/Admin/EditDiscount.cshtml"
       Write(Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 19 "/Users/macbook/Projects/ECommerce/ECommerce/Views/Admin/EditDiscount.cshtml"
       Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n\n    <label>Category</label>\n    <div class=\"col-md-10\">\n        ");
#nullable restore
#line 25 "/Users/macbook/Projects/ECommerce/ECommerce/Views/Admin/EditDiscount.cshtml"
   Write(Html.DropDownList("Cid", (SelectList)ViewBag.Categories, "Kategori Seçiniz", htmlAttributes: new { @class = "form-control " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 29 "/Users/macbook/Projects/ECommerce/ECommerce/Views/Admin/EditDiscount.cshtml"
   Write(Html.LabelFor(model => model.DiscountRate, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 31 "/Users/macbook/Projects/ECommerce/ECommerce/Views/Admin/EditDiscount.cshtml"
       Write(Html.EditorFor(model => model.DiscountRate, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 32 "/Users/macbook/Projects/ECommerce/ECommerce/Views/Admin/EditDiscount.cshtml"
       Write(Html.ValidationMessageFor(model => model.DiscountRate, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 37 "/Users/macbook/Projects/ECommerce/ECommerce/Views/Admin/EditDiscount.cshtml"
   Write(Html.LabelFor(model => model.StartDate, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 39 "/Users/macbook/Projects/ECommerce/ECommerce/Views/Admin/EditDiscount.cshtml"
       Write(Html.EditorFor(model => model.StartDate, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 40 "/Users/macbook/Projects/ECommerce/ECommerce/Views/Admin/EditDiscount.cshtml"
       Write(Html.ValidationMessageFor(model => model.StartDate, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 45 "/Users/macbook/Projects/ECommerce/ECommerce/Views/Admin/EditDiscount.cshtml"
   Write(Html.LabelFor(model => model.EndDate, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 47 "/Users/macbook/Projects/ECommerce/ECommerce/Views/Admin/EditDiscount.cshtml"
       Write(Html.EditorFor(model => model.EndDate, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 48 "/Users/macbook/Projects/ECommerce/ECommerce/Views/Admin/EditDiscount.cshtml"
       Write(Html.ValidationMessageFor(model => model.EndDate, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n\n    <label>Aktif Mi?</label>\n    ");
#nullable restore
#line 53 "/Users/macbook/Projects/ECommerce/ECommerce/Views/Admin/EditDiscount.cshtml"
Write(Html.CheckBoxFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    <div class=\"form-group\">\n        <div class=\"col-md-offset-2 col-md-10\">\n            <input type=\"submit\" value=\"Save\" class=\"btn btn-default\" />\n        </div>\n    </div>\n</div>\n");
#nullable restore
#line 61 "/Users/macbook/Projects/ECommerce/ECommerce/Views/Admin/EditDiscount.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div>\n    ");
#nullable restore
#line 64 "/Users/macbook/Projects/ECommerce/ECommerce/Views/Admin/EditDiscount.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DiscountViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
