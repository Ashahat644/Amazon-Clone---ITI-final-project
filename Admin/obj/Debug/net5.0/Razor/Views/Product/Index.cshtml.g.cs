#pragma checksum "C:\Users\LeNoVo\OneDrive\Desktop\Last Github project\1\Amazon-Clone---ITI-final-project\Admin\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91903c830383dc2a38d3d9148c0268a0d85e2e16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\LeNoVo\OneDrive\Desktop\Last Github project\1\Amazon-Clone---ITI-final-project\Admin\Views\_ViewImports.cshtml"
using Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LeNoVo\OneDrive\Desktop\Last Github project\1\Amazon-Clone---ITI-final-project\Admin\Views\_ViewImports.cshtml"
using Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91903c830383dc2a38d3d9148c0268a0d85e2e16", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"425c13ece3d0cfbb1fc0f84962af70815be6a0e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""main-container"">
    <div class=""pd-ltr-20"">

        <div class=""card-box mb-30"">
            <h2 class=""h4 pd-20"">Best Selling Products</h2>
            <table class=""data-table table nowrap"">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Name</th>
                        <th>Discount</th>
                        <th>Shipping</th>
                        <th>Price</th>
                        <th>Picture</th>
                        <th>Stock</th>
                        <th>Brand</th>
                        <th>Description</th>
                        <th>SubCategoryID</th>
                        <th>SellerId</th>
                        <th>Delete</th>
                        <th class=""datatable-nosort"">Action</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 28 "C:\Users\LeNoVo\OneDrive\Desktop\Last Github project\1\Amazon-Clone---ITI-final-project\Admin\Views\Product\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 31 "C:\Users\LeNoVo\OneDrive\Desktop\Last Github project\1\Amazon-Clone---ITI-final-project\Admin\Views\Product\Index.cshtml"
                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 32 "C:\Users\LeNoVo\OneDrive\Desktop\Last Github project\1\Amazon-Clone---ITI-final-project\Admin\Views\Product\Index.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 33 "C:\Users\LeNoVo\OneDrive\Desktop\Last Github project\1\Amazon-Clone---ITI-final-project\Admin\Views\Product\Index.cshtml"
                       Write(item.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 34 "C:\Users\LeNoVo\OneDrive\Desktop\Last Github project\1\Amazon-Clone---ITI-final-project\Admin\Views\Product\Index.cshtml"
                       Write(item.Shipping);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 35 "C:\Users\LeNoVo\OneDrive\Desktop\Last Github project\1\Amazon-Clone---ITI-final-project\Admin\Views\Product\Index.cshtml"
                       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 36 "C:\Users\LeNoVo\OneDrive\Desktop\Last Github project\1\Amazon-Clone---ITI-final-project\Admin\Views\Product\Index.cshtml"
                       Write(item.Picture);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 37 "C:\Users\LeNoVo\OneDrive\Desktop\Last Github project\1\Amazon-Clone---ITI-final-project\Admin\Views\Product\Index.cshtml"
                       Write(item.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 38 "C:\Users\LeNoVo\OneDrive\Desktop\Last Github project\1\Amazon-Clone---ITI-final-project\Admin\Views\Product\Index.cshtml"
                       Write(item.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 39 "C:\Users\LeNoVo\OneDrive\Desktop\Last Github project\1\Amazon-Clone---ITI-final-project\Admin\Views\Product\Index.cshtml"
                       Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 40 "C:\Users\LeNoVo\OneDrive\Desktop\Last Github project\1\Amazon-Clone---ITI-final-project\Admin\Views\Product\Index.cshtml"
                       Write(item.categoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 41 "C:\Users\LeNoVo\OneDrive\Desktop\Last Github project\1\Amazon-Clone---ITI-final-project\Admin\Views\Product\Index.cshtml"
                       Write(item.SellerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <i class=\"fa-solid fa-trash-can\">\r\n                                ");
#nullable restore
#line 44 "C:\Users\LeNoVo\OneDrive\Desktop\Last Github project\1\Amazon-Clone---ITI-final-project\Admin\Views\Product\Index.cshtml"
                           Write(Html.ActionLink("Delete", "Delete", new { @Id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </i>\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 48 "C:\Users\LeNoVo\OneDrive\Desktop\Last Github project\1\Amazon-Clone---ITI-final-project\Admin\Views\Product\Index.cshtml"
                       Write(Html.ActionLink("Edit", "Edit", new
                       {
                           @Id = item.Id,
                           @Name = item.Name,
                           @Discount = item.Discount,
                           @Shipping = item.Shipping,
                           @Price = item.Price,
                           @Picture = item.Picture,
                           @Stock = item.Stock,
                           @Brand = item.Brand,
                           @Description = item.Description,
                           @SubCategoryID = item.categoryId,
                           @SellerId=item.SellerId
                       }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        </td>
                        <td>
                            <div class=""dropdown"">
                                <a class=""btn btn-link font-24 p-0 line-height-1 no-arrow dropdown-toggle"" href=""#"" role=""button"" data-toggle=""dropdown"">
                                    <i class=""dw dw-more""></i>
                                </a>
                                <div class=""dropdown-menu dropdown-menu-right dropdown-menu-icon-list"">

                                    ");
#nullable restore
#line 71 "C:\Users\LeNoVo\OneDrive\Desktop\Last Github project\1\Amazon-Clone---ITI-final-project\Admin\Views\Product\Index.cshtml"
                               Write(Html.ActionLink("Create", "Create", null, new { @class = "dropdown-item" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    <a class=""dropdown-item"" href=""#""><i class=""dw dw-eye""></i> View</a>
                                    <a class=""dropdown-item"" href=""#""><i class=""dw dw-edit2""></i> Edit</a>

                                    <a class=""dropdown-item"" href=""#""><i class=""dw dw-delete-3""></i> Delete</a>
                                </div>
                            </div>
                        </td>
                    </tr>");
#nullable restore
#line 79 "C:\Users\LeNoVo\OneDrive\Desktop\Last Github project\1\Amazon-Clone---ITI-final-project\Admin\Views\Product\Index.cshtml"
                         }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>
        <div class=""footer-wrap pd-20 mb-20 card-box"">
            DeskApp - Bootstrap 4 Admin Template By <a href=""https://github.com/dropways"" target=""_blank"">Ankit Hingarajiya</a>
        </div>
    </div>
</div>



");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
