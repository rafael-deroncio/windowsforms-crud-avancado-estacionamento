using EstacionamentoForms.Extensions;
using EstacionamentoForms.Models;
using EstacionamentoForms.Repositories;
using EstacionamentoForms.Repositories.Interfaces;
using EstacionamentoForms.Services.Interfaces;
using EstacionamentoForms.Services.Persistence;
using System;
using System.Collections.Generic;

namespace EstacionamentoForms.Services
{
    public class VeiculoService : IBaseService<VeiculoModel>
    {
        #region Singleton
        private static VeiculoService instance;
        private VeiculoService() { }
        public static VeiculoService GetInstance()
        {
            if (instance == null)
                instance = new VeiculoService();

            return instance;
        }
        #endregion
        
        public bool Atualizar(VeiculoModel model)
        {
            try
            {
                VeiculoModel veiculo = BaseRepository<VeiculoModel>.Get().Recuperar(model.Id);

                if (veiculo is null)
                    return false;

                veiculo.Fabricante = model.Fabricante.ToTittleCase();
                veiculo.Modelo = model.Modelo.ToTittleCase();
                veiculo.Placa = model.Placa.ToUpper();
                veiculo.Cor = model.Cor.ToTittleCase();

                veiculo.IdCliente = model.IdCliente;
                veiculo.NomeCliente = model.NomeCliente.ToTittleCase();

                BaseRepository<VeiculoModel>.Get().Alterar(veiculo);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Cadastrar(VeiculoModel model)
        {
            try
            {
                model.Id = BaseRepository<VeiculoModel>.Get().Recuperar().Count + 1;
                model.Fabricante = model.Fabricante.ToTittleCase();
                model.Modelo = model.Modelo.ToTittleCase();
                model.Placa = model.Placa.ToUpper();
                model.Cor = model.Cor.ToTittleCase();

                BaseRepository<VeiculoModel>.Get().Salvar(model);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<VeiculoModel> RecuperarTodos()
        {
            return BaseRepository<VeiculoModel>.Get().Recuperar();
        }
    
        public List<string> OpcoesFabricantes()
        {
            return new List<string>
                        {
                            "Chevrolet",
                            "Ford",
                            "Volkswagen",
                            "Honda",
                            "Yamaha",
                            "Suzuki"
                        };
        }

        public List<string> OpcoesCores()
        {
            return new List<string>
                        {
                            "Preto",
                            "Branco",
                            "Prata",
                            "Vermelho",
                            "Azul",
                            "Verde"
                        };
        }
    }
}
