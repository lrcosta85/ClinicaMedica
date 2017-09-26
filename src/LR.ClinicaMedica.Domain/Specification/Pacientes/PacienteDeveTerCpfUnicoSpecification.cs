using DomainValidation.Interfaces.Specification;
using LR.ClinicaMedica.Domain.Interfaces.Repository;
using LR.ClinicaMedica.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR.ClinicaMedica.Domain.Specification.Pacientes
{
    public class PacienteDeveTerCpfUnicoSpecification : ISpecification<Paciente>
    {
        private readonly IPacienteRepository _pacienteRepository;

        public PacienteDeveTerCpfUnicoSpecification(IPacienteRepository pacienteRepository)
        {
            _pacienteRepository = pacienteRepository;
        }

        public bool IsSatisfiedBy(Paciente paciente)
        {
            return _pacienteRepository.ObterPorCPF(paciente.CPF) == null;
        }
    }
}
