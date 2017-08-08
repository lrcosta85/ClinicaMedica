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
    public class AgendaAppService : IAgendaAppService
    {
        private readonly IAgendaRepository _agendaRepository;

        public AgendaAppService()
        {
            _agendaRepository = new AgendaRepository();
        }

        public AgendaViewModel Adicionar(AgendaViewModel agendaViewModel)
        {
            var agenda = Mapper.Map<Agenda>(agendaViewModel);
            //var paciente = Mapper.Map<Paciente>(pacienteViewModel);
            _agendaRepository.Adicionar(agenda);

            return agendaViewModel;
        }

        public AgendaViewModel Atualizar(AgendaViewModel agendaViewModel)
        {
            var agenda = Mapper.Map<Agenda>(agendaViewModel);

            _agendaRepository.Atualizar(agenda);

            return agendaViewModel;
        }

        public void Dispose()
        {
            _agendaRepository.Dispose();
        }

        public IEnumerable<AgendaViewModel> ObterPorData(DateTime data)
        {
            return Mapper.Map<IEnumerable<AgendaViewModel>>(_agendaRepository.ObterPorData(data));
        }

        public IEnumerable<AgendaViewModel> ObterPorPaciente(Guid id)
        {
            return Mapper.Map<IEnumerable<AgendaViewModel>>(_agendaRepository.ObterPorPaciente(id));
        }

        public void Remover(Guid id)
        {
            _agendaRepository.Remover(id);
        }
    }
}
