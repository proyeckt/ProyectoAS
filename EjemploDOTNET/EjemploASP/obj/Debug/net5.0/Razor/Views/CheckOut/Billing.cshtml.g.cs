#pragma checksum "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Billing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d47a8158a64f2625bbef58afc94869592dece329"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d47a8158a64f2625bbef58afc94869592dece329", @"/Views/CheckOut/Billing.cshtml")]
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Billing.cshtml"
  
    ViewData["Title"] = "Billing";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!-- var productos = ViewData[\"Cart\"] as List<Producto>;\r\n    var precio = ViewData[\"Precio\"]; -->\r\n");
#nullable restore
#line 8 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Billing.cshtml"
    var pedido = ViewData["Pedido"] as PedidoVirtual; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Billing.cshtml"
 using (Html.BeginForm("Next", "billingController"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!DOCTYPE html>\r\n    <html>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d47a8158a64f2625bbef58afc94869592dece3294415", async() => {
                WriteLiteral("\r\n        <meta name=\"viewport\" content=\"width-device-width\"/>\r\n        \r\n    ");
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d47a8158a64f2625bbef58afc94869592dece3295469", async() => {
                WriteLiteral("\r\n        <h2>Facturación</h2>\r\n        <b>Ítems seleccionado: </b> ");
#nullable restore
#line 21 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Billing.cshtml"
                               Write(pedido.Productos.Count());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <br />\r\n        <b>Costo total: </b> ");
#nullable restore
#line 23 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Billing.cshtml"
                        Write(pedido.Precio);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <br />\r\n        <h3>Seleccione el tipo de entrega: </h3>\r\n\r\n        <div class=\"col-md-10\">  \r\n            Domicilio  \r\n            ");
#nullable restore
#line 29 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Billing.cshtml"
       Write(Html.RadioButtonFor(model => model.TipoEntrega, "Domicilio"));

#line default
#line hidden
#nullable disable
                WriteLiteral("  \r\n            Recoger en tienda  \r\n            ");
#nullable restore
#line 31 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Billing.cshtml"
       Write(Html.RadioButtonFor(model =>  model.TipoEntrega, "Recoger en tienda"));

#line default
#line hidden
#nullable disable
                WriteLiteral("  \r\n        </div>  \r\n\r\n        <h3>Seleccione el método de pago</h3>\r\n\r\n        <div class=\"col-md-10\">  \r\n            Tarjeta Credito  \r\n            ");
#nullable restore
#line 38 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Billing.cshtml"
       Write(Html.RadioButtonFor(model => model.MetodoPago, "Tarjeta Credito"));

#line default
#line hidden
#nullable disable
                WriteLiteral("  \r\n            Pago contra entrega\r\n            ");
#nullable restore
#line 40 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Billing.cshtml"
       Write(Html.RadioButtonFor(model =>  model.MetodoPago, "Pago contra entrega"));

#line default
#line hidden
#nullable disable
                WriteLiteral("  \r\n        </div>  \r\n       \r\n        <p>\r\n            <input type=\"submit\" value=\"Siguiente\"/>\r\n        </p>\r\n        \r\n    ");
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
            WriteLiteral("\r\n    </html>\r\n");
#nullable restore
#line 49 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Billing.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Billing.cshtml"
 using (Html.BeginForm("billingController","GoBack"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a href=\"../billingController/GoBack\">\r\n        <input type=\"button\" value=\"Cancelar\" />\r\n    </a>\r\n");
#nullable restore
#line 55 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\CheckOut\Billing.cshtml"
        
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
