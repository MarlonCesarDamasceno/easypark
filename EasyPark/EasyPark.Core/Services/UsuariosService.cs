using EasyPark.EasyPark.Domain.Entitys;
using EasyPark.EasyPark.Domain.Interface.Repositorys;
using EasyPark.EasyPark.Domain.Requests;
using EasyPark.EasyPark.Domain.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyPark.EasyPark.Core.Services
{
    public class UsuariosService
    {
        private readonly IUsuariosRepository _usuariosRepository;

        public UsuariosService(IUsuariosRepository usuariosRepository)
        {
            _usuariosRepository = usuariosRepository;
        }

        public async Task<UsuariosStatusCadastroResponse> CadastrarUsuario(UsuariosRequest usuariosRequest)
        {
            var statusCadastro = new UsuariosStatusCadastroResponse();
            var MapearUsuarioRequestToEntidade = new Usuario()
            {
                Email=usuariosRequest.Email,
                NivelAcesso=usuariosRequest.NivelAcesso,
                Nome=usuariosRequest.NomeUsuario,
                Senha=usuariosRequest.Senha
            };

            var consultaCadastroExistente = _usuariosRepository.ValidaCadastroExistente(MapearUsuarioRequestToEntidade.Email);
            if(!consultaCadastroExistente)
            {
                _usuariosRepository.SalvarUsuario(MapearUsuarioRequestToEntidade);
                statusCadastro.ContaCriada = true;
            }
            else
            {
                statusCadastro.CadastroExiste = true;
            }

            return statusCadastro;
        }


    }
}
