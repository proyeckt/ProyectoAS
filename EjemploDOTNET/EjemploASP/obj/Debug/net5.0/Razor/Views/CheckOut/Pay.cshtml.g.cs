#pragma checksum "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Pay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e93e83dd6018c9d25d12b412ab36442a6ef9ca6"
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
#line 1 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\_ViewImports.cshtml"
using EjemploASP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\_ViewImports.cshtml"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\_ViewImports.cshtml"
using EjemploASP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e93e83dd6018c9d25d12b412ab36442a6ef9ca6", @"/Views/CheckOut/Pay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb06383b5a5694749caf16873282de4c716ff561", @"/Views/_ViewImports.cshtml")]
    public class Views_CheckOut_Pay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PedidoVirtual>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Pay.cshtml"
  
    ViewData["Title"] = "Pay";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Pay.cshtml"
 using (Html.BeginForm("PayBill", "billingController", "Post"))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Pay.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <fieldset>\r\n        <legend>Facturación</legend>\r\n        <div class=\"editor-label\">\r\n            ");
#nullable restore
#line 14 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Pay.cshtml"
       Write(Html.LabelFor(model => model.Tarjeta.NumeroTarjeta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");
#nullable restore
#line 17 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Pay.cshtml"
       Write(Html.TextBoxFor(model => model.Tarjeta.NumeroTarjeta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        \r\n        </div>\r\n        <div class=\"editor-label\">\r\n            ");
#nullable restore
#line 21 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Pay.cshtml"
       Write(Html.LabelFor(model => model.Tarjeta.FechaExpiracion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");
#nullable restore
#line 24 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Pay.cshtml"
       Write(Html.TextBoxFor(model => model.Tarjeta.FechaExpiracion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        \r\n        <div class=\"editor-label\">\r\n            ");
#nullable restore
#line 28 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Pay.cshtml"
       Write(Html.LabelFor(model => model.Tarjeta.CVV));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");
#nullable restore
#line 31 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Pay.cshtml"
       Write(Html.TextBoxFor(model => model.Tarjeta.CVV));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        ");
#nullable restore
#line 33 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Pay.cshtml"
   Write(Html.HiddenFor(model => model.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 34 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Pay.cshtml"
   Write(Html.HiddenFor(model => model.MetodoPago));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 35 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Pay.cshtml"
   Write(Html.HiddenFor(model => model.TipoEntrega));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 36 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Pay.cshtml"
   Write(Html.HiddenFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <div hidden>\r\n");
#nullable restore
#line 39 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Pay.cshtml"
         for(int i=0; i < Model.Productos.Count() ; i++)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Pay.cshtml"
       Write(Html.HiddenFor(model => Model.Productos[i]));

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Pay.cshtml"
       Write(Html.EditorFor(model => model.Productos[i]));

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Pay.cshtml"
                                                        
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <p>\r\n            <input type=\"submit\" value=\"PayBill\" />\r\n        </p>\r\n    </fieldset>\r\n");
#nullable restore
#line 49 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Pay.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PedidoVirtual> Html { get; private set; }
    }
}
#pragma warning restore 1591
