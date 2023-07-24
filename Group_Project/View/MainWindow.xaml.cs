using Group_Project.ViewModel;
using MaterialDesignThemes.Wpf;
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
using static Desktop_App.Model.User;

namespace Group_Project.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new MainWindowVM();
            InitializeComponent();
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (DataContext is MainWindowVM viewModel)
            {
                if (sender is PasswordBox passwordBox)
                {
                    viewModel.Password = passwordBox.Password;

                }
            }
        }

        

        private void exitApp(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            using (var context = new DataBaseContext())
            {

                var usertype = UserRole.Admin;
                var adminExists = context.Users.FirstOrDefault(u => u.Role == usertype);
                if (adminExists != null)
                {
                    MessageBox.Show($"password has been set to default & admin's username found as {adminExists.UserName}  ");
                    adminExists.Password = "123";
                    context.SaveChanges();
                }
              
               
              
            }

        }
    }

  
}
