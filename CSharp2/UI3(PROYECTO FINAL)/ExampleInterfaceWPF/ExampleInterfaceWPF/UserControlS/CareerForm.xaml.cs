using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace ExampleInterfaceWPF.UserControlS
{
    /// <summary>
    /// Lógica de interacción para CareerForm.xaml
    /// </summary>
    public partial class CareerForm : UserControl
    {
        public CareerForm()
        {
            InitializeComponent();
        }

        // Recibe un textobox del cual verifyca si que solo pueda ingresar numeros
        private void VerifyIntValue(TextBox textBox)
        {
            Regex rgx = new Regex("^[0-9]+([.|,][0-9]+)?$");
            if (rgx.IsMatch(textBox.Text)) { }
            else
            {
                MessageBox.Show("Error de texto");
            }
        }

        // Envia un evento para verificar que ingrese numeros en el TextBox
        private void TbId_TextChanged(object sender, TextChangedEventArgs e)
        {
            VerifyIntValue(TbId);
        }
        // Realiza un Add a la lista de Carreras
        public void AddCareer(MainWindow mainWindow)
        {
            Career career = new Career
            {
                Id = 3,
                Name = "Medicina",
                Code = "MD"
            };
            mainWindow.ManageCareer(career, true);
        }
    }
}
