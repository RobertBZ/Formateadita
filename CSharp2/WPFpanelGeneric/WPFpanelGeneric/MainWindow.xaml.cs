using System.Windows;

namespace WPFpanelGeneric
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            FormData formData = new FormData();
            formData.Content = studentForm;
            formData.Show();
        }

        private void BtnCreateCareer_Click(object sender, RoutedEventArgs e)
        {
            CareerForm careerForm = new CareerForm();
            FormData formData = new FormData();
            formData.Content = careerForm;
            formData.Show();
        }

        private void BtnCreateUniversity_Click(object sender, RoutedEventArgs e)
        {
            UniversityForm universityForm = new UniversityForm();
            FormData formData = new FormData();
            formData.Content = universityForm;
            formData.Show();
        }
    }
}
