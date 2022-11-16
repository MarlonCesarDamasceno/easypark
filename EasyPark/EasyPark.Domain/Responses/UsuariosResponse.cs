using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyPark.EasyPark.Domain.Responses
{
    public class UsuariosResponse
    {
        public int UsuarioId { get; set; }
        public int NivelAcesso { get; set; }
        public string NomeUsuario { get; set; }

    }
}
