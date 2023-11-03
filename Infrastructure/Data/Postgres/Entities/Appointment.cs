using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Appointment : Entity<int>
    {
        public DateTime AppointmentDate { get; set; }
        public string AppointmentDescription { get; set; }

        // Referans
        public virtual Polyclinic Polyclinic { get; set; }
        public int PolyclinicId { get; set; }
        public virtual User Doctor { get; set; }
        public int DoctorId { get; set; }
        public virtual User Patient { get; set; }
        public int PatientId { get; set; }
    }
    public enum AppointmentStatus
    {
        NotStarted,
        InProgress,
        Completed
    }
}