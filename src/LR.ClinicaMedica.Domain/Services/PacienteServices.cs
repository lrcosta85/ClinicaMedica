﻿using LR.ClinicaMedica.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LR.ClinicaMedica.Domain.Models;
using LR.ClinicaMedica.Domain.Interfaces.Repository;
using LR.ClinicaMedica.Domain.Validation.Pacientes;

namespace LR.ClinicaMedica.Domain.Services
{
    public class PacienteServices : IPacienteService
    {
        private readonly IPacienteRepository _pacienteRepository;

        public PacienteServices(IPacienteRepository pacienteRepository)
        {
            _pacienteRepository = pacienteRepository;
        }
        public Paciente Adicionar(Paciente paciente)
        {
            if (!paciente.EhValido())
            {
                return paciente;
            }

            paciente.ValidationResult = new PacienteAptoParaCadastroValidation(_pacienteRepository).Validate(paciente);


            return !paciente.ValidationResult.IsValid ? paciente : _pacienteRepository.Adicionar(paciente);
        }

        public Paciente Atualizar(Paciente paciente)
        {
            return _pacienteRepository.Atualizar(paciente);
        }

        public void Dispose()
        {
            _pacienteRepository.Dispose();
        }

        public Paciente ObterPorCPF(string cpf)
        {
            return _pacienteRepository.ObterPorCPF(cpf);
        }

        public Paciente ObterPorID(Guid id)
        {
            return _pacienteRepository.ObterPorID(id);
        }

        public IEnumerable<Paciente> ObterTodos()
        {
            return _pacienteRepository.ObterTodos();
        }

        public void Remover(Guid id)
        {
            _pacienteRepository.Remover(id);
        }
    }
}
