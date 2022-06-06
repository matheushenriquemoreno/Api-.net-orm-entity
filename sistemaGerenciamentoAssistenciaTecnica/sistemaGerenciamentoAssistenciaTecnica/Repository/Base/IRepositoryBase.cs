using sistemaGerenciamentoAssistenciaTecnica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace sistemaGerenciamentoAssistenciaTecnica.Repository.Base
{
    public interface IRepositoryBase<T> where T : EntidadeBase
    {

        IEnumerable<T> BuscaTodos();

        T BuscaPorOnde(Expression<Func<T, bool>> expression);

        T BuscaPeloId(int id);

        void Adicionar(T objeto);

        void Atualizar(T objeto);

        void Remover(T objeto);
    }
}

