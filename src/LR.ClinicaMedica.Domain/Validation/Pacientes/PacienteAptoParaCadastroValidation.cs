using DomainValidation.Validation;
using LR.ClinicaMedica.Domain.Interfaces.Repository;
using LR.ClinicaMedica.Domain.Models;
using LR.ClinicaMedica.Domain.Specification.Pacientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR.ClinicaMedica.Domain.Validation.Pacientes
{
    public class PacienteAptoParaCadastroValidation : Validator<Paciente>
    {
        public PacienteAptoParaCadastroValidation(IPacienteRepository pacienteRepository)
        {
            var cpfDuplicado = new PacienteDeveTerCpfUnicoSpecification(pacienteRepository);

            base.Add("cpfDuplicado", new Rule<Paciente>(cpfDuplicado, "CPF já cadastrado"));
        }
    }
}
