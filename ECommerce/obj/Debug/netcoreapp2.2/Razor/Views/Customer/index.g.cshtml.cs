#pragma checksum "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\Customer\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bbff5bc66633ccad6cedb684a2c68d32b761b63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_index), @"mvc.1.0.view", @"/Views/Customer/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/index.cshtml", typeof(AspNetCore.Views_Customer_index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bbff5bc66633ccad6cedb684a2c68d32b761b63", @"/Views/Customer/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec470632cb3b1b75499bc0cdcc8d1831e35eecad", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ECommerce.Models.customerModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "purchased", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(55, 8, true);
            WriteLiteral("       \n");
            EndContext();
#line 3 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\Customer\index.cshtml"
      
        ViewData["Title"] = "Index";    
    

#line default
#line hidden
            BeginContext(121, 44, true);
            WriteLiteral("<h2>Customer DashBoard</h2>    \n<p>    \n    ");
            EndContext();
            BeginContext(165, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7bbff5bc66633ccad6cedb684a2c68d32b761b634767", async() => {
                BeginContext(188, 10, true);
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
            BeginContext(202, 110, true);
            WriteLiteral("    \n</p>    \n<table class=\"table\">    \n    <thead>    \n        <tr>    \n            <th>    \n                ");
            EndContext();
            BeginContext(313, 42, false);
#line 14 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\Customer\index.cshtml"
           Write(Html.DisplayNameFor(model => model.custid));

#line default
#line hidden
            EndContext();
            BeginContext(355, 64, true);
            WriteLiteral("    \n            </th>    \n            <th>    \n                ");
            EndContext();
            BeginContext(420, 40, false);
#line 17 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\Customer\index.cshtml"
           Write(Html.DisplayNameFor(model => model.name));

#line default
#line hidden
            EndContext();
            BeginContext(460, 62, true);
            WriteLiteral("    \n            </th>  \n            <th>    \n                ");
            EndContext();
            BeginContext(523, 42, false);
#line 20 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\Customer\index.cshtml"
           Write(Html.DisplayNameFor(model => model.gender));

#line default
#line hidden
            EndContext();
            BeginContext(565, 64, true);
            WriteLiteral("    \n            </th>    \n            <th>    \n                ");
            EndContext();
            BeginContext(630, 41, false);
#line 23 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\Customer\index.cshtml"
           Write(Html.DisplayNameFor(model => model.phone));

#line default
#line hidden
            EndContext();
            BeginContext(671, 64, true);
            WriteLiteral("    \n            </th>    \n            <th>    \n                ");
            EndContext();
            BeginContext(736, 43, false);
#line 26 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\Customer\index.cshtml"
           Write(Html.DisplayNameFor(model => model.address));

#line default
#line hidden
            EndContext();
            BeginContext(779, 62, true);
            WriteLiteral("    \n            </th>  \n            <th>    \n                ");
            EndContext();
            BeginContext(842, 44, false);
#line 29 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\Customer\index.cshtml"
           Write(Html.DisplayNameFor(model => model.createon));

#line default
#line hidden
            EndContext();
            BeginContext(886, 117, true);
            WriteLiteral("    \n            </th>    \n            \n            <th></th>    \n        </tr>    \n    </thead>    \n    <tbody>    \n");
            EndContext();
#line 36 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\Customer\index.cshtml"
         foreach (var item in Model)    
{    

#line default
#line hidden
            BeginContext(1050, 66, true);
            WriteLiteral("            <tr>    \n                <td>    \n                    ");
            EndContext();
            BeginContext(1117, 41, false);
#line 40 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\Customer\index.cshtml"
               Write(Html.DisplayFor(modelItem => item.custid));

#line default
#line hidden
            EndContext();
            BeginContext(1158, 76, true);
            WriteLiteral("    \n                </td>    \n                <td>    \n                    ");
            EndContext();
            BeginContext(1235, 39, false);
#line 43 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\Customer\index.cshtml"
               Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
            EndContext();
            BeginContext(1274, 76, true);
            WriteLiteral("    \n                </td>    \n                <td>    \n                    ");
            EndContext();
            BeginContext(1351, 41, false);
#line 46 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\Customer\index.cshtml"
               Write(Html.DisplayFor(modelItem => item.gender));

#line default
#line hidden
            EndContext();
            BeginContext(1392, 76, true);
            WriteLiteral("    \n                </td>    \n                <td>    \n                    ");
            EndContext();
            BeginContext(1469, 40, false);
#line 49 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\Customer\index.cshtml"
               Write(Html.DisplayFor(modelItem => item.phone));

#line default
#line hidden
            EndContext();
            BeginContext(1509, 75, true);
            WriteLiteral("    \n                </td>   \n                <td>    \n                    ");
            EndContext();
            BeginContext(1585, 42, false);
#line 52 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\Customer\index.cshtml"
               Write(Html.DisplayFor(modelItem => item.address));

#line default
#line hidden
            EndContext();
            BeginContext(1627, 75, true);
            WriteLiteral("    \n                </td>  \n                 <td>    \n                    ");
            EndContext();
            BeginContext(1703, 43, false);
#line 55 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\Customer\index.cshtml"
               Write(Html.DisplayFor(modelItem => item.createon));

#line default
#line hidden
            EndContext();
            BeginContext(1746, 89, true);
            WriteLiteral("    \n                </td> \n               \n                <td>    \n                    ");
            EndContext();
            BeginContext(1835, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7bbff5bc66633ccad6cedb684a2c68d32b761b6311880", async() => {
                BeginContext(1880, 4, true);
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
#line 59 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\Customer\index.cshtml"
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
            BeginContext(1888, 49, true);
            WriteLiteral(" |                          \n                    ");
            EndContext();
            BeginContext(1937, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7bbff5bc66633ccad6cedb684a2c68d32b761b6314261", async() => {
                BeginContext(1984, 6, true);
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
#line 60 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\Customer\index.cshtml"
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
            BeginContext(1994, 26, true);
            WriteLiteral("  |  \n                    ");
            EndContext();
            BeginContext(2020, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7bbff5bc66633ccad6cedb684a2c68d32b761b6316623", async() => {
                BeginContext(2070, 9, true);
                WriteLiteral("My Orders");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 61 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\Customer\index.cshtml"
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
            BeginContext(2083, 49, true);
            WriteLiteral("\n                </td>    \n            </tr>    \n");
            EndContext();
#line 64 "D:\Jana\Source\dotnet core\Ignitho 1\Ignitho\ECommerce\Views\Customer\index.cshtml"
        }    

#line default
#line hidden
            BeginContext(2146, 25, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ECommerce.Models.customerModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
