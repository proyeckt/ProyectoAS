#pragma checksum "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Domicilio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "750c2124b27c307f28e80d0eae00292c1afe42d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CheckOut_Domicilio), @"mvc.1.0.view", @"/Views/CheckOut/Domicilio.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"750c2124b27c307f28e80d0eae00292c1afe42d0", @"/Views/CheckOut/Domicilio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb06383b5a5694749caf16873282de4c716ff561", @"/Views/_ViewImports.cshtml")]
    public class Views_CheckOut_Domicilio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PedidoVirtual>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Domicilio.cshtml"
 using (Html.BeginForm("Domicilio", "billingController", "Post"))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Domicilio.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <fieldset>\r\n");
#nullable restore
#line 9 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Domicilio.cshtml"
     if(@Model.TipoEntrega == "Domicilio")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <legend>Dirección para domicilio</legend>\r\n");
#nullable restore
#line 12 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Domicilio.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Domicilio.cshtml"
     if(@Model.TipoEntrega == "Recoger en tienda")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <legend>Direccion para ver tiendas</legend>\r\n");
#nullable restore
#line 16 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Domicilio.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"editor-label\">\r\n            ");
#nullable restore
#line 18 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Domicilio.cshtml"
       Write(Html.LabelFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");
#nullable restore
#line 21 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Domicilio.cshtml"
       Write(Html.TextBoxFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n         <div hidden>\r\n        ");
#nullable restore
#line 24 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Domicilio.cshtml"
   Write(Html.HiddenFor(model => model.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 25 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Domicilio.cshtml"
   Write(Html.HiddenFor(model => model.TipoEntrega));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 26 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Domicilio.cshtml"
   Write(Html.HiddenFor(model => model.MetodoPago));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 27 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Domicilio.cshtml"
         for(int i=0; i < Model.Productos.Count() ; i++)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Domicilio.cshtml"
       Write(Html.HiddenFor(model => Model.Productos[i]));

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Domicilio.cshtml"
       Write(Html.EditorFor(model => model.Productos[i]));

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Domicilio.cshtml"
                                                        
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n        </div>\r\n");
#nullable restore
#line 34 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Domicilio.cshtml"
         if(@Model.TipoEntrega == "Domicilio")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>\r\n                <input type=\"submit\" value=\"Pedir\" />\r\n            </p>\r\n");
#nullable restore
#line 39 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Domicilio.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Domicilio.cshtml"
     if(@Model.TipoEntrega == "Recoger en tienda")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p> \r\n                <input type=\"submit\" value=\"Ver\" />\r\n            </p>\r\n");
#nullable restore
#line 45 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Domicilio.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </fieldset>\r\n");
#nullable restore
#line 47 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Domicilio.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
