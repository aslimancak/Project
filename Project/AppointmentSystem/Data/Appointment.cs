using System;
using System.Collections.Generic;
using System.Text;

namespace AppointmentSystem.Data
{
    public class Appointment
    {
        public Patient Patient { get; set; }
        public Department Department { get; set; }
        public Doctor Doctor { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
