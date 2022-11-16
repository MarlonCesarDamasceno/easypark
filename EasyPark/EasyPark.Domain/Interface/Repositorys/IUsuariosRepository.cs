using EasyPark.EasyPark.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyPark.EasyPark.Domain.Interface.Repositorys
{
    public interface IUsuariosRepository
    {
        void SalvarUsuario(Usuario usuario);
        bool ValidaCadastroExistente(string email);
    }
}
