#pragma checksum "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\Plant\stockinhand.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1759ce883aa8f79088ae9b68865661cb0d25f471"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Plant_stockinhand), @"mvc.1.0.view", @"/Views/Plant/stockinhand.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1759ce883aa8f79088ae9b68865661cb0d25f471", @"/Views/Plant/stockinhand.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba2b946cfa0fd2ee15e06ba58c618185ba619e88", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Plant_stockinhand : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FabricateApp1.Models.Part>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\Plant\stockinhand.cshtml"
  
    ViewBag.Title = "Part Description";
    Layout= "~/Views/Shared/_Afterlogin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Stock In Hand</h2>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 15 "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\Plant\stockinhand.cshtml"
       Write(Html.DisplayNameFor(model => model.PartDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 18 "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\Plant\stockinhand.cshtml"
       Write(Html.DisplayNameFor(model => model.PartSpecification));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        \r\n        <th></th>\r\n    </tr>\r\n\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FabricateApp1.Models.Part> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591