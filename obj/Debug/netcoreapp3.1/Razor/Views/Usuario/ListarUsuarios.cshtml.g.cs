#pragma checksum "C:\Users\Acer\Desktop\Biblioteca\Views\Usuario\ListarUsuarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41ffaa699224b71e5f78ae13404af3c9d8cd459e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_ListarUsuarios), @"mvc.1.0.view", @"/Views/Usuario/ListarUsuarios.cshtml")]
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
#line 1 "C:\Users\Acer\Desktop\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Acer\Desktop\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41ffaa699224b71e5f78ae13404af3c9d8cd459e", @"/Views/Usuario/ListarUsuarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_ListarUsuarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Usuários Cadastrado no Sistema </h1>\r\n<p class=\"text-danger\">");
#nullable restore
#line 4 "C:\Users\Acer\Desktop\Biblioteca\Views\Usuario\ListarUsuarios.cshtml"
                  Write(ViewData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n        <th scope=\"row\">Nome</th>\r\n        <th scope=\"row\">Login</th>\r\n        <th scope=\"row\">Tipo</th>\r\n        </tr>\r\n\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 16 "C:\Users\Acer\Desktop\Biblioteca\Views\Usuario\ListarUsuarios.cshtml"
         foreach (Usuario u in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n             <td>");
#nullable restore
#line 19 "C:\Users\Acer\Desktop\Biblioteca\Views\Usuario\ListarUsuarios.cshtml"
            Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n             <td>");
#nullable restore
#line 20 "C:\Users\Acer\Desktop\Biblioteca\Views\Usuario\ListarUsuarios.cshtml"
            Write(u.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 21 "C:\Users\Acer\Desktop\Biblioteca\Views\Usuario\ListarUsuarios.cshtml"
              if(u.Tipo==Usuario.ADMIN)
             {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Administrador</td>\r\n");
#nullable restore
#line 24 "C:\Users\Acer\Desktop\Biblioteca\Views\Usuario\ListarUsuarios.cshtml"
             }
             else
             {

#line default
#line hidden
#nullable disable
            WriteLiteral("              <td>Padrão</td>\r\n");
#nullable restore
#line 28 "C:\Users\Acer\Desktop\Biblioteca\Views\Usuario\ListarUsuarios.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n              <td><a");
            BeginWriteAttribute("href", " href=\"", 666, "\"", 695, 2);
            WriteAttributeValue("", 673, "editarUsuario?id=", 673, 17, true);
#nullable restore
#line 30 "C:\Users\Acer\Desktop\Biblioteca\Views\Usuario\ListarUsuarios.cshtml"
WriteAttributeValue("", 690, u.Id, 690, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></td>\r\n              \r\n              <td><a");
            BeginWriteAttribute("href", " href=\"", 750, "\"", 780, 2);
            WriteAttributeValue("", 757, "excluirUsuario?id=", 757, 18, true);
#nullable restore
#line 32 "C:\Users\Acer\Desktop\Biblioteca\Views\Usuario\ListarUsuarios.cshtml"
WriteAttributeValue("", 775, u.Id, 775, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Excluir</a></td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 35 "C:\Users\Acer\Desktop\Biblioteca\Views\Usuario\ListarUsuarios.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(" </tbody>\r\n</table>\r\n<a href=\"RegistrarUsuarios\">Registrar um novo usuário</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591