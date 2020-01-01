using AppointmentSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppointmentSystem
{
    /// <summary>
    /// AppointmentWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class AppointmentWindow : Window
    {
        AppointmentSystemDB db = new AppointmentSystemDB();
        public AppointmentWindow()
        {
            InitializeComponent();

            foreach (Department department in db.Courses)
            {
                departmantComboBox.Items.Add(department.DepartmentName);
            }

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            titleComboBox.Items.Clear();
            if (departmantComboBox.SelectedIndex != -1)
            {

                if (departmantComboBox.Text == "Pediatrics")
                {

                    IQueryable<Doctor> doctors = db.Doctors.Where(x => x.DepartmentID == 1).Select(x => x);

                    foreach (var x in doctors)
                    {
                        titleComboBox.Items.Add("Dr." + x.Name + " " + x.Surname);

                    }
                }

                if (departmantComboBox.Text == "Gynaecology ")
                {
                    IQueryable<Doctor> doctors = db.Doctors.Where(x => x.DepartmentID == 2).Select(x => x);

                    foreach (var x in doctors)
                    {
                        titleComboBox.Items.Add("Dr." + x.Name + " " + x.Surname);

                    }

                }
                titleComboBox.Items.Refresh();
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var department = db.Courses.Where(x => x.DepartmentName == departmantComboBox.Text).FirstOrDefault();
            var doctor = db.Doctors.Where(x => ("Dr." + x.Name + " " + x.Surname) == titleComboBox.Text).FirstOrDefault();



            Appointment appointment = new Appointment();
            appointment.DepartmentID = department.ID;
            appointment.DoctorID = doctor.ID;
            appointment.Timestamp = dtpAppointmentDate.SelectedDate.Value;
            

            db.Appointments.Add(appointment);

            db.SaveChanges();
            MessageBox.Show("Randevunuz başarıyla kaydedildi.");

        }



    }
}
