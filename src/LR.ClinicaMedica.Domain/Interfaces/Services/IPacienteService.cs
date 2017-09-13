using LR.ClinicaMedica.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR.ClinicaMedica.Domain.Interfaces.Services
{
    public interface IPacienteService : IDisposable
    {
        Paciente Adicionar(Paciente paciente);
        Paciente ObterPorID(Guid id);
        IEnumerable<Paciente> ObterTodos();
        Paciente ObterPorCPF(string cpf);
        Paciente Atualizar(Paciente paciente);
        void Remover(Guid id);
    }
}
