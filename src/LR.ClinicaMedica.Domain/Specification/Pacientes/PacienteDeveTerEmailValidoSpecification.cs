using DomainValidation.Interfaces.Specification;
using LR.ClinicaMedica.Domain.Models;
using LR.ClinicaMedica.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR.ClinicaMedica.Domain.Specification.Pacientes
{
    public class PacienteDeveTerEmailValidoSpecification : ISpecification<Paciente>
    {
        public bool IsSatisfiedBy(Paciente paciente)
        {
            return EmailValidation.ValidarEmail(paciente.Email); 
        }
    }
}
