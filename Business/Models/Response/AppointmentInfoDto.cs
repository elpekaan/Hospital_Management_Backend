using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class AppointmentInfoDto
    {
        public int Id { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string AppointmentDescription { get; set; }
        public virtual PolyclinicInfoDto Polyclinic { get; set; }
        public int PolyclinicId { get; set; }
        public virtual UserProfileDto Doctor { get; set; }
        public int DoctorId { get; set; }
        public virtual UserProfileDto Patient { get; set; }
        public int PatientId { get; set; }
    }
}
