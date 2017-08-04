using LR.ClinicaMedica.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LR.ClinicaMedica.Application.ViewModels;
using LR.ClinicaMedica.Domain.Interfaces.Repository;
using LR.ClinicaMedica.Infra.Data.Repository;
using AutoMapper;
using LR.ClinicaMedica.Domain.Models;

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
            var paciente = Mapper.Map<Paciente>(pacienteAgendaViewModel.PacienteViewModel);
            var agenda = Mapper.Map<Agenda>(pacienteAgendaViewModel.AgendaViewModel);

            paciente.Agendas.Add(agenda);
            paciente.DataCadastro = DateTime.Now;

            _pacienteRepository.Adicionar(paciente);

            return pacienteAgendaViewModel;
        }

        public PacienteViewModel Atualizar(PacienteViewModel pacienteViewModel)
        {
            var paciente = Mapper.Map<Paciente>(pacienteViewModel);

            _pacienteRepository.Atualizar(paciente);

            return pacienteViewModel;
        }

        public void Dispose()
        {
            _pacienteRepository.Dispose();
        }

        public PacienteViewModel ObterPorCPF(string cpf)
        {
            return Mapper.Map<PacienteViewModel>(_pacienteRepository.ObterPorCPF(cpf));
        }

        public PacienteViewModel ObterPorId(Guid id)
        {
            return Mapper.Map<PacienteViewModel>(_pacienteRepository.ObterPorID(id));
        }

        public IEnumerable<PacienteViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<PacienteViewModel>>(_pacienteRepository.ObterTodos());
        }

        public void Remover(Guid id)
        {
            _pacienteRepository.Remover(id);
        }
    }
}
