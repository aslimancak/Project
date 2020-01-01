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
    /// DoctorPage.xaml etkileşim mantığı
    /// </summary>
    public partial class DoctorPage : Window
    {
        AppointmentSystemDB db = new AppointmentSystemDB();
        public DoctorPage()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, RoutedEventArgs e)
        {
            LoadAppointments();
        }

        private void LoadAppointments()
        {
            var doctor = db.Doctors.Where(x => (x.Name + x.Surname) == (txtDoctorName.Text + txtDoctorSurname.Text)).FirstOrDefault();

            List<Appointment> appointments = db.Appointments.Where(x => x.DoctorID == doctor.ID).ToList();


            dgAppointmentsList.ItemsSource = appointments;

        }

        private void dgAppointmentList_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            Appointment appointment = dgAppointmentsList.SelectedItem as Appointment;
            if (appointment != null)
            {

            }
        }


        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Appointment appointment = dgAppointmentsList.SelectedItem as Appointment;
            if (appointment != null)
            {
                AppointmentSystemDB db = new AppointmentSystemDB();
                db.Appointments.Remove(appointment);
                db.SaveChanges();
                MessageBox.Show("Randevu başarıyla silindi!");
                LoadAppointments();

            }
            else
            {
                MessageBox.Show("Silmek için randevu seçmelisin!");
            }
        }
    }
}
