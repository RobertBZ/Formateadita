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
using System.Windows.Shapes;

namespace UserInterface
{
    /// <summary>
    /// Lógica de interacción para RegistryUniversity.xaml
    /// </summary>
    public partial class RegistryUniversity : Window
    {
        public RegistryUniversity()
        {
            InitializeComponent();
            ListAddress.Items.Add("Muyurina");
            ListAddress.Items.Add("Sacaba");
            ListAddress.Items.Add("Quillacollo");
            ListAddress.Items.Add("Tiquipalla");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Init = new MainWindow();
            Init.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RegistryCareer registryCareer = new RegistryCareer();
            registryCareer.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window1 registryStudent = new Window1();
            registryStudent.Show();
            this.Close();
        }
    }
}
