#pragma checksum "C:\Users\LeNoVo\OneDrive\Desktop\Last Github project\Last one\Amazon-Clone---ITI-final-project\Admin\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d60023f02313124bcce2179650b72fcf708312b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
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
#line 1 "C:\Users\LeNoVo\OneDrive\Desktop\Last Github project\Last one\Amazon-Clone---ITI-final-project\Admin\Views\_ViewImports.cshtml"
using Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LeNoVo\OneDrive\Desktop\Last Github project\Last one\Amazon-Clone---ITI-final-project\Admin\Views\_ViewImports.cshtml"
using Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d60023f02313124bcce2179650b72fcf708312b", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"425c13ece3d0cfbb1fc0f84962af70815be6a0e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""main-container"">
    <div class=""pd-ltr-20"">

        <div class=""card-box mb-30"">
            <h2 class=""h4 pd-20"">Orders</h2>
            <table class=""data-table table nowrap"">
                <thead>
                    <tr>
                        <th>Order ID</th>
                        <th>Address</th>
                        <th>Order Date</th>
                        <th>Customer ID</th>
                        <th> Estimated Delivery Date</th>
                        <th>Details</th>
                        <th>Edit</th>
                        <th>Delete</th>
");
            WriteLiteral("                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\LeNoVo\OneDrive\Desktop\Last Github project\Last one\Amazon-Clone---ITI-final-project\Admin\Views\Order\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 31 "C:\Users\LeNoVo\OneDrive\Desktop\Last Github project\Last one\Amazon-Clone---ITI-final-project\Admin\Views\Order\Index.cshtml"
                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 32 "C:\Users\LeNoVo\OneDrive\Desktop\Last Github project\Last one\Amazon-Clone---ITI-final-project\Admin\Views\Order\Index.cshtml"
                       Write(item.OrderAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 33 "C:\Users\LeNoVo\OneDrive\Desktop\Last Github project\Last one\Amazon-Clone---ITI-final-project\Admin\Views\Order\Index.cshtml"
                       Write(item.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 34 "C:\Users\LeNoVo\OneDrive\Desktop\Last Github project\Last one\Amazon-Clone---ITI-final-project\Admin\Views\Order\Index.cshtml"
                       Write(item.CustomerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 35 "C:\Users\LeNoVo\OneDrive\Desktop\Last Github project\Last one\Amazon-Clone---ITI-final-project\Admin\Views\Order\Index.cshtml"
                       Write(item.EstimatedDeliveryDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 37 "C:\Users\LeNoVo\OneDrive\Desktop\Last Github project\Last one\Amazon-Clone---ITI-final-project\Admin\Views\Order\Index.cshtml"
                       Write(Html.ActionLink("Details", "Details", new { @Id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <i class=\"fa-solid fa-adjust\">\r\n                                ");
#nullable restore
#line 41 "C:\Users\LeNoVo\OneDrive\Desktop\Last Github project\Last one\Amazon-Clone---ITI-final-project\Admin\Views\Order\Index.cshtml"
                           Write(Html.ActionLink("update", "update", new
                           {
                               @Id = item.Id,
                               EstimatedDeliveryDate = item.EstimatedDeliveryDate,
                               CustomerId = item.CustomerId,
                               OrderDate = item.OrderDate,
                               OrderAddress = item.OrderAddress
                           }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </i>\r\n                        </td>\r\n                        <td>\r\n                            <i class=\"fa-solid fa-trash-can\">\r\n                                ");
#nullable restore
#line 53 "C:\Users\LeNoVo\OneDrive\Desktop\Last Github project\Last one\Amazon-Clone---ITI-final-project\Admin\Views\Order\Index.cshtml"
                           Write(Html.ActionLink("Delete", "Delete", new { @Id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </i>
                        </td>

                        <td>


                        </td>
                        <td>
                            <div class=""dropdown"">
                                <a class=""btn btn-link font-24 p-0 line-height-1 no-arrow dropdown-toggle"" href=""#"" role=""button"" data-toggle=""dropdown"">
                                    <i class=""dw dw-more""></i>
                                </a>
                                <div class=""dropdown-menu dropdown-menu-right dropdown-menu-icon-list"">

                                    ");
#nullable restore
#line 68 "C:\Users\LeNoVo\OneDrive\Desktop\Last Github project\Last one\Amazon-Clone---ITI-final-project\Admin\Views\Order\Index.cshtml"
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
                    </tr>
");
#nullable restore
#line 77 "C:\Users\LeNoVo\OneDrive\Desktop\Last Github project\Last one\Amazon-Clone---ITI-final-project\Admin\Views\Order\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
