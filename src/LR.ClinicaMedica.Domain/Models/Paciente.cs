using DomainValidation.Validation;
using LR.ClinicaMedica.Domain.Validation.Pacientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR.ClinicaMedica.Domain.Models
{
    public class Paciente : Entity
    {
        public Paciente()
        {
            Agendas = new List<Agenda>();
        }

        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string EnderecoNumero { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string EnderecoComplemento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string TelefoneDDD { get; set; }
        public string Telefone { get; set; }
        public string CelularDDD { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Convenio { get; set; }
        public DateTime DataCadastro { get; set; }
        public ValidationResult ValidationResult { get; set; }

        public bool EhValido()
        {
            ValidationResult = new PacienteEstaConsistenyteValidation().Validate(this);
            return ValidationResult.IsValid;
        }

        public virtual ICollection<Agenda> Agendas { get; set; }

    }
}
