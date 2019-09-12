using Core;
using Entity;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Lógica de interacción para StudentForm.xaml
    /// </summary>
    public partial class StudentForm : UserControl
    {
        public StudentForm()
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
                CbCareers.Items.Add(item.Name);
            }
        }
        // Recibe un textobox del cual verifyca si que solo pueda ingresar numeros
        public void VerifyIntValue(TextBox textBox)
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
            VerifyIntValue(tbId);
        }

        // Envia un evento para verificar que ingrese numeros en el TextBox
        private void TbAge_TextChanged(object sender, TextChangedEventArgs e)
        {
            VerifyIntValue(tbAge);
        }

        // Realiza un Add a la lista de Studiantes
        public void AddStudent(MainWindow mainWindow)
        {
            Student instance = new Student
            {
                Id = 7,
                Name = "Juan",
                Lastname = "Perez",
                CareerCode = "IC",
                Age = 24
            };
            mainWindow.ManageStudent(instance, false);
        }
    }
}