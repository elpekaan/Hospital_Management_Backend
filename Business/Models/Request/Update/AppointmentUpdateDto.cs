using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class AppointmentUpdateDto
    {
        public DateTime AppointmentDate { get; set; }
        public string AppointmentDescription { get; set; }
        public int PolyclinicId { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
    }
}
