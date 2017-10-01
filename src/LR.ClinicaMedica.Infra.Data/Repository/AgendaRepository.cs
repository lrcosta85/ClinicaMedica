using LR.ClinicaMedica.Domain.Interfaces.Repository;
using LR.ClinicaMedica.Domain.Models;
using LR.ClinicaMedica.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR.ClinicaMedica.Infra.Data.Repository
{
    public class AgendaRepository : Repository<Agenda>, IAgendaRepository
    {
        public AgendaRepository(ClinicaMedicaContext context) : base(context)
        {

        }

        public IEnumerable<Agenda> ObterPorData(DateTime data)
        {
            return Buscar(a => a.Data == data).ToList();
        }

        public IEnumerable<Agenda> ObterPorPaciente(Guid id)
        {
            return Buscar(a => a.PacienteID == id).ToList();
        }
    }
}
