using LR.ClinicaMedica.Domain.Interfaces.Repository;
using LR.ClinicaMedica.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace LR.ClinicaMedica.Infra.Data.Repository
{
    public class PacienteRepository : IRepository<Paciente>, IPacienteRepository
    {
        public Paciente Adicionar(Paciente obj)
        {
            throw new NotImplementedException();
        }

        public Paciente Atualizar(Paciente obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Paciente> Buscar(Expression<Func<Paciente, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Paciente ObterPorCPF(string CPF)
        {
            return Buscar(p => p.CPF == CPF).FirstOrDefault();
        }

        public Paciente ObterPorID(Guid ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Paciente> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(Guid ID)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
