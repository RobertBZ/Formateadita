using Core;
using Entity;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Directory
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Student> Students { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        public void LoadData<T>(Factory<T> factory) where T : AbstractRegistry, new()
        {
            var selected = (ComboBoxItem)CbEntity.SelectedItem;
            switch (selected.Content.ToString())
            {
                case "Estudiante":
                    Students = factory.Get().GetStudents().ToList();
                    DgData.DataContext = Students;
                    break;
                case "Carrera":
                    DgData.DataContext = factory.Get().GetCareers().ToList();
                    break;
                case "Profesor":
                    DgData.DataContext = factory.Get().GetProfessors().ToList();
                    break;
            }           
            DgData.Items.Refresh();
        }

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

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnNew_Click(object sender, RoutedEventArgs e)
        {
            StudentUI ui = new StudentUI();
            ui.OnAccept += ManageStudent;
            ui.Show();
        }

        private void ManageStudent(Student student, bool isNew)
        {
            if (isNew)
            {
                //Insertar Estudiante 
                //Load
                Students.Add(student);
            }
            else
            {
                var temp = Students.Find(s => s.Id == student.Id);
                Students[Students.IndexOf(temp)] = student;
            }
            DgData.DataContext = Students;
            DgData.Items.Refresh();
        }

        private void DgData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgData.SelectedValue != null)
            {
                StudentUI ui = new StudentUI((Student)DgData.SelectedValue);
                ui.OnAccept += ManageStudent;
                ui.Show();
            }
        }
    }
}
