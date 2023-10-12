using System;
using System.Windows;
using System.Windows.Controls;

namespace Virtual_Office_WPF
{
    public class Manager
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

        public ListBoxItem SaveEmployee(TextBox firstName, TextBox lastName, TextBox salary, TextBox age, TextBox bio, ComboBox department)
        {
            bool isAge = int.TryParse(age.Text, out int ageInt);
            bool isSalary = int.TryParse(salary.Text, out int salaryInt);


            if (firstName != null && lastName != null && isAge == true && isSalary == true && bio != null)
            {
                Employee newPerson = new(firstName.Text, lastName.Text, ageInt, salaryInt, bio.Text, department.Text);

                ListBoxItem newEmployee = new();


                newEmployee.Content = newPerson.FullName();
                newEmployee.Tag = newPerson;

                return newEmployee;

            }
            else
            {
                MessageBox.Show("Must fill in all fields!");
                return null;
            }


        }


    }

}
