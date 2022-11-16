using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EasyPark.Controllers
{
    public class PrestadorServicoController : Controller
    {

        [Authorize]
        public IActionResult Index()
        {
            ObterNomeUsuarioLogado();
            
            return View();
        }

        [Authorize]
        public IActionResult PrestadorServico()
        {
            ObterNomeUsuarioLogado();

            return View();
        }




        public void ObterNomeUsuarioLogado()
        {
            var obtemNomeUsuarioLogado=HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name).Value;
            ViewData["NomeUsuarioLogado"] = obtemNomeUsuarioLogado;

        }

        public int ObterIdUsuarioLogado()
        {
            var obtemIdUsuario= HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Hash).Value;
            return int.Parse(obtemIdUsuario);
        }
    }
}
