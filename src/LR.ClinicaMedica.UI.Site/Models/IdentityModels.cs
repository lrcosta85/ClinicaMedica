﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace LR.ClinicaMedica.UI.Site.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class IPacienteClientService : IdentityDbContext<ApplicationUser>
    {
        public IPacienteClientService()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static IPacienteClientService Create()
        {
            return new IPacienteClientService();
        }

        
    }

    public class IAgendaClientService : IdentityDbContext<ApplicationUser>
    {
        public IAgendaClientService()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static IAgendaClientService Create()
        {
            return new IAgendaClientService();
        }


    }
}