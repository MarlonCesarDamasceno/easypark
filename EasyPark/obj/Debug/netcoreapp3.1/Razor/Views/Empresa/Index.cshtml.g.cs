#pragma checksum "C:\Users\Dell\Documents\Projetos\ProjetoParticular\easypark\EasyPark\Views\Empresa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53536c418b6a8e9fe3489c0b838ac19e968352ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empresa_Index), @"mvc.1.0.view", @"/Views/Empresa/Index.cshtml")]
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
#line 1 "C:\Users\Dell\Documents\Projetos\ProjetoParticular\easypark\EasyPark\Views\_ViewImports.cshtml"
using EasyPark;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dell\Documents\Projetos\ProjetoParticular\easypark\EasyPark\Views\_ViewImports.cshtml"
using EasyPark.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dell\Documents\Projetos\ProjetoParticular\easypark\EasyPark\Views\_ViewImports.cshtml"
using EasyPark.EasyPark.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53536c418b6a8e9fe3489c0b838ac19e968352ba", @"/Views/Empresa/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39a2c0adaec0edc41b124dad455a9936b5647723", @"/Views/_ViewImports.cshtml")]
    public class Views_Empresa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Dell\Documents\Projetos\ProjetoParticular\easypark\EasyPark\Views\Empresa\Index.cshtml"
  
    ViewData["Title"] = "Home Empresa";
    Layout = "~/Views/Shared/_LayoutEmpresa.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div dlass=\"col-md-12\">\r\n        <h2>??rea do administrador</h2>\r\n        <p class=\"text-justify\">Ol?? ");
#nullable restore
#line 10 "C:\Users\Dell\Documents\Projetos\ProjetoParticular\easypark\EasyPark\Views\Empresa\Index.cshtml"
                               Write(ViewData["NomeUsuarioLogadoEmpresa"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" seja bem-vindo (a) a sua tela de administrador.</p>
        <p class=""text-justify"">Aqui voc?? poder?? cadastrar e gerenciar os estacionamentos que voc?? administra.<br />
        Nota: voc?? poder?? cadastrar quantos estacionamentos desejar uma vez que os mesmos estar??o sempre atrelados ao seu perfil.
        </p>
        <p class=""text--justify"">Expanda o menu para ter acesso as op????es do sistema.</p>
    </div>

</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
