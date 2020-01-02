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

            // poliklinikleri databaseden alir ve foreach döngüsüyle comboboxa ekler
            // hepsini almak icin foreach kullandım, foreach databasede bulunan nesne sayısı kadar işlemi tekrar ediyor

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

                if (departmantComboBox.Text == "Pediyatri") // departmanComboBox.Text secilen polikliniğin textini alıyor.
                {
                    // IQuerable bizim ödevlerde kullandığımız list yapısına benziyor. internetten buldum.
                    // Departman id si 1 e eşit olan doktorları tutuyor.
                    // Sonradan bu doktorları 2. comboboxa ekliyorum.

                    IQueryable<Doctor> doctors = db.Doctors.Where(x => x.DepartmentID == 1).Select(x => x);

                    foreach (var x in doctors)
                    {
                        titleComboBox.Items.Add("Dr." + x.Name + " " + x.Surname);

                    }
                }

                if (departmantComboBox.Text == "Jinekoloji")
                {
                    IQueryable<Doctor> doctors = db.Doctors.Where(x => x.DepartmentID == 2).Select(x => x);

                    foreach (var x in doctors)
                    {
                        titleComboBox.Items.Add("Dr." + x.Name + " " + x.Surname);

                    }

                }
                titleComboBox.Items.Refresh(); // kutucuğu yeniliyor.
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e) //randevu almak icin kullandığım fonsiyon
        {
            // kutucuğa yazılan bilgileri alarak databaseden ilgili objeleri buldum ve var türünde oluşturduğum değişkenlere atadım.

            var department = db.Courses.Where(x => x.DepartmentName == departmantComboBox.Text).FirstOrDefault();
            var doctor = db.Doctors.Where(x => ("Dr." + x.Name + " " + x.Surname) == titleComboBox.Text).FirstOrDefault();
            var patient = db.Patients.Where(x => (x.Name + x.Surname) == (txtPatientName.Text + txtPatientSurname.Text)).FirstOrDefault();



            Appointment appointment = new Appointment();
            appointment.DepartmentID = department.ID;
            appointment.DoctorID = doctor.ID;
            appointment.Timestamp = dtpAppointmentDate.SelectedDate.Value;
            appointment.PatientID = patient.ID;
            

            db.Appointments.Add(appointment);

            // random sayı oluşturma kodunu internetten aldım.

            Random rnd = new Random();
            int hour = rnd.Next(9, 18);
            db.SaveChanges();
            MessageBox.Show("Randevunuz başarıyla kaydedildi. Randevu saatiniz: " + hour + ":00 Lütfen randevu saatinizi not edin." );
            LoadAppointments();

        }

       

        private void LoadAppointments()
        {
            AppointmentSystemDB db = new AppointmentSystemDB();
            var patient = db.Patients.Where(x => (x.Name + x.Surname) == (txtPatientName.Text + txtPatientSurname.Text)).FirstOrDefault();
            List<Appointment> appointments = db.Appointments.Where(x => x.PatientID == patient.ID).ToList();
     
            dgAppointments.ItemsSource = appointments;
        }

      
        // asağıdaki fonksiyonu HW4 ü kullanarak oluşturdum. 
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Appointment appointment = dgAppointments.SelectedItem as Appointment;
            if (appointment != null)
            {
                AppointmentSystemDB db = new AppointmentSystemDB();
                db.Appointments.Remove(appointment);
                db.SaveChanges();
                MessageBox.Show("Randevunuz başarıyla silindi!");
                LoadAppointments();

            }
            else
            {
                MessageBox.Show("Silmek için randevu seçmelisin!");
            }
        }


    }
}
