using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace AppointmentSystem.Data
{
    public class AppointmentSystemDB : DbContext
    {
        string connectionString = @"Server=MAN-BILGISAYAR\SQLEXPRESS;Database=AppointmentSystemDB;Trusted_Connection=True;";
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Department> Courses { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }

        // kalan kısım HW4 ile aynıdır
        public AppointmentSystemDB() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}
