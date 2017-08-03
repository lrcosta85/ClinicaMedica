using LR.ClinicaMedica.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR.ClinicaMedica.Domain.Interfaces.Repository
{
    public interface IPacienteRepository : IRepository<Paciente>
    {
        Paciente ObterPorCPF(string CPF);
        
    }
}
