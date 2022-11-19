using EasyPark.EasyPark.Domain.Interface.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EasyPark.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [Authorize]
        public async Task<IActionResult> Pesquisa(string Busca)
        {
            ObterNomeUsuarioLogado();
            var realizaBusca = _clienteService.BuscaServicosAsync(Busca).Result;
            ViewBag.Pesquisa = Busca;
            return View(realizaBusca);
        }

        [Authorize]
        public IActionResult Index()
        {
            ObterNomeUsuarioLogado();
            //passa como parametro a quantidade de registro a ser retornado.
            var geraVitrine = _clienteService.ExibirServicosVitrinePrincipalAsync(2).Result;
            return View(geraVitrine);
        }



        public void ObterNomeUsuarioLogado()
        {
            var obtemNomeUsuarioLogado = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name).Value;
            ViewData["NomeUsuarioLogadoEmpresa"] = obtemNomeUsuarioLogado;

        }


    }
}
