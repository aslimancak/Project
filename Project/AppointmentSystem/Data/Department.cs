using System;
using System.Collections.Generic;
using System.Text;

namespace AppointmentSystem.Data
{
    public class Department
    {
        public string DepartmentName { get; set; }

        public List<Doctor> Doctors { get; set; }
    }
}
