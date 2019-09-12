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
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            ListUniversity.Items.Add("USIP");
            ListUniversity.Items.Add("UMSS");
            ListUniversity.Items.Add("Catolica");
            ListUniversity.Items.Add("Univalle");

            ListCareers.Items.Add("Ing. Sistemas");
            ListCareers.Items.Add("Ing. Cormecial");
            ListCareers.Items.Add("Ing. Civil");
            ListCareers.Items.Add("Ing. Petrolera");
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow ListPanel = new MainWindow();
            ListPanel.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RegistryUniversity registryUniversity = new RegistryUniversity();
            registryUniversity.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            RegistryCareer registryCareer = new RegistryCareer();
            registryCareer.Show();
            this.Close();
        }
    }
}
