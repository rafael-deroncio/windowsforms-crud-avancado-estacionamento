using EstacionamentoForms.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamentoForms.Services
{
    internal interface IUnitOfWork<T>
    {
        IBaseRepository<T> baseRepository { get; }
    }
}
