using EstacionamentoForms.Models;
using EstacionamentoForms.Repositories;
using EstacionamentoForms.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EstacionamentoForms.Services
{
    public class MovimentacaoService : IBaseService<MovimentacaoModel> 
    {
        #region Singleton
        private static MovimentacaoService instance;
        private MovimentacaoService()
        { }
        public static MovimentacaoService GetInstance()
        {
            if (instance is null)
                instance = new MovimentacaoService();
            return instance;
        }
        #endregion

        public MovimentacaoModel RecuperarAtual(bool driverAlterado = false)
        {
            try
            {
                var movimentacao = BaseRepository<MovimentacaoModel>.Get().Recuperar()
                    .OrderByDescending(x => x.Id)
                    .ThenByDescending(x => x.DataCadastro)
                    .FirstOrDefault();

                if(movimentacao is null)
                    throw new ArgumentNullException(nameof(movimentacao));

                return AtualizarMovimentacao(movimentacao, driverAlterado); ;
            }
            catch (Exception)
            {
                var novaMovimentacao = AtualizarMovimentacao(new MovimentacaoModel());
                novaMovimentacao.Id = BaseRepository<MovimentacaoModel>.Get().Recuperar().Count + 1;
                novaMovimentacao.ValorPorMinuto = $"R$ {AjusteDePrecoForm.GetValorAtual():F2}";
                BaseRepository<MovimentacaoModel>.Get().Salvar(novaMovimentacao);

                return novaMovimentacao;
            }
        }

        public bool Atualizar(MovimentacaoModel model)
        {
            BaseRepository<MovimentacaoModel>.Get().Alterar(AtualizarMovimentacao(model));
            return true;
        }

        public bool Cadastrar(MovimentacaoModel model)
        {
            try
            {
                model.Id = BaseRepository<MovimentacaoModel>.Get().Recuperar().Count + 1;
                BaseRepository<MovimentacaoModel>.Get().Salvar(AtualizarMovimentacao(model));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<MovimentacaoModel> RecuperarTodos()
        {
            return BaseRepository<MovimentacaoModel>.Get().Recuperar();
        }

        #region Privados
        private MovimentacaoModel AtualizarMovimentacao(MovimentacaoModel model, bool driverAlterado = false)
        {
            int totalVagas = Estacionamento.GetVagas();
            int totalTicketsAtivos = TicketService.GetInstance().RecuperarTodos().Count(tickt => tickt.Ativo);
            int totalVagasDisponiveis = totalVagas - totalTicketsAtivos;


            var movimentacaoBase = BaseRepository<MovimentacaoModel>.Get().Recuperar().FirstOrDefault(x => x.Id == model.Id);
            if (movimentacaoBase is null)
                model.ValorPorMinuto = model.ValorPorMinuto != $"R$ {AjusteDePrecoForm.GetValorAtual():F2}"
                     ? model.ValorPorMinuto : $"R$ {AjusteDePrecoForm.GetValorAtual():F2}";
            else
                model.ValorPorMinuto = movimentacaoBase.ValorPorMinuto;

            model.TotalVagasDisponiveis = 
                $"{totalVagasDisponiveis} " 
                + (totalVagasDisponiveis == 1 ? "Vaga" : "Vagas");

            model.TotalVeiculosEstacionados =
                $"{totalTicketsAtivos} "
                + (totalVagasDisponiveis == 1 ? "Veículo" : "Veículos");

            model.TemVagaDisponivel = totalVagasDisponiveis > 0;
            return model;
        }
        #endregion
    }
}
