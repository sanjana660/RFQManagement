#pragma checksum "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\Supplier\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "952cee680e353e0edc06118b75a88fb8e74bfd72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Supplier_Update), @"mvc.1.0.view", @"/Views/Supplier/Update.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"952cee680e353e0edc06118b75a88fb8e74bfd72", @"/Views/Supplier/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba2b946cfa0fd2ee15e06ba58c618185ba619e88", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Supplier_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FabricateApp1.Models.Supplier>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\Supplier\Update.cshtml"
  
    ViewData["Title"] = "Update";
    Layout= "~/Views/Shared/_Afterlogin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Update Supplier Details</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\Supplier\Update.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\Supplier\Update.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizaontal\">\r\n        \r\n        <hr />\r\n        ");
#nullable restore
#line 15 "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\Supplier\Update.cshtml"
   Write(Html.ValidationSummary(true, "", new{@class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 16 "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\Supplier\Update.cshtml"
   Write(Html.HiddenFor(model => model.supplier_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 18 "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\Supplier\Update.cshtml"
       Write(Html.LabelFor(model => model.name, htmlAttributes: new {@class = "control-label col-md-2"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 20 "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\Supplier\Update.cshtml"
           Write(Html.EditorFor(model => model.name, new { htmlAttributes = new {@class = "form-control"}}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 21 "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\Supplier\Update.cshtml"
           Write(Html.ValidationMessageFor(model => model.name, "", new {@class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 25 "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\Supplier\Update.cshtml"
       Write(Html.LabelFor(model => model.email, htmlAttributes: new {@class = "control-label col-md-2"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 27 "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\Supplier\Update.cshtml"
           Write(Html.EditorFor(model => model.email, new { htmlAttributes = new {@class = "form-control"}}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 28 "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\Supplier\Update.cshtml"
           Write(Html.ValidationMessageFor(model => model.email, "", new {@class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\Supplier\Update.cshtml"
       Write(Html.LabelFor(model => model.phone, htmlAttributes: new {@class = "control-label col-md-2"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 34 "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\Supplier\Update.cshtml"
           Write(Html.EditorFor(model => model.phone, new { htmlAttributes = new {@class = "form-control"}}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 35 "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\Supplier\Update.cshtml"
           Write(Html.ValidationMessageFor(model => model.phone, "", new {@class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 39 "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\Supplier\Update.cshtml"
       Write(Html.LabelFor(model => model.location, htmlAttributes: new {@class = "control-label col-md-2"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 41 "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\Supplier\Update.cshtml"
           Write(Html.EditorFor(model => model.location, new { htmlAttributes = new {@class = "form-control"}}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 42 "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\Supplier\Update.cshtml"
           Write(Html.ValidationMessageFor(model => model.location, "", new {@class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" value=\"Update\" class=\"btn btn-primary\"/>\r\n            </div>\r\n        </div>\r\n     </div>\r\n");
#nullable restore
#line 51 "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\Supplier\Update.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    ");
#nullable restore
#line 53 "C:\Users\Sanjana\source\repos\RFQmanagement\FabricateApp1\Views\Supplier\Update.cshtml"
Write(Html.ActionLink("Back to list","Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FabricateApp1.Models.Supplier> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
