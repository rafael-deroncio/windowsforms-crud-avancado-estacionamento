using System.Collections.Generic;

namespace EstacionamentoForms.Repositories.Interfaces
{
    public interface IBaseRepository<T>
    {
        T Recuperar(int id);
        List<T> Recuperar();
        void Salvar(T obj);
        void Alterar(T obj);
    }
}
