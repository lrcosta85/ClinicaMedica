using LR.ClinicaMedica.Domain.Interfaces.Repository;
using LR.ClinicaMedica.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Dapper;
using LR.ClinicaMedica.Infra.Data.Context;

namespace LR.ClinicaMedica.Infra.Data.Repository
{
    public class PacienteRepository : Repository<Paciente>, IPacienteRepository
    {
        public PacienteRepository(ClinicaMedicaContext context) : base(context)
        {

        }
        public Paciente ObterPorCPF(string CPF)
        {


            //utilizando Dapper
            var sql = string.Format("SELECT * FROM Pacientes where cpf = '{0}'", CPF);

            return Db.Database.Connection.Query<Paciente>(sql).FirstOrDefault();
            //return Buscar(p => p.CPF == CPF).FirstOrDefault();
        }
    }
}
