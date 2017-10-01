using LR.ClinicaMedica.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using LR.ClinicaMedica.Infra.Data.Context;
using System.Data.Entity;
using LR.ClinicaMedica.Domain.Models;

namespace LR.ClinicaMedica.Infra.Data.Repository
{
    public abstract class Repository<tEntity> : IRepository<tEntity> where tEntity : Entity , new()
    {
        protected ClinicaMedicaContext Db;
        protected DbSet<tEntity> DbSet;

        protected Repository(ClinicaMedicaContext context)
        {
            Db = context;
            DbSet = Db.Set<tEntity>();
        }

        public virtual tEntity Adicionar(tEntity obj)
        {
            var objAdd = DbSet.Add(obj);
            SaveChanges();
            return objAdd;
        }

        public virtual tEntity Atualizar(tEntity obj)
        {
            var entry = Db.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;

            //SaveChanges();

            return obj;
        }

        public virtual IEnumerable<tEntity> Buscar(Expression<Func<tEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }

        public virtual tEntity ObterPorID(Guid id)
        {
            return DbSet.Find(id);
        }

        public virtual IEnumerable<tEntity> ObterTodos()
        {
            return DbSet.ToList();
        }

        public virtual void Remover(Guid id)
        {
            var obj = new tEntity() { ID = id };


            DbSet.Remove(obj);
            //SaveChanges();
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }
    }
}
