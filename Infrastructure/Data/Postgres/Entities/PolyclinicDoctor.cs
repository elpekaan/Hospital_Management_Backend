using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class PolyclinicDoctor : Entity<int>
    {
        // Referans
        public virtual User Doctor { get; set; }
        public int DoctorId { get; set; }
        public virtual Polyclinic Polyclinic { get; set; }
        public int PolyclinicId { get; set; }
    }
}
