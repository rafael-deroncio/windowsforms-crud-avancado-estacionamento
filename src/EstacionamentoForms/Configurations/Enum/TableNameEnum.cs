using EstacionamentoForms.Configurations.Enum;
using EstacionamentoForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamentoForms.Configurations.Enum
{
    public enum BaseNameEnum
    {
        Clientes,
        Veiculos,
        Tickets,
        Movimentacoes
    }

    public static class BaseName
    {
        private static readonly IReadOnlyDictionary<Type, BaseNameEnum> Descriptions = new Dictionary<Type, BaseNameEnum>()
        {
            { typeof(ClienteModel), BaseNameEnum.Clientes },
            { typeof(VeiculoModel), BaseNameEnum.Veiculos },
            { typeof(TicketModel), BaseNameEnum.Tickets },
            { typeof(MovimentacaoModel), BaseNameEnum.Movimentacoes }
        };

        public static BaseNameEnum GetByName(Type type)
        {
            if (Descriptions.TryGetValue(type, out var value))
                return value;

            throw new ArgumentException($"O tipo '{type.FullName}' não existe no dicionário.", nameof(type));
        }

        public static IEnumerable<Type> GetTypes()
        {
            return Descriptions.Keys;
        }
    }
}
