using LR.ClinicaMedica.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LR.ClinicaMedica.Domain.Interfaces.Repository
{
    public interface IRepository<tEntity> : IDisposable where tEntity : Entity  
    {
        tEntity Adicionar(tEntity obj);
        tEntity ObterPorID(Guid ID);
        IEnumerable<tEntity> ObterTodos();
        tEntity Atualizar(tEntity obj);
        void Remover(Guid ID);
        IEnumerable<tEntity> Buscar(Expression<Func<tEntity, bool>> predicate);
        int SaveChanges();
    }
}
