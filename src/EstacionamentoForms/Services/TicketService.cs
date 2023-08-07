using EstacionamentoForms.Models;
using EstacionamentoForms.Repositories;
using EstacionamentoForms.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace EstacionamentoForms.Services
{
    public class TicketService : IBaseService<TicketModel>
    {
        #region Singleton
        private static TicketService instance;
        private TicketService() { }
        public static TicketService GetInstance()
        {
            if (instance is null)
                instance = new TicketService();
            return instance;
        }
        #endregion

        public bool Atualizar(TicketModel model)
        {
            try
            {
                TicketModel ticket = BaseRepository<TicketModel>.Get().Recuperar(model.Id);

                if (ticket is null)
                    throw new Exception();

                model = AtualizarTicket(model);

                BaseRepository<TicketModel>.Get().Alterar(model);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Cadastrar(TicketModel model)
        {
            try
            {
                model = AtualizarTicket(model);
                BaseRepository<TicketModel>.Get().Salvar(model);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<TicketModel> RecuperarTodos()
        {
            List<TicketModel> tickets = BaseRepository<TicketModel>.Get().Recuperar();
            tickets.ForEach(ticket => { AtualizarTicket(ticket); });
            return tickets;
        }

        public bool IniciarTcket(TicketModel model)
        {
            try
            {
                model.Ativo = true;
                model = AtualizarTicket(model);
                Atualizar(model);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool FecharTicket(TicketModel model)
        {
            try
            {
                model.Ativo = false;
                model.Saida = DateTime.Now;
                model = AtualizarTicket(model);
                Atualizar(model);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private TicketModel AtualizarTicket(TicketModel model)
        {
            // Detalhes Ticket
            model.Id = model.Id == 0 ? BaseRepository<TicketModel>.Get().Recuperar().Count + 1 : model.Id;
            model.TempoEstacionado = AtualizaTempoEstacionado(model);
            model.ValorTicket = AtualizaValorEstacionamento(model);

            return model;
        }

        private string AtualizaTempoEstacionado(TicketModel model)
        {
            if (model.Ativo)
            {
                Nullable<int> tempoEstacionado;
                tempoEstacionado = (int)(DateTime.Now - model.Entrada).TotalMinutes;
                return TimeSpan.FromMinutes(tempoEstacionado.GetValueOrDefault()).ToString(@"hh\:mm\:ss");
            }

            if (model.TempoEstacionado is null)
                return TimeSpan.FromMinutes(0).ToString(@"hh\:mm\:ss");

            return model.TempoEstacionado;
        }

        private string AtualizaValorEstacionamento(TicketModel model)
        {
            Nullable<int> tempoEstacionado;            

            if (model.Ativo)
            {
                tempoEstacionado = (int)(DateTime.Now - model.Entrada).TotalMinutes;
            }
            else
            {
                if (model.Saida.HasValue)
                    tempoEstacionado = (int)(model.Saida.Value - model.Entrada).TotalMinutes;
                else
                    tempoEstacionado = 0;
            }
                
            return $"R$ {(tempoEstacionado.GetValueOrDefault() * double.Parse(model.ValorPorMinuto.Replace("R$ ", string.Empty).Trim())):F2}";
        }
    }
}
