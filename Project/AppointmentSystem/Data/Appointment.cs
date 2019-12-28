using System;
using System.Collections.Generic;
using System.Text;

namespace AppointmentSystem.Data
{
    public class Appointment
    {
        public int ID { get; set; }
        public int PatientID { get; set; }
        public int DepartmentID { get; set; }
        public int DoctorID { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
