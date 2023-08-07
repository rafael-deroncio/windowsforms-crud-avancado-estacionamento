using EstacionamentoForms.Extensions;
using EstacionamentoForms.Models;
using EstacionamentoForms.Repositories;
using EstacionamentoForms.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace EstacionamentoForms.Services
{
    public class ClienteService : IBaseService<ClienteModel>
    {
        #region Singleton
        private static ClienteService instance;
        private ClienteService() { }

        public static ClienteService GetInstance()
        {
            if (instance == null)
                instance = new ClienteService();

            return instance;
        }
        #endregion

        public bool Atualizar(ClienteModel model)
        {

            try
            {
                ClienteModel cliente = BaseRepository<ClienteModel>.Get().Recuperar(model.Id);

                if (cliente is null)
                    return false;

                cliente.NomeCompleto = model.NomeCompleto.ToTittleCase();
                cliente.Cpf = model.Cpf.ToCpfNormalized();
                cliente.NumeroCelular = model.NumeroCelular.ToNumberPhoneNormalized();

                BaseRepository<ClienteModel>.Get().Alterar(cliente);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Cadastrar(ClienteModel model)
        {
            try
            {
                model.Id= BaseRepository<ClienteModel>.Get().Recuperar().Count + 1;
                model.NomeCompleto = model.NomeCompleto.ToTittleCase();
                model.Cpf = model.Cpf.ToCpfNormalized();
                model.NumeroCelular = model.NumeroCelular.ToNumberPhoneNormalized();

                BaseRepository<ClienteModel>.Get().Salvar(model);
                return true;
            }
            catch (Exception) 
            {
                return false;
            }
        }

        public List<ClienteModel> RecuperarTodos()
        {
            return BaseRepository<ClienteModel>.Get().Recuperar();
        }
    }
}
