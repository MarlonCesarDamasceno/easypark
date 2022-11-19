using EasyPark.EasyPark.Domain.Interface.Repositorys;
using EasyPark.EasyPark.Domain.Interface.Services;
using EasyPark.EasyPark.Domain.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyPark.EasyPark.Core.Services
{
    public class ClienteService: IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<VitrineServicos> ExibirServicosVitrinePrincipalAsync(int totalRegistro)
        {
            try
            {
                

                var obtemVitrinePrestadorServicos = _clienteRepository.ObtemListaGeralPrestadorServicosAsync(totalRegistro).Result;
                var obtemVitrineEstacionamentos = _clienteRepository.ObtemListaGeralEstacionamentosAsync(totalRegistro).Result;

                var vitrineServicos = new VitrineServicos();
                var listPrestadorServico = new List<PrestadorServicoResponse>();
                var listEstacionamento = new List<EstacionamentoResponse>();

                foreach (var selecionePrestadorServico in obtemVitrinePrestadorServicos)
                {
                   listPrestadorServico.Add(new PrestadorServicoResponse()
                    {
                        Endereco = selecionePrestadorServico.Endereco,
                        Estado = selecionePrestadorServico.EstadoNavigation.NomeEstado,
                        HorarioFuncionamento = selecionePrestadorServico.HorarioFuncionamento,
                        NomePrestador = selecionePrestadorServico.NomePrestador,
                        NomeResponsavel = selecionePrestadorServico.PrestadorCriadorNavigation.Nome,
                        NomeServico = selecionePrestadorServico.NomeServico,
                        TelefonePrestador = selecionePrestadorServico.TelefonePrestador
                                            });
                }

                vitrineServicos.VitrinePrestadoresServicos = listPrestadorServico;


                foreach (var selecioneEstacionamento in obtemVitrineEstacionamentos)
                {
                   listEstacionamento.Add(new EstacionamentoResponse()
                    {
                        Endereco=selecioneEstacionamento.Endereco,
                        HorarioFuncionamento=selecioneEstacionamento.HorarioFuncionamento,
                        NomeEstacionamento=selecioneEstacionamento.NomeEstacionamento,
                        NomeEstado=selecioneEstacionamento.EstadoNavigation.NomeEstado,
                        NomeResponsavel=selecioneEstacionamento.UsuarioCriadorNavigation.Nome,
                        Telefone=selecioneEstacionamento.Telefone,   
                        TotaisVagas=selecioneEstacionamento.TotaisVagas,
                        VagasComuns=selecioneEstacionamento.VagasComuns,
                        VagasEletricas=selecioneEstacionamento.VagasEletricas,
                        VagasPreferenciais=selecioneEstacionamento.VagasPreferenciais
                    });
                        


                }

                vitrineServicos.VitrineEstacionamento = listEstacionamento;
                return vitrineServicos;
            }


            catch (Exception EX)
            {
                throw new Exception(EX.Message);
            }
        }

        public async Task<VitrineServicos> BuscaServicosAsync(string servicoBuscado)
        {
            try
            {
                return _clienteRepository.BuscarServicosVitrine(servicoBuscado).Result;
            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message);
            }
        }


    }
}
