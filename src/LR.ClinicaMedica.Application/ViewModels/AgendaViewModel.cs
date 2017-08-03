using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR.ClinicaMedica.Application.ViewModels
{
    public class AgendaViewModel
    {
        public AgendaViewModel()
        {
            ID = Guid.NewGuid();
        }

        public Guid ID { get; set; }
        public Guid PacienteID { get; set; }
        public DateTime Data { get; set; }
        public string Horario { get; set; }
        public string Medico { get; set; }
        public string Tipo { get; set; }
        public string Detalhes { get; set; }
        public bool Confirmada { get; set; }
    }
}
