#pragma checksum "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\purchase\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e175e75c68a331c9b58281dd80345520198da93e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_purchase_index), @"mvc.1.0.view", @"/Views/purchase/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/purchase/index.cshtml", typeof(AspNetCore.Views_purchase_index))]
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
#line 1 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\_ViewImports.cshtml"
using ECommerce;

#line default
#line hidden
#line 2 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\_ViewImports.cshtml"
using ECommerce.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e175e75c68a331c9b58281dd80345520198da93e", @"/Views/purchase/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec470632cb3b1b75499bc0cdcc8d1831e35eecad", @"/Views/_ViewImports.cshtml")]
    public class Views_purchase_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ECommerce.Models.productModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 8, true);
            WriteLiteral("       \n");
            EndContext();
#line 3 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\purchase\index.cshtml"
     
        Layout ="_Layout_purchase"; 
        ViewData["Title"] = "Index";    
    

#line default
#line hidden
            BeginContext(156, 126, true);
            WriteLiteral("<h2>Product List</h2>    \n   \n<table class=\"table\">    \n    <thead>    \n        <tr>    \n            <th>    \n                ");
            EndContext();
            BeginContext(283, 47, false);
#line 13 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\purchase\index.cshtml"
           Write(Html.DisplayNameFor(model => model.productcode));

#line default
#line hidden
            EndContext();
            BeginContext(330, 64, true);
            WriteLiteral("    \n            </th>    \n            <th>    \n                ");
            EndContext();
            BeginContext(395, 40, false);
#line 16 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\purchase\index.cshtml"
           Write(Html.DisplayNameFor(model => model.name));

#line default
#line hidden
            EndContext();
            BeginContext(435, 62, true);
            WriteLiteral("    \n            </th>  \n            <th>    \n                ");
            EndContext();
            BeginContext(498, 40, false);
#line 19 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\purchase\index.cshtml"
           Write(Html.DisplayNameFor(model => model.type));

#line default
#line hidden
            EndContext();
            BeginContext(538, 64, true);
            WriteLiteral("    \n            </th>    \n            <th>    \n                ");
            EndContext();
            BeginContext(603, 47, false);
#line 22 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\purchase\index.cshtml"
           Write(Html.DisplayNameFor(model => model.description));

#line default
#line hidden
            EndContext();
            BeginContext(650, 64, true);
            WriteLiteral("    \n            </th>    \n            <th>    \n                ");
            EndContext();
            BeginContext(715, 41, false);
#line 25 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\purchase\index.cshtml"
           Write(Html.DisplayNameFor(model => model.price));

#line default
#line hidden
            EndContext();
            BeginContext(756, 102, true);
            WriteLiteral("    \n            </th>  \n            <th></th>    \n        </tr>    \n    </thead>    \n    <tbody>    \n");
            EndContext();
#line 31 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\purchase\index.cshtml"
         foreach (var item in Model)    
{    

#line default
#line hidden
            BeginContext(905, 66, true);
            WriteLiteral("            <tr>    \n                <td>    \n                    ");
            EndContext();
            BeginContext(972, 46, false);
#line 35 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\purchase\index.cshtml"
               Write(Html.DisplayFor(modelItem => item.productcode));

#line default
#line hidden
            EndContext();
            BeginContext(1018, 76, true);
            WriteLiteral("    \n                </td>    \n                <td>    \n                    ");
            EndContext();
            BeginContext(1095, 39, false);
#line 38 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\purchase\index.cshtml"
               Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
            EndContext();
            BeginContext(1134, 76, true);
            WriteLiteral("    \n                </td>    \n                <td>    \n                    ");
            EndContext();
            BeginContext(1211, 39, false);
#line 41 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\purchase\index.cshtml"
               Write(Html.DisplayFor(modelItem => item.type));

#line default
#line hidden
            EndContext();
            BeginContext(1250, 76, true);
            WriteLiteral("    \n                </td>    \n                <td>    \n                    ");
            EndContext();
            BeginContext(1327, 46, false);
#line 44 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\purchase\index.cshtml"
               Write(Html.DisplayFor(modelItem => item.description));

#line default
#line hidden
            EndContext();
            BeginContext(1373, 75, true);
            WriteLiteral("    \n                </td>   \n                <td>    \n                    ");
            EndContext();
            BeginContext(1449, 40, false);
#line 47 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\purchase\index.cshtml"
               Write(Html.DisplayFor(modelItem => item.price));

#line default
#line hidden
            EndContext();
            BeginContext(1489, 87, true);
            WriteLiteral("    \n                </td>               \n                <td>    \n                    ");
            EndContext();
            BeginContext(1576, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e175e75c68a331c9b58281dd80345520198da93e8731", async() => {
                BeginContext(1621, 15, true);
                WriteLiteral("Buy the Product");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 50 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\purchase\index.cshtml"
                                           WriteLiteral(item.id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1640, 57, true);
            WriteLiteral("        \n                </td>    \n            </tr>    \n");
            EndContext();
#line 53 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\purchase\index.cshtml"
        }    

#line default
#line hidden
            BeginContext(1711, 25, true);
            WriteLiteral("    </tbody>    \n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ECommerce.Models.productModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
