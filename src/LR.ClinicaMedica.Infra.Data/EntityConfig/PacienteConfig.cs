using LR.ClinicaMedica.Domain.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;


namespace LR.ClinicaMedica.Infra.Data.EntityConfig
{
    public class PacienteConfig : EntityTypeConfiguration<Paciente>
    {
        public PacienteConfig()
        {
            HasKey(p => p.ID);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.Telefone)
                .IsRequired()
                .HasMaxLength(12);

            Property(p => p.TelefoneDDD)
                .IsRequired()
                .HasMaxLength(2);

            Property(p => p.Bairro)
                .IsRequired()
                .HasMaxLength(30);

            Property(p => p.Celular)
                .IsRequired()
                .HasMaxLength(12);

            Property(p => p.CelularDDD)
                .IsRequired()
                .HasMaxLength(2);

            Property(p => p.CEP)
                .IsRequired()
                .HasMaxLength(10);

            Property(p => p.Cidade)
                .IsRequired()
                .HasMaxLength(30);

            Property(p => p.Convenio)
                .HasMaxLength(30);

            Property(p => p.CPF)
                .IsRequired()
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnAnnotation("Index", new IndexAnnotation(
                    new IndexAttribute("IX_CPF") { IsUnique = true}));

            Property(p => p.DataNascimento)
                .IsOptional();

            Property(p => p.Email)
                .HasMaxLength(100);

            Property(p => p.Endereco)
                .HasMaxLength(100);

            Property(p => p.EnderecoComplemento)
                .HasMaxLength(20);

            Property(p => p.EnderecoNumero)
                .HasMaxLength(5);

            Property(p => p.Estado)
                .HasMaxLength(2);

            Ignore(p => p.ValidationResult);

            ToTable("Pacientes");

        }
    }
}
