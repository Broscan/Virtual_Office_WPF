using System;
using System.Windows;
using System.Windows.Controls;

namespace Virtual_Office_WPF
{
    public class Manager : MainWindow
    {
        enum Department
        {
            Finances,
            Administration,
            Production,
            Marketing
        }

        public void LoopEnum(ComboBox cbDepartment)
        {
            foreach (Enum @enum in Enum.GetValues(typeof(Department)))
            {
                cbDepartment.Items.Add(@enum);
            }
        }

        public void SaveEmployee()
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string age = txtAge.Text;
            string salary = txtSalary.Text;
            string biography = txtBiography.Text;
            string department = cbDepartment.SelectedItem.ToString();

            if (firstName != null && lastName != null && age != null && salary != null && biography != null)
            {
                ListBoxItem newEmployee = new();






            }
            else
            {
                MessageBox.Show("Must fill in all fields!");
            }


        }


    }

}
