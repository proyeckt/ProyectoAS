#pragma checksum "/home/davidlopez/GitKraken/ProyectoAS/EjemploDOTNET/EjemploASP/Views/CheckOut/Pay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66d16466f26c52b29ec7a58c6ab7c5f33480324b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CheckOut_Pay), @"mvc.1.0.view", @"/Views/CheckOut/Pay.cshtml")]
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
#line 1 "/home/davidlopez/GitKraken/ProyectoAS/EjemploDOTNET/EjemploASP/Views/_ViewImports.cshtml"
using EjemploASP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/davidlopez/GitKraken/ProyectoAS/EjemploDOTNET/EjemploASP/Views/_ViewImports.cshtml"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/davidlopez/GitKraken/ProyectoAS/EjemploDOTNET/EjemploASP/Views/_ViewImports.cshtml"
using EjemploASP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66d16466f26c52b29ec7a58c6ab7c5f33480324b", @"/Views/CheckOut/Pay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb06383b5a5694749caf16873282de4c716ff561", @"/Views/_ViewImports.cshtml")]
    public class Views_CheckOut_Pay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tarjeta>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/davidlopez/GitKraken/ProyectoAS/EjemploDOTNET/EjemploASP/Views/CheckOut/Pay.cshtml"
  
    ViewData["Title"] = "Pay";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 8 "/home/davidlopez/GitKraken/ProyectoAS/EjemploDOTNET/EjemploASP/Views/CheckOut/Pay.cshtml"
 using (Html.BeginForm("PayBill", "billingController", "Post"))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/davidlopez/GitKraken/ProyectoAS/EjemploDOTNET/EjemploASP/Views/CheckOut/Pay.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <fieldset>\n        <legend>Ingreso al sistema</legend>\n        <div class=\"editor-label\">\n            ");
#nullable restore
#line 14 "/home/davidlopez/GitKraken/ProyectoAS/EjemploDOTNET/EjemploASP/Views/CheckOut/Pay.cshtml"
       Write(Html.LabelFor(model => model.NumeroTarjeta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <div class=\"editor-field\">\n            ");
#nullable restore
#line 17 "/home/davidlopez/GitKraken/ProyectoAS/EjemploDOTNET/EjemploASP/Views/CheckOut/Pay.cshtml"
       Write(Html.TextBoxFor(model => model.NumeroTarjeta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        \n        </div>\n        <div class=\"editor-label\">\n            ");
#nullable restore
#line 21 "/home/davidlopez/GitKraken/ProyectoAS/EjemploDOTNET/EjemploASP/Views/CheckOut/Pay.cshtml"
       Write(Html.LabelFor(model => model.FechaExpiracion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <div class=\"editor-field\">\n            ");
#nullable restore
#line 24 "/home/davidlopez/GitKraken/ProyectoAS/EjemploDOTNET/EjemploASP/Views/CheckOut/Pay.cshtml"
       Write(Html.TextBoxFor(model => model.FechaExpiracion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        \n        <div class=\"editor-label\">\n            ");
#nullable restore
#line 28 "/home/davidlopez/GitKraken/ProyectoAS/EjemploDOTNET/EjemploASP/Views/CheckOut/Pay.cshtml"
       Write(Html.LabelFor(model => model.CVV));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <div class=\"editor-field\">\n            ");
#nullable restore
#line 31 "/home/davidlopez/GitKraken/ProyectoAS/EjemploDOTNET/EjemploASP/Views/CheckOut/Pay.cshtml"
       Write(Html.TextBoxFor(model => model.CVV));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <p>\n            <input type=\"submit\" value=\"PayBill\" />\n        </p>\n    </fieldset>\n");
#nullable restore
#line 37 "/home/davidlopez/GitKraken/ProyectoAS/EjemploDOTNET/EjemploASP/Views/CheckOut/Pay.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tarjeta> Html { get; private set; }
    }
}
#pragma warning restore 1591
