using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class PolyclinicConfiguration : IEntityTypeConfiguration<Polyclinic>
    {
        public void Configure(EntityTypeBuilder<Polyclinic> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.PolyclinicName).IsRequired();
        }
    }
}
