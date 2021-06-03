#pragma checksum "/home/davidlopez/GitKraken/ProyectoAS/EjemploDOTNET/EjemploASP/Views/CheckOut/Billing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45d66c2e27e6bf8c065414a59b74b09bd1507020"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CheckOut_Billing), @"mvc.1.0.view", @"/Views/CheckOut/Billing.cshtml")]
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
#nullable restore
#line 2 "/home/davidlopez/GitKraken/ProyectoAS/EjemploDOTNET/EjemploASP/Views/CheckOut/Billing.cshtml"
using System.Web.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/davidlopez/GitKraken/ProyectoAS/EjemploDOTNET/EjemploASP/Views/CheckOut/Billing.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45d66c2e27e6bf8c065414a59b74b09bd1507020", @"/Views/CheckOut/Billing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb06383b5a5694749caf16873282de4c716ff561", @"/Views/_ViewImports.cshtml")]
    public class Views_CheckOut_Billing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PedidoVirtual>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 6 "/home/davidlopez/GitKraken/ProyectoAS/EjemploDOTNET/EjemploASP/Views/CheckOut/Billing.cshtml"
  
    ViewData["Title"] = "Billing";
    Layout = null;
    var pedido = ViewData["pedido"] as PedidoVirtual;
    var productos = ViewData["productos"] as List<Producto>;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 13 "/home/davidlopez/GitKraken/ProyectoAS/EjemploDOTNET/EjemploASP/Views/CheckOut/Billing.cshtml"
 using (Html.BeginForm("Next", "billingController"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!DOCTYPE html>\n    <html>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45d66c2e27e6bf8c065414a59b74b09bd15070204435", async() => {
                WriteLiteral("\n        <meta name=\"viewport\" content=\"width-device-width\"/>\n        \n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45d66c2e27e6bf8c065414a59b74b09bd15070205467", async() => {
                WriteLiteral("\n        <h2>Facturación</h2>\n        <b>Ítems seleccionado: </b> ");
#nullable restore
#line 23 "/home/davidlopez/GitKraken/ProyectoAS/EjemploDOTNET/EjemploASP/Views/CheckOut/Billing.cshtml"
                               Write(Model.Productos.Count());

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        <br />\n        <b>Costo total: </b> ");
#nullable restore
#line 25 "/home/davidlopez/GitKraken/ProyectoAS/EjemploDOTNET/EjemploASP/Views/CheckOut/Billing.cshtml"
                        Write(Model.Precio);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        <br />\n        <h4>Seleccione el tipo de entrega: </h4>\n\n        <div class=\"col-md-10\">  \n            Domicilio  \n            ");
#nullable restore
#line 31 "/home/davidlopez/GitKraken/ProyectoAS/EjemploDOTNET/EjemploASP/Views/CheckOut/Billing.cshtml"
       Write(Html.RadioButtonFor(model => model.TipoEntrega, "Domicilio"));

#line default
#line hidden
#nullable disable
                WriteLiteral("  \n            Recoger en tienda  \n            ");
#nullable restore
#line 33 "/home/davidlopez/GitKraken/ProyectoAS/EjemploDOTNET/EjemploASP/Views/CheckOut/Billing.cshtml"
       Write(Html.RadioButtonFor(model =>  model.TipoEntrega, "Recoger en tienda"));

#line default
#line hidden
#nullable disable
                WriteLiteral("  \n        </div>  \n\n        <h4>Método de pago </h4>\n\n        <div class=\"col-md-10\">  \n            Tarjeta de credito\n            ");
#nullable restore
#line 40 "/home/davidlopez/GitKraken/ProyectoAS/EjemploDOTNET/EjemploASP/Views/CheckOut/Billing.cshtml"
       Write(Html.RadioButtonFor(model => model.MetodoPago, "Tarjeta de credito"));

#line default
#line hidden
#nullable disable
                WriteLiteral("  \n            Pago contraentrega \n            ");
#nullable restore
#line 42 "/home/davidlopez/GitKraken/ProyectoAS/EjemploDOTNET/EjemploASP/Views/CheckOut/Billing.cshtml"
       Write(Html.RadioButtonFor(model =>  model.MetodoPago, "Pago contraentrega"));

#line default
#line hidden
#nullable disable
                WriteLiteral("  \n        </div>  \n\n        <div hidden>\n        ");
#nullable restore
#line 46 "/home/davidlopez/GitKraken/ProyectoAS/EjemploDOTNET/EjemploASP/Views/CheckOut/Billing.cshtml"
   Write(Html.HiddenFor(model => model.Precio));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        \n");
#nullable restore
#line 48 "/home/davidlopez/GitKraken/ProyectoAS/EjemploDOTNET/EjemploASP/Views/CheckOut/Billing.cshtml"
         for(int i=0; i < Model.Productos.Count() ; i++)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "/home/davidlopez/GitKraken/ProyectoAS/EjemploDOTNET/EjemploASP/Views/CheckOut/Billing.cshtml"
       Write(Html.HiddenFor(model => Model.Productos[i]));

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "/home/davidlopez/GitKraken/ProyectoAS/EjemploDOTNET/EjemploASP/Views/CheckOut/Billing.cshtml"
       Write(Html.EditorFor(model => model.Productos[i]));

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "/home/davidlopez/GitKraken/ProyectoAS/EjemploDOTNET/EjemploASP/Views/CheckOut/Billing.cshtml"
                                                        
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\n\n");
#nullable restore
#line 55 "/home/davidlopez/GitKraken/ProyectoAS/EjemploDOTNET/EjemploASP/Views/CheckOut/Billing.cshtml"
         if (ViewBag.Message != null)  
        {  

#line default
#line hidden
#nullable disable
                WriteLiteral("            <script type=\"text/javascript\">  \n                window.onload = function () {  \n                    alert(\"");
#nullable restore
#line 59 "/home/davidlopez/GitKraken/ProyectoAS/EjemploDOTNET/EjemploASP/Views/CheckOut/Billing.cshtml"
                      Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral("\");  \n                };  \n            </script>  \n");
#nullable restore
#line 62 "/home/davidlopez/GitKraken/ProyectoAS/EjemploDOTNET/EjemploASP/Views/CheckOut/Billing.cshtml"
        }  

#line default
#line hidden
#nullable disable
                WriteLiteral("                \n        <br/>\n        <a>\n            <input type=\"submit\" value=\"Siguiente\" class=\"submit\"/>\n        </a>\n        \n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </html>\n");
#nullable restore
#line 71 "/home/davidlopez/GitKraken/ProyectoAS/EjemploDOTNET/EjemploASP/Views/CheckOut/Billing.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PedidoVirtual> Html { get; private set; }
    }
}
#pragma warning restore 1591
