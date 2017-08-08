using LR.ClinicaMedica.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR.ClinicaMedica.Application.Interfaces
{
    public interface IAgendaAppService : IDisposable
    {
        AgendaViewModel Adicionar(AgendaViewModel agendaViewModel);
        IEnumerable<AgendaViewModel> ObterPorPaciente(Guid id);
        IEnumerable<AgendaViewModel> ObterPorData(DateTime data);
        AgendaViewModel Atualizar(AgendaViewModel agendaViewModel);
        void Remover(Guid id);
    }
}
