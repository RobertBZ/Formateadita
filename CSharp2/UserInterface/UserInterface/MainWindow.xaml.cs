using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace UserInterface
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class DataObject
        {
            public int N { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Zone { get; set; }
            public string Carrera { get; set; }
            public string University { get; set; }
        }
        public MainWindow()
        {
            InitializeComponent();
            var list = new ObservableCollection<DataObject>();
            list.Add(new DataObject()
            {
                N = 1,
                LastName = "Pablo Perez",
                Email = "Pp@gmail.com",
                Zone = "Muyurina",
                Carrera = "Ing. Sistemas",
                University = "USIP"
            });
            list.Add(new DataObject()
            {
                N = 2,
                LastName = "Juan Mendoza",
                Email = "Jm@gmail.com",
                Zone = "Quillacollo",
                Carrera = "Derecho",
                University = "Catolica"
            });
            list.Add(new DataObject()
            {
                N = 3,
                LastName = "Maria Gonzales",
                Email = "Mg@gmail.com",
                Zone = "Sacaba",
                Carrera = "Ing. Comercial",
                University = "San Simon"
            });
            list.Add(new DataObject()
            {
                N = 4,
                LastName = "Alejandra Coria",
                Email = "Ac@gmail.com",
                Zone = "Tiquipalla",
                Carrera = "Medicina",
                University = "San Simon"
            });
            this.dataGrid1.ItemsSource = list;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 registry = new Window1();
            registry.Show();
            this.Close();
        }
    }
}
