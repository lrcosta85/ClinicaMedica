using LR.ClinicaMedica.Domain.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace LR.ClinicaMedica.Infra.Data.EntityConfig
{
    public class AgendaConfig : EntityTypeConfiguration<Agenda>
    {
        public AgendaConfig()
        {
            HasKey(a => a.ID);

            Property(a => a.Data)
                .IsRequired();

            Property(a => a.Detalhes)
                .HasMaxLength(200);

            Property(a => a.Horario)
                .HasMaxLength(6)
                .IsRequired();

            Property(a => a.Medico)
                .IsRequired()
                .HasMaxLength(50);

            Property(a => a.Tipo)
                .IsRequired()
                .HasMaxLength(20);

            HasRequired(a => a.Paciente)
                .WithMany(p => p.Agendas)
                .HasForeignKey(a => a.PacienteID);

            ToTable("Agendas");

        }
    }
}
