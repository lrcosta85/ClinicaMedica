﻿using LR.ClinicaMedica.Application.Interfaces;
using LR.ClinicaMedica.Application.Services;
using LR.ClinicaMedica.Domain.Interfaces.Repository;
using LR.ClinicaMedica.Domain.Interfaces.Services;
using LR.ClinicaMedica.Domain.Services;
using LR.ClinicaMedica.Infra.Data.Repository;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR.ClinicaMedica.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void Register(Container container)
        {
            //APP
            container.Register<IPacienteAppService, PacienteAppService>();
            //Domain
            container.Register<IPacienteService, PacienteServices>();
            //Dados
            container.Register<IPacienteRepository, PacienteRepository>();
        }
    }
}
