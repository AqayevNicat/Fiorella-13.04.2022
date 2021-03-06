#pragma checksum "C:\Users\nijatma\Desktop\Fiorella-13.04.2022\WebApplication1\WebApplication1\Views\Basket\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb317b6de6983186100e03c27dc0ba1b40bc2d5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Basket_Index), @"mvc.1.0.view", @"/Views/Basket/Index.cshtml")]
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
#line 1 "C:\Users\nijatma\Desktop\Fiorella-13.04.2022\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nijatma\Desktop\Fiorella-13.04.2022\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb317b6de6983186100e03c27dc0ba1b40bc2d5e", @"/Views/Basket/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d35ac56dd50ef88310c7a9e17225608ef4972b7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Basket_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BasketVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<main>
    <section id=""product-list-title"">
        <div class=""container py-4"">
            <div class=""row py-5"">
                <div class=""col-12"">
                    <h1>Product List</h1>
                    <i class=""text-muted"">Where flowers are our inspiration</i>
                </div>
            </div>
        </div>
    </section>
    <section id=""product-list"">
        <div class=""container"">
            <div class=""row"">
                <section id=""cart"">
                    <div class=""container-fluid"">
                        <div class=""row"">
                            <div class=""col-lg-8 head-text"">
                                <h4>Your Cart</h4>
                                <p>
                                    <span>There are <span class=""countt"">0</span> products in your cart</span>
                                    <a");
            BeginWriteAttribute("href", " href=\"", 911, "\"", 918, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""clear-basket""><i class=""fa-solid fa-trash-can""></i>Clear Cart</a>
                                </p>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-xl-8 col-lg-12 cart-left"">
                                <table class=""cart-table"">
                                    <thead class=""cart-head"">
                                        <tr>
                                            <th class=""custome-checkbox"">
                                                <input type=""checkbox""");
            BeginWriteAttribute("name", " name=\"", 1529, "\"", 1536, 0);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1537, "\"", 1542, 0);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1543, "\"", 1551, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                            </th>
                                            <th scope=""col"" style=""text-align: left;"" colspan=""2"">Product</th>
                                            <th scope=""col"">Unit Price</th>
                                            <th scope=""col"">Quantity</th>
                                            <th scope=""col"">Subtotal</th>
                                            <th scope=""col"" class=""end"">Remove</th>
                                        </tr>
                                    </thead>
                                    <tbody class=""cart-body"">
                                        ");
#nullable restore
#line 43 "C:\Users\nijatma\Desktop\Fiorella-13.04.2022\WebApplication1\WebApplication1\Views\Basket\Index.cshtml"
                                   Write(await Html.PartialAsync("_BasketTablePartial", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </tbody>
                                </table>
                                <hr style=""margin-top: 50px;"">
                                <div class=""update-btn"">
                                    <a href=""shop.html"" class=""shop""><i class=""fa-solid fa-left-long""></i>Continue shopping</a>
                                    <button class=""update""><i class=""fa-solid fa-arrows-rotate""></i>Update cart</button>
                                </div>
                            </div>
                            <div class=""col-xl-4 col-lg-12 cart-right"">
                                <div class=""table-responsive"">
                                    <table class=""table no-border"">
                                        <tbody>
                                            <tr>
                                                <td>
                                                    <h6>Subtotal</h6>
                                                </td>
");
            WriteLiteral(@"                                                <td class=""text-right"">
                                                    <h4>$12.31</h4>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td scope=""col"" colspan=""2"">
                                                    <hr>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <h6>Shipping</h6>
                                                </td>
                                                <td class=""text-right"">
                                                    <h5>Free </h5>
                                                </td>
                                            </tr>
       ");
            WriteLiteral(@"                                     <tr>
                                                <td>
                                                    <h6>Estimate for</h6>
                                                </td>
                                                <td class=""text-right"">
                                                    <h5>United Kingdom </h5>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td scope=""col"" colspan=""2"">
                                                    <hr>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <h6>Total</h6>
                                                </td>
                     ");
            WriteLiteral("                           <td class=\"text-right\">\r\n");
#nullable restore
#line 95 "C:\Users\nijatma\Desktop\Fiorella-13.04.2022\WebApplication1\WebApplication1\Views\Basket\Index.cshtml"
                                                       
                                                        double total = 0;
                                                        foreach (BasketVM item in Model)
                                                        {
                                                            total += (item.Count * item.Price);
                                                        }

                                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <h4>$ <span class=\"total-price-s\">");
#nullable restore
#line 103 "C:\Users\nijatma\Desktop\Fiorella-13.04.2022\WebApplication1\WebApplication1\Views\Basket\Index.cshtml"
                                                                                 Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></h4>
                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                    <a href=""#"">Proceed To CheckOut<i class=""fa-solid fa-door-open""></i></a>
                                </div>
                            </div>
                        </div>
                    </div>
                </section>
            </div>
        </div>
    </section>
</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BasketVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
