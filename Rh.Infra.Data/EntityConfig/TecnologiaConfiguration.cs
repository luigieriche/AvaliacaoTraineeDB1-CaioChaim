using Rh.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rh.Infra.Data.EntityConfig
{
    public class TecnologiaConfiguration : EntityTypeConfiguration<Tecnologia>
    {
        /// <summary>
        ///     Configurando os campos para a base de dados (Tamanhos e chaves)
        /// </summary>
        public TecnologiaConfiguration()
        {
            HasKey(t => t.TecnologiaId);

            Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(t => t.Categoria)
                .IsRequired()
                .HasMaxLength(100);

            HasRequired(t => t.Candidato)
                .WithMany()
                .HasForeignKey(t => t.CandidatoId);
        }
    }
}
