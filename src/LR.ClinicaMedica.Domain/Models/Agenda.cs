using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR.ClinicaMedica.Domain.Models
{
    public class Agenda : Entity
    {
        public Guid PacienteID { get; set; }
        public DateTime Data { get; set; }
        public string Horario { get; set; }
        public string Medico { get; set; }
        public string Tipo { get; set; }
        public string Detalhes { get; set; }
        public bool Confirmada { get; set; }

        public virtual Paciente Paciente { get; set; }
    }
}
