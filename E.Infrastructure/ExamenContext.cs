using E.ApplicationCore.Domain;
using E.Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.Infrastructure
{
    public class ExamenContext:DbContext
    {
        public DbSet<Abrar> abrar { get; set; }
        public DbSet<Chauffeur> chuaffeur { get; set; }
        public DbSet<Client> clien { get; set; }
        public DbSet<Voiture> voiture { get; set; }
        public DbSet<Course> course { get; set; }
        public DbSet<MarqColeur> marqColeurs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
                       Initial Catalog=EXmnBD;
                       Integrated Security=true;MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new VoitureConfiguration());
            modelBuilder.Entity<Voiture>().OwnsOne(p => p.MarqColeur, full =>
            {
                full.Property(p => p.Couleur).IsRequired();
                full.Property(p => p.Marque);

            });

            modelBuilder.Entity<Course>().HasKey(c => new
            {
                c.voitureFk,
                c.clientFk,
                c.Numcourse
            });
            //modelBuilder.Entity<Voiture>().HasMany(p => p.chauffeurs)
            //    .WithOne(r => r.voiture).HasForeignKey(p => p.VoitureFK);

            base.OnModelCreating(modelBuilder);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {


           //qst3Partie2
               
            configurationBuilder.Properties<string>().HaveMaxLength(150);
            
            base.ConfigureConventions(configurationBuilder);
        }
    }
}
