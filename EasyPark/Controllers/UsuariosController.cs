using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyPark.Controllers
{
    public class UsuariosController : Controller
    {

        public IActionResult NovoUsuario()
        {
            return View();
        }

    }
}
