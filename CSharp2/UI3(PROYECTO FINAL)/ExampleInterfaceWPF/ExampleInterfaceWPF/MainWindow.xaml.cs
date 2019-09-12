using Core;
using Entity;
using ExampleInterfaceWPF.UserControlS;
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

namespace ExampleInterfaceWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*  Variables de uso interno  */ 
        private List<Student> ListStudents = new List<Student>();
        private List<Professor> ListProfessor = new List<Professor>();
        private List<Career> ListCareer = new List<Career>();
        /* *************************  */
        public MainWindow()
        {
            InitializeComponent();
        }
        /*  Notones de registro  */
        // Boton formulario estudiante
        private void BtnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            UserControlOnly(studentForm, "Student");
        }

        //Boton formulario carrera
        private void BtnCreateCareer_Click(object sender, RoutedEventArgs e)
        {
            CareerForm careerForm = new CareerForm();
            UserControlOnly(careerForm, "Career");
        }

        // Boton formulario Docente
        private void BtnCreateUniversity_Click(object sender, RoutedEventArgs e)
        {
            ProfessorForm professorForm = new ProfessorForm();
            UserControlOnly(professorForm, "Professor");
        }
        /* ----------------------  */

        // Verificador de control de usuario
        private void UserControlOnly(UserControl userControl, string type)
        {
            FormData formData = new FormData();
            formData.InicializerContent(userControl, type, this);
            formData.Show();
        }

        // Boton para iniciar la carga de datos en la tabla
        private void BtnLoad_Click(object sender, RoutedEventArgs e)
        {
            if (CbDataType.SelectedValue != null)
            {
                var selected = (ComboBoxItem)CbDataType.SelectedItem;
                if (selected.Content.ToString() == "XML")
                    LoadData(new Factory<ConcreteXML>());
                else if (selected.Content.ToString() == "TXT")
                    LoadData(new Factory<ConcreteTXT>());
            }
        }

        // Boton para cerrar el proyecto
        private void BtnCloseProgram_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        // Inicia una instancia del tipo de archivo que leera en la tabla
        public void LoadData<T>(Factory<T> factory) where T : AbstractRegistry, new()
        {
            var selected = (ComboBoxItem)CbEntity.SelectedItem;
            switch (selected.Content.ToString())
            {
                case "Estudiante":
                    ListStudents = factory.Get().GetStudents().ToList();
                    DgTableData.DataContext = ListStudents;
                    break;
                case "Carrera":
                    ListCareer = factory.Get().GetCareers().ToList();
                    DgTableData.DataContext = ListCareer;
                    break;
                case "Profesor":
                    ListProfessor = factory.Get().GetProfessors().ToList();
                    DgTableData.DataContext = ListProfessor;
                    break;
            }
            DgTableData.Items.Refresh();
        }

        // Insertar datos en la lista de Estudiantes
        public void ManageStudent(Student student, bool isNew)
        {
            if (isNew)
            {
                //Insertar Estudiante 
                //Load
                ListStudents.Add(student);
            }
            else
            {
                var temp = ListStudents.Find(s => s.Id == student.Id);
                ListStudents[ListStudents.IndexOf(temp)] = student;
            }
            DgTableData.DataContext = ListStudents;
            DgTableData.Items.Refresh();
        }
        // Insertar datos en la lista de Carreras
        public void ManageCareer(Career career, bool isNew)
        {
            if (isNew)
            {
                //Insertar Estudiante 
                //Load
                ListCareer.Add(career);
            }
            else
            {
                var temp = ListCareer.Find(s => s.Id == career.Id);
                ListCareer[ListCareer.IndexOf(temp)] = career;
            }
            DgTableData.DataContext = ListCareer;
            DgTableData.Items.Refresh();
        }
        // Insertar datos en la lista de Profesores
        public void ManageProfessor(Professor professor, bool isNew)
        {
            if (isNew)
            {
                //Insertar Estudiante 
                //Load
                ListProfessor.Add(professor);
            }
            else
            {
                var temp = ListProfessor.Find(s => s.Id == professor.Id);
                ListProfessor[ListProfessor.IndexOf(temp)] = professor;
            }
            DgTableData.DataContext = ListProfessor;
            DgTableData.Items.Refresh();
        }
    }
}
