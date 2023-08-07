using EstacionamentoForms.Configurations.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EstacionamentoForms.Repositories
{
    public class JsonRepository<T> : BaseRepository<T> where T : class
    {
        const string _modelExtension = "json";
        string _modelName; // Nome da classe em T
        string _modelBase; // caminho base para ./Driverbases/.../{file}

        public JsonRepository()
        {
            _modelName = GetContexto();
            _modelBase = GerarBaseContexto(_modelName, _modelExtension);
        }

        #region Overrides
        public override void Salvar(List<T> objs)
        {
            try
            {
                string json = JsonConvert.SerializeObject(objs);
                using (StreamWriter writer = new StreamWriter(_modelBase, false))
                {
                    writer.WriteLine(json);
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
                List<T> objs = Recuperar();
                objs.Add(obj);

                string json = JsonConvert.SerializeObject(objs);
                
                using (StreamWriter writer = new StreamWriter(_modelBase, false))
                {
                    writer.WriteLine(json);
                }
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
                using (StreamReader reader = new StreamReader(_modelBase, true))
                {
                    string json = reader.ReadToEnd();
                    List<T> objs = new List<T>();

                    if (json == string.Empty)
                        return objs;

                    objs.AddRange(JsonConvert.DeserializeObject<List<T>>(json));
                    return objs;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override void Alterar(T obj)
        {
            var identifierAttribute = typeof(T).GetCustomAttributes(typeof(IdentifierAttribute), true).FirstOrDefault() as IdentifierAttribute;

            if (identifierAttribute == null)
                throw new ArgumentException("Classe T não possui um identificador definido.");

            var identifierProperty = typeof(T).GetProperty(identifierAttribute.Identifier);

            if (identifierProperty == null)
                throw new ArgumentException($"Classe T não possui uma propriedade com o identificador '{identifierAttribute.Identifier}'.");

            var objetos = Recuperar().Select(objeto =>
            {
                if ((int)identifierProperty.GetValue(objeto) == (int)identifierProperty.GetValue(obj))
                    objeto = obj;
                return objeto;
            }).ToList();

            Salvar(objetos);
        }

        public override T Recuperar(int id)
        {
            var identifierAttribute = typeof(T).GetCustomAttributes(typeof(IdentifierAttribute), true)
                                                .FirstOrDefault() as IdentifierAttribute;

            if (identifierAttribute == null)
                throw new ArgumentException("Classe T não possui um identificador definido.");

            var identifierProperty = typeof(T).GetProperty(identifierAttribute.Identifier);

            if (identifierProperty == null)
                throw new ArgumentException($"Classe T não possui uma propriedade com o identificador '{identifierAttribute.Identifier}'.");

            var obj = Recuperar().Find(item => (int)identifierProperty.GetValue(item) == id);

            if (obj != null)
                return obj;
            else
                throw new ArgumentException("Objeto não encontrado.");
        }
        #endregion
    }
}
