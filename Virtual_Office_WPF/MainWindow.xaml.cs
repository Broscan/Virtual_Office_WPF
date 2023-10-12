using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Virtual_Office_WPF
{
    public partial class MainWindow : Window
    {

        List<ListBoxItem> persons = new();


        public MainWindow()
        {
            InitializeComponent();

            Manager manager = new();

            manager.LoopEnum(cbDepartment);


        }

        public void btn_Add(object sender, RoutedEventArgs e)
        {
            Manager newManager = new();

            ListBoxItem item = new();
            item = newManager.SaveEmployee(txtFirstName, txtLastName, txtAge, txtSalary, txtBiography, cbDepartment);

            lbEmployees.Items.Add(item);
            persons.Add(item);


        }

        private void ClearUI()
        {
            lbEmployees.Items.Clear();
        }

        private void btn_Edit(object sender, RoutedEventArgs e)
        {
            if (lbEmployees.SelectedItem == null)
            {
                return;
            }

            ListBoxItem item = (ListBoxItem)lbEmployees.SelectedItem;

            Employee newEmployee = (Employee)item.Tag;

            DetailsWindow detailsWindow = new(newEmployee);

            detailsWindow.Show();

            Close();

        }
    }

}
