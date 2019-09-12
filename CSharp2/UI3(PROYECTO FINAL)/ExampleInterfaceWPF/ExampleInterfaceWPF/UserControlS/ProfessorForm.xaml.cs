using Core;
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
    /// Lógica de interacción para ProfessorForm.xaml
    /// </summary>
    public partial class ProfessorForm : UserControl
    {
        public ProfessorForm()
        {
            InitializeComponent();
            GetCarrers();
        }

        // Reiliza un get para cargar las carreras en el ComboBox
        private void GetCarrers()
        {
            var registry = new Factory<ConcreteTXT>().Get().GetCareers();
            foreach (var item in registry)
            {
                ListCareers.Items.Add(item.Name);
            }
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

        // Realiza un Add a la lista de Profesores
        public void AddProfessor(MainWindow mainWindow)
        {
            Professor instance = new Professor
            {
                Id = 4,
                Name = "Rodrigo",
                Lastname = "Vargas",
                Code = "IS"
            };
            mainWindow.ManageProfessor(instance, true);
        }
    }
}
