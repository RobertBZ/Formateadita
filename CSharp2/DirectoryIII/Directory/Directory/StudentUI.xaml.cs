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
using System.Windows.Shapes;

namespace Directory
{
    /// <summary>
    /// Lógica de interacción para Student.xaml
    /// </summary>
    public partial class StudentUI : Window
    {
        public delegate void GetStudent(Student student, bool isNew);
        public event GetStudent OnAccept;
        private Student Student { get; set; }
        private bool isNew = true;
        public StudentUI()
        {
            InitializeComponent();
        }

        public StudentUI(Student student)
            : this()
        {
            Student = student;
            isNew = false;
            TbAge.Text = student.Age.ToString();
            TbCareer.Text = student.CareerCode;
            TbId.Text = student.Id.ToString();
            TbLastname.Text = student.Lastname;
            TbName.Text = student.Name;
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            if (OnAccept != null)
            {
                Student instance = new Student
                {
                    Id = int.Parse(TbId.Text),
                    Name = TbName.Text,
                    Lastname = TbLastname.Text,
                    CareerCode = TbCareer.Text,
                    Age = int.Parse(TbAge.Text)
                };
                OnAccept(instance, isNew);
            }
            Close();
        }
    }
}
