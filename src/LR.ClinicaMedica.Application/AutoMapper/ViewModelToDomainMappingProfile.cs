using AutoMapper;
using LR.ClinicaMedica.Application.ViewModels;
using LR.ClinicaMedica.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR.ClinicaMedica.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<PacienteViewModel, Paciente>();
            CreateMap<PacienteAgendaViewModel, Paciente>();

            CreateMap<AgendaViewModel, Agenda>();
            CreateMap<PacienteAgendaViewModel, Agenda>();
        }
    }
}
