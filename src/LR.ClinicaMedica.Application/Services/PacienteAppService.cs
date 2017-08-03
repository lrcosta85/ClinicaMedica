using LR.ClinicaMedica.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LR.ClinicaMedica.Application.ViewModels;
using LR.ClinicaMedica.Domain.Interfaces.Repository;
using LR.ClinicaMedica.Infra.Data.Repository;

namespace LR.ClinicaMedica.Application.Services
{
    public class PacienteAppService : IPacienteAppService
    {
        private readonly IPacienteRepository _pacienteRepository;

        public PacienteAppService()
        {
            _pacienteRepository = new PacienteRepository();
        }

        public PacienteAgendaViewModel Adicionar(PacienteAgendaViewModel pacienteAgendaViewModel)
        {
            //pacienteAgendaViewModel >> paciente

            //return _pacienteRepository.Adicionar
        }

        public PacienteViewModel Atualizar(PacienteViewModel pacienteViewModel)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public PacienteViewModel ObterPorCPF(string cpf)
        {
            throw new NotImplementedException();
        }

        public PacienteViewModel ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PacienteViewModel> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
