#pragma checksum "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\rfq\GetFeedback.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbd347970b55c8ff7a65de3ea7212a0c23693ca4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_rfq_GetFeedback), @"mvc.1.0.view", @"/Views/rfq/GetFeedback.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbd347970b55c8ff7a65de3ea7212a0c23693ca4", @"/Views/rfq/GetFeedback.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba2b946cfa0fd2ee15e06ba58c618185ba619e88", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_rfq_GetFeedback : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FabricateApp1.Models.RfqSupplier>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\rfq\GetFeedback.cshtml"
  
    ViewBag.Title = "Supplier Feedback";
    Layout= "~/Views/Shared/_Afterlogin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Feedback</h2>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 16 "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\rfq\GetFeedback.cshtml"
       Write(Html.DisplayNameFor(model => model.Part_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 19 "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\rfq\GetFeedback.cshtml"
       Write(Html.DisplayNameFor(model => model.Supplier_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 22 "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\rfq\GetFeedback.cshtml"
       Write(Html.DisplayNameFor(model => model.Supplier_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 25 "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\rfq\GetFeedback.cshtml"
       Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 28 "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\rfq\GetFeedback.cshtml"
       Write(Html.DisplayNameFor(model => model.Feedback));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FabricateApp1.Models.RfqSupplier> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
