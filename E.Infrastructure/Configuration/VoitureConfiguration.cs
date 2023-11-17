using E.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.Infrastructure.Configuration
{
    internal class VoitureConfiguration : IEntityTypeConfiguration<Voiture>
    {
        public void Configure(EntityTypeBuilder<Voiture> builder)

        {

            builder.HasMany(f => f.chauffeurs) 
                .WithOne(p => p.voiture) //<=> [FForeignKey()]
                .HasForeignKey(f => f.voitureFK)
                .OnDelete(DeleteBehavior.Cascade);

            throw new NotImplementedException();
        }
    }
}
