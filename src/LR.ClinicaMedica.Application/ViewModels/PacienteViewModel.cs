using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR.ClinicaMedica.Application.ViewModels
{
    public class PacienteViewModel
    {
        public PacienteViewModel()
        {
            ID = Guid.NewGuid();
            Agendas = new List<AgendaViewModel>();
        }

        [Key]
        public Guid ID { get; set; }
        
        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(4, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha a data de nascimento")]
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

        public DomainValidation.Validation.ValidationResult ValidationResult { get; set; }

        public ICollection<AgendaViewModel> Agendas { get; set; }

    }
}
