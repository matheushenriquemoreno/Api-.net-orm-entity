using Microsoft.EntityFrameworkCore;
using sistemaGerenciamentoAssistenciaTecnica.InfraEntity;
using sistemaGerenciamentoAssistenciaTecnica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace sistemaGerenciamentoAssistenciaTecnica.Repository.Base
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class, EntidadeBase
    {

        private readonly DbContext _context;

        public RepositoryBase(AppDBContext context)
        {
            _context = context;
        }

        public void Adicionar(T objeto)
        {
            _context.Set<T>().Add(objeto);
            Salvar();
        }

        public void Atualizar(T objeto)
        {
            _context.Set<T>().Update(objeto);
            Salvar();
        }

        public T BuscaPeloId(int id)
        {
            return _context.Set<T>().ToList().Where(x => x.Id == id).FirstOrDefault();
        }

        public T BuscaPorOnde(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression).FirstOrDefault();
        }

        public IEnumerable<T> BuscaTodos()
        {
            return _context.Set<T>().ToList();
        }

        public void Remover(T objeto)
        {
            _context.Set<T>().Remove(objeto);
            Salvar();
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
