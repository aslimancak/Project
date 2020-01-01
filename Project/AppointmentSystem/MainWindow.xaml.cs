using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AppointmentSystem
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NewAppointmentButton_Click(object sender, RoutedEventArgs e)
        {
            AppointmentWindow appointment = new AppointmentWindow();
            appointment.Show();
        }

        private void ApoointmentbtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            DoctorPage doctorPage = new DoctorPage();
            doctorPage.Show();
        }
    }
}
