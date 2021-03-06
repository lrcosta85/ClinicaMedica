﻿using LR.ClinicaMedica.Application.Interfaces;
using System;
using System.Collections.Generic;
using LR.ClinicaMedica.Application.ViewModels;
using LR.ClinicaMedica.Domain.Interfaces.Repository;
using LR.ClinicaMedica.Infra.Data.Repository;
using AutoMapper;
using LR.ClinicaMedica.Domain.Models;
using LR.ClinicaMedica.Domain.Interfaces.Services;
using LR.ClinicaMedica.Infra.Data.Interfaces;

namespace LR.ClinicaMedica.Application.Services
{
    public class PacienteAppService : IPacienteAppService
    {
        private readonly IPacienteService _pacienteService;

        private readonly IUnitOfWork _uow;

        public PacienteAppService(IPacienteService pacienteService, IUnitOfWork uow)
        {
            _pacienteService = pacienteService;
            _uow = uow;
        }

        public PacienteViewModel Adicionar(PacienteViewModel pacienteViewModel)
        {
            var paciente = Mapper.Map<Paciente>(pacienteViewModel);
            //var agenda = Mapper.Map<Agenda>(pacienteAgendaViewModel.AgendaViewModel);

            //paciente.Agendas.Add(agenda);
            paciente.DataCadastro = DateTime.Now;

            var pacienteReturn =  _pacienteService.Adicionar(paciente);

            if (pacienteReturn.ValidationResult.IsValid)
            {
                _uow.Commit();
            }

            pacienteViewModel = Mapper.Map<PacienteViewModel>(pacienteReturn);

            return pacienteViewModel;
        }

        public PacienteViewModel Atualizar(PacienteViewModel pacienteViewModel)
        {
            var paciente = Mapper.Map<Paciente>(pacienteViewModel);

            _pacienteService.Atualizar(paciente);

            return pacienteViewModel;
        }

        public void Dispose()
        {
            _pacienteService.Dispose();
        }

        public PacienteViewModel ObterPorCPF(string cpf)
        {
            return Mapper.Map<PacienteViewModel>(_pacienteService.ObterPorCPF(cpf));
        }

        public PacienteViewModel ObterPorId(Guid id)
        {
            return Mapper.Map<PacienteViewModel>(_pacienteService.ObterPorID(id));
        }

        public IEnumerable<PacienteViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<PacienteViewModel>>(_pacienteService.ObterTodos());
        }

        public void Remover(Guid id)
        {
            _pacienteService.Remover(id);
        }
    }
}
