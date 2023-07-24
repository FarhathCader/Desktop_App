using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Desktop_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Input;
using Microsoft.EntityFrameworkCore;

namespace Group_Project.ViewModel
{
    public partial class AddUserWindowVM : ObservableObject
    {

        [ObservableProperty]
        public string? userName;
        [ObservableProperty]
        public string? password;

        [ObservableProperty]
        public User.UserRole role;


        public User User { get; private set; }
        public Action CloseAction { get; internal set; }



        public string temp;


        private User OriginalUser;



        public AddUserWindowVM(User u)
        {
            User = u;
            temp = u.UserName;
            userName = u.UserName;
            password = null;
            role = u.Role;
            OriginalUser = u;






        }
        public AddUserWindowVM()
        {
            OriginalUser = null;

        }






        [RelayCommand]
        public void save()
        {


            if (userName == null || userName == "") MessageBox.Show("User Name cannot be Empty ", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            else if (password == null || password == "") MessageBox.Show("Password cannot be Empty", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            else
            {
                if (User == null)
                {

                    User = new User()
                    {
                        UserName = userName,
                        Password = password,
                        Role = User.UserRole.NormalUser


                    };


                }
                else
                {

                    User.UserName = userName;
                    User.Password = password;
                    User.Role = role;




                }


                bool existingUser;
                using (var context = new DataBaseContext())
                {

                    existingUser = context.Users.Any(u => u.UserName == User.UserName);


                }

                if (User.UserName != temp && existingUser)
                {
                    MessageBox.Show("User Name Already Exists", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);


                }

                else
                {
                    CloseAction();
                    Application.Current.MainWindow.Show();

                }


            }









        }












        [RelayCommand]
        public void Cancel()
        {
            var vm = MessageBox.Show("Are you sure want to cancel", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (vm == MessageBoxResult.Yes)
            {


                if (OriginalUser != null)
                {
                    User.UserName = OriginalUser.UserName;
                    User.Password = OriginalUser.Password;
                    User.Role = OriginalUser.Role;


                }
                else User = null;

                CloseAction();
                Application.Current.MainWindow.Show();



            }
        }

    }
}
