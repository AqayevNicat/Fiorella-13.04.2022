#pragma checksum "C:\Users\nijatma\Desktop\Fiorella-13.04.2022\WebApplication1\WebApplication1\Views\Shared\_BasketTablePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b26e4e6fa70774a11ec8d8bfdb49b4167ee495e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__BasketTablePartial), @"mvc.1.0.view", @"/Views/Shared/_BasketTablePartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b26e4e6fa70774a11ec8d8bfdb49b4167ee495e", @"/Views/Shared/_BasketTablePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d35ac56dd50ef88310c7a9e17225608ef4972b7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__BasketTablePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\nijatma\Desktop\Fiorella-13.04.2022\WebApplication1\WebApplication1\Views\Shared\_BasketTablePartial.cshtml"
 foreach (Product product in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td class=\"custome-checkbox\"><input type=\"checkbox\"></td>\r\n        <td class=\"image\"><img src=\"images/trending/product-3-1.jpg\"></td>\r\n        <td class=\"product-name\">\r\n            <h6>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 286, "\"", 293, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 9 "C:\Users\nijatma\Desktop\Fiorella-13.04.2022\WebApplication1\WebApplication1\Views\Shared\_BasketTablePartial.cshtml"
                      Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &amp; ");
#nullable restore
#line 9 "C:\Users\nijatma\Desktop\Fiorella-13.04.2022\WebApplication1\WebApplication1\Views\Shared\_BasketTablePartial.cshtml"
                                          Write(product.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
            </h6>
            <div class=""icons"">
                <i class=""fa-solid fa-star""></i>
                <i class=""fa-solid fa-star""></i>
                <i class=""fa-solid fa-star""></i>
                <i class=""fa-solid fa-star""></i>
                <i class=""fa-solid fa-star-half-stroke""></i>
                <span>(4.0)</span>
            </div>
        </td>
        <td class=""price"">
            <h4>$");
#nullable restore
#line 21 "C:\Users\nijatma\Desktop\Fiorella-13.04.2022\WebApplication1\WebApplication1\Views\Shared\_BasketTablePartial.cshtml"
            Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
        </td>
        <td class=""item-count"">
            <div class=""inp-num number"">
                <a href=""#"" class=""up""><i class=""fa-solid fa-angle-up ""></i></a>
                <span class=""inp-value count"">1</span>
                <a href=""#"" class=""down""><i class=""fa-solid fa-angle-down""></i></a>
            </div>
        </td>
        <td class=""price subtotal-price"">
            <h4>$<span class=""subtotal-value"">49</span></h4>
        </td>
        <td class=""remove"">
            <a href=""#"">
                <i class=""fa-solid fa-trash-can""></i>
            </a>
        </td>
        <span class=""product-id"">3</span>
    </tr>
");
#nullable restore
#line 40 "C:\Users\nijatma\Desktop\Fiorella-13.04.2022\WebApplication1\WebApplication1\Views\Shared\_BasketTablePartial.cshtml"
}

#line default
#line hidden
#nullable disable
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