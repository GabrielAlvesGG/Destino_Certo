#pragma checksum "C:\Users\alves\OneDrive\Documentos\atividades do senac\mvc\atividade2\atividade2\Views\Clientes\ListaClientes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a49f8ce5cef909fecf7e71cbf128f7ab3456117"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clientes_ListaClientes), @"mvc.1.0.view", @"/Views/Clientes/ListaClientes.cshtml")]
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
#line 1 "C:\Users\alves\OneDrive\Documentos\atividades do senac\mvc\atividade2\atividade2\Views\_ViewImports.cshtml"
using atividade2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alves\OneDrive\Documentos\atividades do senac\mvc\atividade2\atividade2\Views\_ViewImports.cshtml"
using atividade2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a49f8ce5cef909fecf7e71cbf128f7ab3456117", @"/Views/Clientes/ListaClientes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70e2596d2250ae25f0315f06df86d7a695981233", @"/Views/_ViewImports.cshtml")]
    public class Views_Clientes_ListaClientes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Cliente>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <div class=""container"">
       
    <table class=""table"" style=""align-items: center; text-align:center; background-color: #1b6ec2; border-radius: 5px;"">
        <h1 style=""text-align: center;"">Lista de Clientes</h1>
        <thead class=""thead-dark"">
            <tr >
                <th>Id</th>
                <th>Nome</th>
                <th>Login</th>
                <th>Senha</th>
                <th>Data Nacimento</th>
                <th>Operadores</th>
            </tr>
        </thead>
        <tbody class=""text-white"">
");
#nullable restore
#line 17 "C:\Users\alves\OneDrive\Documentos\atividades do senac\mvc\atividade2\atividade2\Views\Clientes\ListaClientes.cshtml"
             foreach (Cliente item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\alves\OneDrive\Documentos\atividades do senac\mvc\atividade2\atividade2\Views\Clientes\ListaClientes.cshtml"
               Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\alves\OneDrive\Documentos\atividades do senac\mvc\atividade2\atividade2\Views\Clientes\ListaClientes.cshtml"
               Write(item.nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\alves\OneDrive\Documentos\atividades do senac\mvc\atividade2\atividade2\Views\Clientes\ListaClientes.cshtml"
               Write(item.login);

#line default
#line hidden
#nullable disable
            WriteLiteral("]</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\alves\OneDrive\Documentos\atividades do senac\mvc\atividade2\atividade2\Views\Clientes\ListaClientes.cshtml"
               Write(item.senha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\alves\OneDrive\Documentos\atividades do senac\mvc\atividade2\atividade2\Views\Clientes\ListaClientes.cshtml"
               Write(item.dataNascimento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td >\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 896, "\"", 932, 2);
            WriteAttributeValue("", 903, "/Clientes/Deletar?id=", 903, 21, true);
#nullable restore
#line 26 "C:\Users\alves\OneDrive\Documentos\atividades do senac\mvc\atividade2\atividade2\Views\Clientes\ListaClientes.cshtml"
WriteAttributeValue("", 924, item.id, 924, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color: white; text-decoration: none;\">Deletar</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1014, "\"", 1052, 2);
            WriteAttributeValue("", 1021, "/Clientes/Atualizar?id=", 1021, 23, true);
#nullable restore
#line 27 "C:\Users\alves\OneDrive\Documentos\atividades do senac\mvc\atividade2\atividade2\Views\Clientes\ListaClientes.cshtml"
WriteAttributeValue("", 1044, item.id, 1044, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color: white; text-decoration: none;\">Editar</a>\r\n                </td>\r\n            </tr>    \r\n");
#nullable restore
#line 30 "C:\Users\alves\OneDrive\Documentos\atividades do senac\mvc\atividade2\atividade2\Views\Clientes\ListaClientes.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </tbody>\r\n    </table>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Cliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
