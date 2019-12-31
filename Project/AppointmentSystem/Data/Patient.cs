using System;
using System.Collections.Generic;
using System.Text;

namespace AppointmentSystem.Data
{
    public class Patient
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
