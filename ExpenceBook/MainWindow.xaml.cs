using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExpenceBook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

            UserRegistration registration = new UserRegistration();

        Login login = new Login();
        private void buttonRegister_Click(object sender, RoutedEventArgs e)
        {
            registration.Show();

            Close();
        }
        private void login_Click(object sender, RoutedEventArgs e)
        {
            login.Show();

            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
