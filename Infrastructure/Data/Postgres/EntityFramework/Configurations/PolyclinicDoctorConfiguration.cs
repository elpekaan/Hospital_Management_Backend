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
    public class PolyclinicDoctorConfiguration : IEntityTypeConfiguration<PolyclinicDoctor>
    {
        public void Configure(EntityTypeBuilder<PolyclinicDoctor> builder)
        {
            builder.HasKey(x => x.Id);

            // Db İlişkileri

            builder.HasOne(a => a.Polyclinic)
                .WithMany()
                .HasForeignKey(a => a.PolyclinicId);

            builder.HasOne(a => a.Doctor)
                .WithMany()
                .HasForeignKey(a => a.DoctorId);
        }
    }
}
