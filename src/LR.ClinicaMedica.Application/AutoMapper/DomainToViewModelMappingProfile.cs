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
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Paciente, PacienteViewModel>().ReverseMap();
            CreateMap<Paciente, PacienteAgendaViewModel>().ReverseMap();

            CreateMap<Agenda, AgendaViewModel>().ReverseMap();
            CreateMap<Agenda, PacienteAgendaViewModel>().ReverseMap();
        }
    }
}
