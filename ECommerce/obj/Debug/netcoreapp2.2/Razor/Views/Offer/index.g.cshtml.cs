#pragma checksum "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\Offer\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "380da403771c7d752ee07614fcdb4edcc63e575e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Offer_index), @"mvc.1.0.view", @"/Views/Offer/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Offer/index.cshtml", typeof(AspNetCore.Views_Offer_index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"380da403771c7d752ee07614fcdb4edcc63e575e", @"/Views/Offer/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec470632cb3b1b75499bc0cdcc8d1831e35eecad", @"/Views/_ViewImports.cshtml")]
    public class Views_Offer_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ECommerce.Models.offerModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(52, 8, true);
            WriteLiteral("       \n");
            EndContext();
#line 3 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\Offer\index.cshtml"
      
        ViewData["Title"] = "Index";    
    

#line default
#line hidden
            BeginContext(118, 41, true);
            WriteLiteral("<h2>Offer DashBoard</h2>    \n<p>    \n    ");
            EndContext();
            BeginContext(159, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "380da403771c7d752ee07614fcdb4edcc63e575e4433", async() => {
                BeginContext(182, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(196, 110, true);
            WriteLiteral("    \n</p>    \n<table class=\"table\">    \n    <thead>    \n        <tr>    \n            <th>    \n                ");
            EndContext();
            BeginContext(307, 45, false);
#line 14 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\Offer\index.cshtml"
           Write(Html.DisplayNameFor(model => model.offercode));

#line default
#line hidden
            EndContext();
            BeginContext(352, 64, true);
            WriteLiteral("    \n            </th>    \n            <th>    \n                ");
            EndContext();
            BeginContext(417, 40, false);
#line 17 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\Offer\index.cshtml"
           Write(Html.DisplayNameFor(model => model.name));

#line default
#line hidden
            EndContext();
            BeginContext(457, 77, true);
            WriteLiteral("    \n            </th>  \n              \n            <th>    \n                ");
            EndContext();
            BeginContext(535, 47, false);
#line 21 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\Offer\index.cshtml"
           Write(Html.DisplayNameFor(model => model.description));

#line default
#line hidden
            EndContext();
            BeginContext(582, 64, true);
            WriteLiteral("    \n            </th>    \n            <th>    \n                ");
            EndContext();
            BeginContext(647, 46, false);
#line 24 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\Offer\index.cshtml"
           Write(Html.DisplayNameFor(model => model.percentage));

#line default
#line hidden
            EndContext();
            BeginContext(693, 73, true);
            WriteLiteral("    \n            </th> \n           \n            <th>    \n                ");
            EndContext();
            BeginContext(767, 44, false);
#line 28 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\Offer\index.cshtml"
           Write(Html.DisplayNameFor(model => model.createon));

#line default
#line hidden
            EndContext();
            BeginContext(811, 104, true);
            WriteLiteral("    \n            </th>    \n            <th></th>    \n        </tr>    \n    </thead>    \n    <tbody>    \n");
            EndContext();
#line 34 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\Offer\index.cshtml"
         foreach (var item in Model)    
{    

#line default
#line hidden
            BeginContext(962, 66, true);
            WriteLiteral("            <tr>    \n                <td>    \n                    ");
            EndContext();
            BeginContext(1029, 44, false);
#line 38 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\Offer\index.cshtml"
               Write(Html.DisplayFor(modelItem => item.offercode));

#line default
#line hidden
            EndContext();
            BeginContext(1073, 76, true);
            WriteLiteral("    \n                </td>    \n                <td>    \n                    ");
            EndContext();
            BeginContext(1150, 39, false);
#line 41 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\Offer\index.cshtml"
               Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
            EndContext();
            BeginContext(1189, 94, true);
            WriteLiteral("    \n                </td>    \n                 \n                <td>    \n                    ");
            EndContext();
            BeginContext(1284, 46, false);
#line 45 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\Offer\index.cshtml"
               Write(Html.DisplayFor(modelItem => item.description));

#line default
#line hidden
            EndContext();
            BeginContext(1330, 75, true);
            WriteLiteral("    \n                </td>   \n                <td>    \n                    ");
            EndContext();
            BeginContext(1406, 45, false);
#line 48 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\Offer\index.cshtml"
               Write(Html.DisplayFor(modelItem => item.percentage));

#line default
#line hidden
            EndContext();
            BeginContext(1451, 88, true);
            WriteLiteral("    \n                </td>\n               \n                <td>    \n                    ");
            EndContext();
            BeginContext(1540, 43, false);
#line 52 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\Offer\index.cshtml"
               Write(Html.DisplayFor(modelItem => item.createon));

#line default
#line hidden
            EndContext();
            BeginContext(1583, 74, true);
            WriteLiteral("    \n                </td>  \n                <td>    \n                    ");
            EndContext();
            BeginContext(1657, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "380da403771c7d752ee07614fcdb4edcc63e575e10698", async() => {
                BeginContext(1702, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 55 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\Offer\index.cshtml"
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
            BeginContext(1710, 49, true);
            WriteLiteral(" |                          \n                    ");
            EndContext();
            BeginContext(1759, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "380da403771c7d752ee07614fcdb4edcc63e575e13076", async() => {
                BeginContext(1806, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 56 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\Offer\index.cshtml"
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
            BeginContext(1816, 50, true);
            WriteLiteral(" \n                </td>    \n            </tr>    \n");
            EndContext();
#line 59 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\Offer\index.cshtml"
        }    

#line default
#line hidden
            BeginContext(1880, 25, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ECommerce.Models.offerModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
