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





    }
    public partial class MainWindow : Window
    {





        public MainWindow()
        {
            InitializeComponent();

            Manager manager = new();

            manager.LoopEnum(cbDepartment);


        }


    }



}
