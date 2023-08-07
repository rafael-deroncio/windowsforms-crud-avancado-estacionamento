using EstacionamentoForms.Configurations.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamentoForms.Configurations.Enum
{
    public enum DriverTypeEnum
    {
        Memory,
        Sqlite,
        Json,
        Csv
    }
}

public static class DriverType
{
    private static readonly IReadOnlyDictionary<string, DriverTypeEnum> Descriptions = new Dictionary<string, DriverTypeEnum>()
    {
        { "Memória Volátil", DriverTypeEnum.Memory },
        { "Database - Sqlite", DriverTypeEnum.Sqlite },
        { "Arquivo JSON", DriverTypeEnum.Json },
        { "Aquivo CSV", DriverTypeEnum.Csv }
    };

    public static DriverTypeEnum GetByKey(string key)
    {
        if (Descriptions.TryGetValue(key, out var value))
            return value;

        throw new ArgumentException($"A chave '{key}' não existe no dicionário.", nameof(key));
    }

    public static IEnumerable<string> GetKeys()
    {
        return Descriptions.Keys;
    }
}