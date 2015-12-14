using Rh.Domain.Entities;
using Rh.Infra.Data.EntityConfig;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rh.Infra.Data.Context
{
    public class ProjectContext : DbContext 
    {
        public ProjectContext()
            : base("AvaliacaoTecnicaDB1")
        { }

        public DbSet<Candidato> Candidatos { get; set; }
        public DbSet<Tecnologia> Tecnologias { get; set; }
        public DbSet<Vaga> Vagas { get; set; }

        /// <summary>
        ///     Método para desabilitar algumas convenções.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Desabilitando a pluralidade no nome da tabela do banco de dados.
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // Desabilitando a remoção em cascata.
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            // Definindo uma certa propriedade que termine com "Id", para PrimaryKey.
            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            // Tudo que for String o MVC vai entender que é um varchar.
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            // Caso não for informado um tamanho, ele deixa o Length de 100, por padrão.
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            // Adicionando a configuração para as classes.
            modelBuilder.Configurations.Add(new CandidatoConfiguration());
            modelBuilder.Configurations.Add(new TecnologiaConfiguration());
            modelBuilder.Configurations.Add(new VagaConfiguration());
        }

        /// <summary>
        ///     Método para identificar a data em adição ou alteração, mantendo sempre o
        ///     valor do cadastro se tiver alterando.
        /// </summary>
        /// <returns> Inserção no banco de dados </returns>
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                // Condição pra saber se está adicionando, capturando a data atual.
                if (entry.State == EntityState.Added)
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;

                // Condição pra saber se está alterando, mantendo a data de cadastro.
                if (entry.State == EntityState.Modified)
                    entry.Property("DataCadastro").IsModified = false;
            }

            return base.SaveChanges();
        }
    }
}
