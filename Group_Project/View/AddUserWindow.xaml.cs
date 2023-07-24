using Desktop_App.Model;
using Group_Project.ViewModel;
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
    /// Interaction logic for AddUserWindow.xaml
    /// </summary>
    public partial class AddUserWindow : Window
    {
        public AddUserWindow(AddUserWindowVM vm)
        {
            InitializeComponent();
            DataContext = vm;
            vm.CloseAction = () => Close();
        }



        private void Border_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }



        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (DataContext is AddUserWindowVM viewModel)
            {
                if (sender is PasswordBox passwordBox)
                {
                    viewModel.password = passwordBox.Password;
                }
            }
        }

    
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            

            var vm = MessageBox.Show("Are you sure want to cancel", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (vm == MessageBoxResult.Yes)
            {
                this.Close();

                // Show the previous window
                AdminMenu previousWindow = new AdminMenu();
                previousWindow.Show();
            }
           

        }
    }
}
