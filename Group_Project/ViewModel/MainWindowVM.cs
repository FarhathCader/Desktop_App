using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Desktop_App.Model;
using Group_Project.View;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Group_Project.ViewModel
{
    public partial class MainWindowVM : ObservableObject
    {

     
        [ObservableProperty]
        public string? userName;
        [ObservableProperty]
        public string? password;

        

        [ObservableProperty]
        ObservableCollection<User> userList;



        private string _errorMessage;
        public string ErrorMessage
        {
            get { return _errorMessage; }
            set
            {
                _errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
            }
        }
        public MainWindowVM()
        {



            using (var context = new DataBaseContext())
            {
                

            }

           



        }





        [RelayCommand]
        public void adminLogin()
        {

            using (var context = new DataBaseContext())
            {

                
                var user = context.Users.FirstOrDefault(s => s.UserName == userName);
                if (user != null && password == user.Password && user.Role == User.UserRole.Admin)
                {
                    var adminmenu = new AdminMenu();
                    adminmenu.ShowDialog();
                    userName = null; password = "";

                    OnPropertyChanged(nameof(userName));
                    OnPropertyChanged(nameof(password));

                }
                else
                {

                    ErrorMessage = "UserName or Password is Incorrect";

                }

            }

         
            
            





        }



        [RelayCommand]
        public void userLogin()
        {
            using (DataBaseContext context = new DataBaseContext())
            {
                var curruser = context.Users.FirstOrDefault(St => St.UserName == userName && St.Password == password);

                if (curruser != null && curruser.Role == User.UserRole.NormalUser)
                {
                   
                    var userMenuvm = new UserMenuVM(curruser.UserId,curruser.UserName);
                    var usermenu = new UserMenu(userMenuvm);

                    usermenu.ShowDialog();
                    userName = null; password = "";

                    OnPropertyChanged(nameof(userName));
                    OnPropertyChanged(nameof(password));


                }
                else
                {
                    ErrorMessage = "UserName or Password is Incorrect";
                }

            }



        }
        [RelayCommand]
        public void studentLogin()
        {
            using (DataBaseContext context = new DataBaseContext())
            {
                var currStudent = context.Students.FirstOrDefault(St => St.RegNo == userName && St.Password == password);

                if (currStudent != null)
                {

                    var StudentMenuVM = new StudentMenuWindowVM(currStudent.StudentId);
                    var window = new StudentMenuWindow(StudentMenuVM);
                    window.ShowDialog();
                    userName= null; password= "";
                    
                    OnPropertyChanged(nameof(userName));
                    OnPropertyChanged(nameof(password));





                }
                else
                {
                    ErrorMessage = "Reg No or Password is Incorrect";
                }

            }



        }


    }
}
