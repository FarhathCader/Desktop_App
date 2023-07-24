﻿using Group_Project.ViewModel;
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

namespace Group_Project.View
{
    /// <summary>
    /// Interaction logic for UserMenu.xaml
    /// </summary>
    public partial class UserMenu : Window
    {
        public UserMenu(UserMenuVM userMenuVM)
        {
            DataContext = userMenuVM;
            InitializeComponent();
            userMenuVM.CloseAction = () => Close();

        }


        //private void exitApp(object sender, RoutedEventArgs e)
        //{
        //    var vm = new MainWindow();
        //    vm.Show();
        //    this.Close();

        //}
    }
}
