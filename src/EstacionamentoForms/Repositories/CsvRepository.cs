using CsvHelper;
using EstacionamentoForms.Configurations.Attributes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace EstacionamentoForms.Repositories
{
    public class CsvRepository<T> : BaseRepository<T> where T : class
    {
        const string _modelExtencao = "csv";
        string _modelName; // Nome da classe em T
        string _modelBase; // caminho base para ./Driverbases/.../{file}

        public CsvRepository()
        {
            _modelName = GetContexto();
            _modelBase = GerarBaseContexto(_modelName, _modelExtencao);
        }

        #region Overrides
        public override void Salvar(List<T> objs)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(_modelBase, false))
                {
                    using (CsvWriter csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                    {
                        csv.WriteRecords(objs);
                    }
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
                bool contemRegistros = Recuperar().Any();
                using (StreamWriter writer = new StreamWriter(_modelBase, true))
                {
                    using (CsvWriter csv = new CsvWriter(writer, CultureInfo.InvariantCulture)) // , 
                    {
                        if (!contemRegistros)
                        {
                            csv.WriteRecords(new List<T>() { obj });
                        }
                        else
                        {
                            csv.WriteRecord(obj);
                            csv.NextRecord();
                        }
                    }
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
                using (StreamReader reader = new StreamReader(_modelBase))
                using (CsvReader csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    return csv.GetRecords<T>().ToList();
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