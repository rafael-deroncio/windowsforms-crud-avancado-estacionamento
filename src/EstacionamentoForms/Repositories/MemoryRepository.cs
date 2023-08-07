using EstacionamentoForms.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamentoForms.Repositories
{
    public class MemoryRepository<T> : BaseRepository<T> where T : class
    {
        #region Singleton
        private static MemoryRepository<T> instance = new MemoryRepository<T>();
        public MemoryRepository() { }
        public static MemoryRepository<T> GetInstance()
        {
            return instance;
        }
        #endregion
    }
}

