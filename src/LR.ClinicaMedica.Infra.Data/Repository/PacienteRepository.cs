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
    public class PacienteRepository : Repository<Paciente>, IPacienteRepository
    {
        public Paciente ObterPorCPF(string CPF)
        {
            return Buscar(p => p.CPF == CPF).FirstOrDefault();
        }
    }
}
