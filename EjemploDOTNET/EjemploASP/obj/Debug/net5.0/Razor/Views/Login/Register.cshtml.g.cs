#pragma checksum "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\Login\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c9bbeffcb97671d220f12183ab66d1f605e2b7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Register), @"mvc.1.0.view", @"/Views/Login/Register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c9bbeffcb97671d220f12183ab66d1f605e2b7c", @"/Views/Login/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb06383b5a5694749caf16873282de4c716ff561", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Usuario>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\Login\Register.cshtml"
  
    ViewData["Title"] = "Register";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\Login\Register.cshtml"
 using (Html.BeginForm("Register", "LoginController", "Post"))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\Login\Register.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <fieldset>\r\n        <legend>Registrase en el sistema</legend>\r\n        <div class=\"editor-label\">\r\n            ");
#nullable restore
#line 14 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\Login\Register.cshtml"
       Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");
#nullable restore
#line 17 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\Login\Register.cshtml"
       Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 18 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\Login\Register.cshtml"
       Write(Html.ValidationMessageFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"editor-label\">\r\n            ");
#nullable restore
#line 22 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\Login\Register.cshtml"
       Write(Html.LabelFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");
#nullable restore
#line 25 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\Login\Register.cshtml"
       Write(Html.TextBoxFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 26 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\Login\Register.cshtml"
       Write(Html.ValidationMessageFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-label\" >\r\n            ");
#nullable restore
#line 29 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\Login\Register.cshtml"
       Write(Html.LabelFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");
#nullable restore
#line 32 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\Login\Register.cshtml"
       Write(Html.TextBoxFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 33 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\Login\Register.cshtml"
       Write(Html.ValidationMessageFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n       <p>\r\n            <input type=\"submit\" value=\"Registrarse\" />\r\n        </p>\r\n    </fieldset>\r\n");
#nullable restore
#line 39 "C:\Users\dadav\Desktop\Arqui\ProyectoAS\EjemploDOTNET\EjemploASP\Views\Login\Register.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591