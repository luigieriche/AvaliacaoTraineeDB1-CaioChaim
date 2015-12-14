using Rh.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rh.Infra.Data.EntityConfig
{
    public class VagaConfiguration : EntityTypeConfiguration<Vaga>
    {
        /// <summary>
        ///     Configurando os campos para a base de dados (Tamanhos e chaves)
        /// </summary>
        public VagaConfiguration()
        {
            HasKey(v => v.VagaId);

            Property(v => v.Nome)
                .IsRequired()
                .HasMaxLength(150);

            HasRequired(v => v.Candidato)
                .WithMany()
                .HasForeignKey(v => v.CandidatoId);
        }
    }
}
