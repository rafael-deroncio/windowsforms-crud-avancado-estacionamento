using EstacionamentoForms.Configurations.Enum;
using EstacionamentoForms.Repositories;
using EstacionamentoForms.Repositories.Interfaces;
using System;
using System.Reflection;

namespace EstacionamentoForms.Services.Persistence
{
    public class RepositoryType<T>
    {
        #region Singleton
        private static RepositoryType<T> instance;
        private static Nullable<DriverTypeEnum> driver;
        public RepositoryType() { }
        public static RepositoryType<T> GetInstance()
        {
            if (driver is null || Estacionamento.GetDriver() != driver.Value)
            {
                instance = null;
                driver = Estacionamento.GetDriver();
            }

            if(instance is null)
                instance = new RepositoryType<T>();

            return instance;
        }
        #endregion
    }
}

#region
// RepositoryType<T> _repository = RepositoryType<T>.GetInstance().GetRepository()
#endregion