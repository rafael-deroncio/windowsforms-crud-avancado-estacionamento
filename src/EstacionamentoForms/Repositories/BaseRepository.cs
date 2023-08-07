using EstacionamentoForms.Configurations.Attributes;
using EstacionamentoForms.Configurations.Enum;
using EstacionamentoForms.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EstacionamentoForms.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private List<T> _dados = new List<T>();

        public virtual void Salvar(T obj)
        {
            _dados.Add(obj);
        }

        public virtual void Salvar(List<T> objs)
        {
            _dados = objs;
        }

        public virtual T Recuperar(int id)
        {
            var identifierAttribute = typeof(T).GetCustomAttributes(typeof(IdentifierAttribute), true)
                                                .FirstOrDefault() as IdentifierAttribute;

            if (identifierAttribute == null)
                throw new ArgumentException("Classe T não possui um identificador definido.");

            var identifierProperty = typeof(T).GetProperty(identifierAttribute.Identifier);

            if (identifierProperty == null)
                throw new ArgumentException($"Classe T não possui uma propriedade com o identificador '{identifierAttribute.Identifier}'.");

            var obj = _dados.Find(item => (int)identifierProperty.GetValue(item) == id);

            if (obj != null)
                return obj;
            else
                throw new ArgumentException("Objeto não encontrado.");
        }

        public virtual List<T> Recuperar()
        {
            return _dados;
        }

        public virtual void Alterar(T obj)
        {
            int index = _dados.FindIndex(item => item.Equals(obj));
            if (index >= 0)
                _dados[index] = obj;
            else
                throw new ArgumentException("Objeto não encontrado.");
        }

        public static IBaseRepository<T> Get()
        {
            // Driver atual
            DriverTypeEnum driver = Estacionamento.GetDriver();

            // Convenção RepositoryTypeName
            string repositoryTypeName = $"{driver}Repository`1";

            // Recupera Type de RepositoryTypeName
            Type repositoryType = Type.GetType($"EstacionamentoForms.Repositories.{repositoryTypeName}");

            // SeErro, retorna Exception
            if (repositoryType == null)
                throw new ArgumentException($"Não foi possível encontrar o tipo de repositório para o driver {driver}.");

            // Cria a instância de repositoryType<>
            Type genericType = repositoryType.MakeGenericType(typeof(T));
            object repositoryInstance = Activator.CreateInstance(genericType);

            // Checa se a classe possui um atributo instance -- PEND IMPLEMENTAR
            //var instanceField = repositoryType.GetField("instance", BindingFlags.Static | BindingFlags.NonPublic);
            //if (instanceField != null && instanceField.FieldType.ContainsGenericParameters == false && instanceField.GetValue(null) != null)
            //{
            //    return (IBaseRepository<T>)instanceField.GetValue(null);
            //}

            return (IBaseRepository<T>)repositoryInstance;
        }

        #region Construtor
        protected virtual string GetContexto()
        {
            // Conveção modelname
            return BaseName.GetByName(typeof(T)).ToString().ToLower();
        }

        protected virtual string GerarBaseContexto(string modelName, string modelExtencao)
        {
            string sufixo = DateTime.Now.ToString("ddMMyyyy");
            string nomeArquivo = $"base_{modelName}_{sufixo}.{modelExtencao}";

            string pathBase = Environment.CurrentDirectory
                .Replace("bin", string.Empty)
                .Replace("Debug", string.Empty)
                .Replace("\\\\", string.Empty);

            pathBase = Path.Combine(pathBase, "Driverbases", modelExtencao.ToUpper());
            var modelBase = Path.Combine(pathBase, nomeArquivo);

            if (!Directory.Exists(pathBase))
                Directory.CreateDirectory(pathBase);

            if (!File.Exists(modelBase))
                using (StreamWriter writer = File.CreateText(modelBase)) { };

            return modelBase;
        }
        #endregion
    }
}

