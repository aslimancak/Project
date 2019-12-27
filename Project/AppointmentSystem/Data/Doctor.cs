using System;
using System.Collections.Generic;
using System.Text;

namespace AppointmentSystem.Data
{
    public class Doctor
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Department Department { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}
