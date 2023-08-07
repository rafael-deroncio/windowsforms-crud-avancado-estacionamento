using EstacionamentoForms.Configurations.Enum;
using EstacionamentoForms.Repositories.Interfaces;
using System;
using System.Collections.Generic;

namespace EstacionamentoForms.Services.Interfaces
{
    public interface IBaseService<T>
    {
        bool Cadastrar(T model);
        bool Atualizar(T model);
        List<T> RecuperarTodos();
    }
}
