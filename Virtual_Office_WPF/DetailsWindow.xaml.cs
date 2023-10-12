using System.Windows;

namespace Virtual_Office_WPF
{

    public partial class DetailsWindow : Window
    {
        public DetailsWindow(Employee employee)
        {
            InitializeComponent();

            txtFullName.Text = employee.FullName();
            txtAge.Text = employee.Age.ToString();
            txtSalary.Text = employee.Salary.ToString();
            txtBiography.Text = employee.ShowBio();
            txtDepartment.Text = employee.Department.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            MainWindow mainWindow = new();
            mainWindow.Show();

            Close();
        }
    }
}
