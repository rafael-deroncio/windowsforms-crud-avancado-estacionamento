using Dapper;
using EstacionamentoForms.Configurations.Attributes;
using EstacionamentoForms.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;

namespace EstacionamentoForms.Repositories
{
    public class SqliteRepository<T> : BaseRepository<T> where T : class
    {
        private static SQLiteConnection _sqliteConnection;

        private const string _modelExtension = "db";
        private static string _modelName; // Nome da classe em T
        private static string _connectionString;

        public SqliteRepository()
        {
            _modelName = GetContexto();
            _connectionString = GetConnectionString(_modelExtension);
        }

        private static IDbConnection GetConnection() // CONNECTION
        {
            _sqliteConnection = new SQLiteConnection(_connectionString);
            _sqliteConnection.Open();
            return _sqliteConnection;
        }

        private static string GetConnectionString(string extensao)
        {
            string nomeArquivo = $"{nameof(Estacionamento)}Database.{extensao}";
            string pathBase = Environment.CurrentDirectory
                .Replace("bin", string.Empty)
                .Replace("Debug", string.Empty)
                .Replace("\\\\", string.Empty);

            pathBase = Path.Combine(pathBase, "Driverbases", "SQLITE", "Databases", nomeArquivo);

            if (File.Exists(pathBase))
                return $"Data Source={pathBase}";

            throw new FileNotFoundException($"Database {nomeArquivo} não existe no caminho pertinente!");
        }

        #region Overrides
        public override void Salvar(List<T> objs)
        {
            try
            {
                var properties = typeof(T).GetProperties();
                string columns = string.Join(", ", properties.Select(p => p.Name));
                string values = string.Join(", ", properties.Select(p => $"@{p.Name}"));

                string query = $"INSERT INTO {_modelName} ({columns}) VALUES ({values})";

                using (IDbConnection conexao = GetConnection())
                {
                    foreach (var item in objs)
                    {
                        conexao.Execute(query, item);
                    };
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override void Salvar(T obj)
        {
            try
            {
                Salvar(new List<T>() { obj });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override List<T> Recuperar()
        {
            try
            {
                StringBuilder query = new StringBuilder();
                query.AppendLine("SELECT * ");
                query.AppendLine($"FROM {_modelName.ToTittleCase()} ");

                using (IDbConnection conexao = GetConnection())
                {
                    return conexao.Query<T>(query.ToString()).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override void Alterar(T obj)
        {
            try
            {
                // Recuperando atributo identificador
                var identifierAttribute = typeof(T).GetCustomAttributes(typeof(IdentifierAttribute), true).FirstOrDefault() as IdentifierAttribute;

                if (identifierAttribute is null)
                    throw new ArgumentException("Objeto não possui um identificador definido.");

                var identifierProperty = typeof(T).GetProperty(identifierAttribute.Identifier);

                if (identifierProperty is null)
                    throw new ArgumentException($"Objeto não possui uma propriedade com o identificador '{identifierAttribute.Identifier}'.");

                // Recupera nome e valor da propriedade anotada com IdentifierAttribute
                var identifierName = identifierProperty.Name;
                var identifierValue = identifierProperty.GetValue(obj);
                var identifierType = identifierValue.GetType();

                // Recupera o objeto com o identificador especificado
                var objectT = Recuperar().FirstOrDefault(item => identifierValue.Equals(Convert.ChangeType(identifierProperty.GetValue(item), identifierType)));

                using (IDbConnection conexao = GetConnection())
                {
                    StringBuilder queryBuilder = new StringBuilder();
                    queryBuilder.AppendLine($"UPDATE {_modelName.ToTittleCase()} ");
                    queryBuilder.AppendLine("SET " + string.Join(", ", typeof(T).GetProperties().Select(p => $"{p.Name} = @{p.Name}")));
                    queryBuilder.AppendLine($"WHERE {identifierName} = @{identifierName}");

                    var query = queryBuilder.ToString();

                    conexao.Execute(query, obj);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override T Recuperar(int id)
        {
            try
            {
                var identifierAttribute = typeof(T).GetCustomAttributes(typeof(IdentifierAttribute), true)
                                                    .FirstOrDefault() as IdentifierAttribute;

                if (identifierAttribute is null)
                    throw new ArgumentException("Classe T não possui um identificador definido.");

                var identifierProperty = typeof(T).GetProperty(identifierAttribute.Identifier);

                if (identifierProperty is null)
                    throw new ArgumentException($"Classe T não possui uma propriedade com o identificador '{identifierAttribute.Identifier}'.");

                // Recupera o objeto com o identificador especificado
                var obj = Recuperar().Find(item => (int)identifierProperty.GetValue(item) == id);

                // Se o objeto for encontrado, recupera o nome e o valor das propriedades
                if (obj is null)
                    throw new ArgumentException("Objeto não encontrado.");

                var property = typeof(T).GetProperties()[0];
                Type identifierPropertyType = identifierProperty.PropertyType;
                string identifierPropertyName = identifierProperty.Name;
                object identifierPropertyValue = Convert.ChangeType(identifierProperty.GetValue(obj), identifierPropertyType);

                StringBuilder query = new StringBuilder();
                query.AppendLine("SELECT * ");
                query.AppendLine($"FROM {_modelName.ToTittleCase()} ");
                query.AppendLine($"WHERE {identifierPropertyName} = {identifierPropertyValue}");

                using (IDbConnection conexao = GetConnection())
                {
                    return conexao.QueryFirstOrDefault<T>(query.ToString());
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
