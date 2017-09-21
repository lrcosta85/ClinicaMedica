﻿using DomainValidation.Validation;
using LR.ClinicaMedica.Domain.Models;
using LR.ClinicaMedica.Domain.Specification.Pacientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR.ClinicaMedica.Domain.Validation.Pacientes
{
    public class PacienteEstaConsistenyteValidation : Validator<Paciente>
    {
        public PacienteEstaConsistenyteValidation()
        {
            var cpfPaciente = new PacienteDeveTerCPFValidoSpecification();

            Add("cpfPaciente", new Rule<Paciente>(cpfPaciente, "CPF inválido"));
        }
    }
}
