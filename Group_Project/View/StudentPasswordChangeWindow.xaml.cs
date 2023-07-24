﻿using System;
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
using Group_Project.ViewModel;


namespace Group_Project.View
{
    /// <summary>
    /// Interaction logic for StudentPasswordChangeWindow.xaml
    /// </summary>
    public partial class StudentPasswordChangeWindow : Window
    {
        public StudentPasswordChangeWindow(StudentPasswordChangeVM vm)
        {
            InitializeComponent();
            DataContext = vm;
            vm.CloseAction = () => Close();

        }
    }
}
