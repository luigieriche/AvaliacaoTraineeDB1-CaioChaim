using Rh.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rh.Infra.Data.EntityConfig
{
    public class CandidatoConfiguration : EntityTypeConfiguration<Candidato>
    {
        /// <summary>
        ///     Configurando os campos para a base de dados (Tamanhos e chaves)
        /// </summary>
        public CandidatoConfiguration()
        {
            HasKey(c => c.CandidatoId);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Idade)
                .IsRequired();

            Property(c => c.Estado)
                .IsRequired()
                .HasMaxLength(50);

            Property(c => c.Cidade)
                .IsRequired()
                .HasMaxLength(50);

            Property(c => c.Email)
                .IsRequired();

            Property(c => c.Rg)
                .IsRequired()
                .HasMaxLength(9);

            Property(c => c.Cpf)
                .IsRequired()
                .HasMaxLength(11);

            Property(c => c.Vaga)
                .IsRequired();
        }
    }
}
