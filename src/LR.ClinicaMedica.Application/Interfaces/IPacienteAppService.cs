using LR.ClinicaMedica.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR.ClinicaMedica.Application.Interfaces
{
    public interface IPacienteAppService : IDisposable
    {
        PacienteAgendaViewModel Adicionar(PacienteAgendaViewModel pacienteAgendaViewModel);
        PacienteViewModel ObterPorId(Guid id);
        IEnumerable<PacienteViewModel> ObterTodos();
        PacienteViewModel ObterPorCPF(string cpf);
        PacienteViewModel Atualizar(PacienteViewModel pacienteViewModel);
        void Remover(Guid id);
    }
}
