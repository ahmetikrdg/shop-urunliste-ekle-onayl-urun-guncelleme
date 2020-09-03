#pragma checksum "C:\Users\Ahmet\Desktop\shopapp\shopapp.webui\Views\Admin\ProductList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e12b77d2ecd998baafb5fd0b969c063d40ff100f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ProductList), @"mvc.1.0.view", @"/Views/Admin/ProductList.cshtml")]
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
#line 2 "C:\Users\Ahmet\Desktop\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ahmet\Desktop\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e12b77d2ecd998baafb5fd0b969c063d40ff100f", @"/Views/Admin/ProductList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b1555847ff9e709729e962dfd3038daef5d36d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ProductList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        <h1>Admin Products</h1>
        <hr>
        <table class=""table table-bordered"">
          <thead>
              <td style=""width:50px"">Id</td>
              <td style=""width:150px"">Img</td>
              <td style=""width:250px"">Name</td>
              <td style=""width:50px"">Price</td>
              <td style=""width:20px"">AnaSayfa</td>
              <td style=""width:20px"">Onaylı</td>
              <td style=""width:50px"">Fiyat</td>
              <td style=""width:50px"">Erişim</td>

          </thead>
          <tbody>
");
#nullable restore
#line 20 "C:\Users\Ahmet\Desktop\shopapp\shopapp.webui\Views\Admin\ProductList.cshtml"
            if(Model.Products.Count>0)
           {
             

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Ahmet\Desktop\shopapp\shopapp.webui\Views\Admin\ProductList.cshtml"
              foreach (var item in Model.Products)//her bir eleman item içinde saklansın ve yapımız her gelen ürün için tr oluşsun
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <tr>\r\n                    <td >");
#nullable restore
#line 25 "C:\Users\Ahmet\Desktop\shopapp\shopapp.webui\Views\Admin\ProductList.cshtml"
                    Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td >");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e12b77d2ecd998baafb5fd0b969c063d40ff100f4952", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 934, "~/img/", 934, 6, true);
#nullable restore
#line 26 "C:\Users\Ahmet\Desktop\shopapp\shopapp.webui\Views\Admin\ProductList.cshtml"
AddHtmlAttributeValue("", 940, item.ImageUrl, 940, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                    <td >");
#nullable restore
#line 27 "C:\Users\Ahmet\Desktop\shopapp\shopapp.webui\Views\Admin\ProductList.cshtml"
                    Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td >");
#nullable restore
#line 28 "C:\Users\Ahmet\Desktop\shopapp\shopapp.webui\Views\Admin\ProductList.cshtml"
                    Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n");
#nullable restore
#line 30 "C:\Users\Ahmet\Desktop\shopapp\shopapp.webui\Views\Admin\ProductList.cshtml"
                       if(item.IsHome)
                      {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <i class=\"fas fa-check-circle\"></i>\r\n");
#nullable restore
#line 33 "C:\Users\Ahmet\Desktop\shopapp\shopapp.webui\Views\Admin\ProductList.cshtml"
                      }
                      else
                      {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <i class=\"fas fa-times-circle\"></i>\r\n");
#nullable restore
#line 37 "C:\Users\Ahmet\Desktop\shopapp\shopapp.webui\Views\Admin\ProductList.cshtml"
                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 40 "C:\Users\Ahmet\Desktop\shopapp\shopapp.webui\Views\Admin\ProductList.cshtml"
                       if(item.IsApproved)
                      {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <i class=\"fas fa-check-circle\"></i>\r\n");
#nullable restore
#line 43 "C:\Users\Ahmet\Desktop\shopapp\shopapp.webui\Views\Admin\ProductList.cshtml"
                      }
                      else
                      {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <i class=\"fas fa-times-circle\"></i>\r\n");
#nullable restore
#line 47 "C:\Users\Ahmet\Desktop\shopapp\shopapp.webui\Views\Admin\ProductList.cshtml"
                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td >");
#nullable restore
#line 50 "C:\Users\Ahmet\Desktop\shopapp\shopapp.webui\Views\Admin\ProductList.cshtml"
                    Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                  <td>\r\n                      <a class=\"btn btn-primary btn-sm mr-2\"");
            BeginWriteAttribute("href", " href=\"", 1878, "\"", 1916, 2);
            WriteAttributeValue("", 1885, "/admin/products/", 1885, 16, true);
#nullable restore
#line 52 "C:\Users\Ahmet\Desktop\shopapp\shopapp.webui\Views\Admin\ProductList.cshtml"
WriteAttributeValue("", 1901, item.ProductId, 1901, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> ");
            WriteLiteral("\r\n                      <a class=\"btn btn-danger btn-sm mr-2\" href=\"#\">Delete</a>\r\n                  </td>\r\n              </tr>\r\n");
#nullable restore
#line 56 "C:\Users\Ahmet\Desktop\shopapp\shopapp.webui\Views\Admin\ProductList.cshtml"
              }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\Ahmet\Desktop\shopapp\shopapp.webui\Views\Admin\ProductList.cshtml"
               
           }
           else
           {

#line default
#line hidden
#nullable disable
            WriteLiteral("             <div class=\"alert alert-warning\">\r\n                 <h3>No Products</h3>\r\n             </div>\r\n");
#nullable restore
#line 63 "C:\Users\Ahmet\Desktop\shopapp\shopapp.webui\Views\Admin\ProductList.cshtml"
           }

#line default
#line hidden
#nullable disable
            WriteLiteral("          </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
