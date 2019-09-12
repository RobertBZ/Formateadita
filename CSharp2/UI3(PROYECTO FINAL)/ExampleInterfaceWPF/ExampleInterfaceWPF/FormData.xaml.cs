using Entity;
using ExampleInterfaceWPF.UserControlS;
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

namespace ExampleInterfaceWPF
{
    /// <summary>
    /// Lógica de interacción para RegistryStudent.xaml
    /// </summary>
    public partial class FormData : Window
    {
        /*  Variables de uso interno  */
        private MainWindow MainWindow;
        private string TypeForm { get; set; }
        /*  ********************  */
        public FormData()
        {
            InitializeComponent();
        }

        // Inicializa el tipo de formulario que tendra y el UserControl que se cargara
        public void InicializerContent(UserControl userControl, string type, MainWindow mainWindow)
        {
            MainWindow = mainWindow;
            TypeForm = type;
            GridContent.Children.Add(userControl);
        }

        // El boton realiza un Add Dependiendo el tipo de Modelo que sesivira
        private void BtnAddData_Click(object sender, RoutedEventArgs e)
        {
            switch (TypeForm)
            {
                case "Student":
                    StudentForm studentForm = new StudentForm();
                    studentForm.AddStudent(MainWindow);
                    break;
                case "Career":
                    CareerForm careerForm = new CareerForm();
                    careerForm.AddCareer(MainWindow);
                    break;
                case "Professor":
                    ProfessorForm professorForm = new ProfessorForm();
                    professorForm.AddProfessor(MainWindow);
                    break;
            }
            Close();
        }
    }
}
