#pragma checksum "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\Plant\Index1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c38bfa0f46b3179e3d8916a0f63f7efc357fe36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Plant_Index1), @"mvc.1.0.view", @"/Views/Plant/Index1.cshtml")]
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
#line 1 "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\_ViewImports.cshtml"
using FabricateApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\_ViewImports.cshtml"
using FabricateApp1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c38bfa0f46b3179e3d8916a0f63f7efc357fe36", @"/Views/Plant/Index1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba2b946cfa0fd2ee15e06ba58c618185ba619e88", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Plant_Index1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FabricateApp1.Models.Part>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\Plant\Index1.cshtml"
  
    ViewBag.Title = "Part Index";
    Layout= "~/Views/Shared/_Afterlogin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<center>\r\n<h2>Available Parts</h2>\r\n<p>\r\n    ");
#nullable restore
#line 12 "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\Plant\Index1.cshtml"
Write(Html.ActionLink("Add Parts","AddParts"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
#nullable restore
#line 13 "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\Plant\Index1.cshtml"
Write(Html.ActionLink("Add Part Reorder","AddPartReorder"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
#nullable restore
#line 14 "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\Plant\Index1.cshtml"
Write(Html.ActionLink("Reorder Details","Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    \r\n</p>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 21 "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\Plant\Index1.cshtml"
       Write(Html.DisplayNameFor(model => model.PartId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 24 "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\Plant\Index1.cshtml"
       Write(Html.DisplayNameFor(model => model.PartDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 27 "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\Plant\Index1.cshtml"
       Write(Html.DisplayNameFor(model => model.PartSpecification));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 32 "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\Plant\Index1.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n<td>\r\n    ");
#nullable restore
#line 35 "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\Plant\Index1.cshtml"
Write(Html.DisplayFor(modelItem => item.PartId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</td>\r\n<td>\r\n    ");
#nullable restore
#line 38 "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\Plant\Index1.cshtml"
Write(Html.DisplayFor(modelItem => item.PartDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</td>\r\n<td>\r\n    ");
#nullable restore
#line 41 "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\Plant\Index1.cshtml"
Write(Html.DisplayFor(modelItem => item.PartSpecification));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</td>\r\n</tr>\r\n");
#nullable restore
#line 44 "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\Plant\Index1.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n</center>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FabricateApp1.Models.Part>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591