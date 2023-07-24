using CommunityToolkit.Mvvm.ComponentModel;
using Desktop_App.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Desktop_App.Model.User;
using System.Windows.Data;
using Group_Project.View;
using CommunityToolkit.Mvvm.Input;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Security.Cryptography.X509Certificates;
using System.Data;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace Group_Project.ViewModel
{
    public partial class AdminMenuVM : ObservableObject
    {

        public DataBaseContext context = new DataBaseContext();




        [ObservableProperty]
        public ObservableCollection<User> userList;


        [ObservableProperty]
        public string? userName;

        [ObservableProperty]
        public string? password;

        [ObservableProperty]
        public User user;


        [ObservableProperty]
        public User selectedUser;


        public Action CloseAction { get; internal set; }



        public AdminMenuVM()
        {

            using (var context = new DataBaseContext())
            {
                var usertype = UserRole.Admin;
                var adminExists = context.Users.FirstOrDefault(u => u.Role == usertype);
                if (adminExists != null)
                {
                    int id_ = adminExists.UserId;

                    List<Course> defaultCourses = new List<Course>
        {

                new Course("EIE", "Electrical Engineering", id_),
                new Course("CE", "Computer Engineering", id_),
                new Course("ME", "Mechanical Engineering",  id_),
                new Course("CEE", "Civil Engineering", id_)
        };


                    int check = context.Courses.Count();
                    foreach (Course course in defaultCourses)
                    {
                        if (!context.Courses.Any(s => s.CourseId == course.CourseId) && check == 0)
                        {
                            context.Courses.Add(course);
                            course.AddDefaultModules();
                            adminExists.Courses.Add(course);
                        }
                    }

                    context.SaveChanges();
                }
            }
            Load();





        }




        [RelayCommand]
        public void AddUser()
        {
            var addUserVM = new AddUserWindowVM();
            AddUserWindow window = new AddUserWindow(addUserVM);

            window.ShowDialog();

            if (addUserVM.User != null)
            {

                // userList.Add(addUserVM.User);
                using (context = new DataBaseContext())
                {
                    var exist = context.Users.FirstOrDefault(u => u.UserName == addUserVM.User.UserName);
                    if (exist == null)
                    {
                        addUserVM.User.Role = UserRole.NormalUser;
                        context.Users.Add(addUserVM.User);
                        context.SaveChanges();
                        Load();

                    }
                    else
                    {
                        MessageBox.Show("An error occurred: entered UserName is already exist", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }

                }

            }

        }




        [RelayCommand]
        public void removeUser(User user)
        {

            var vm = MessageBox.Show($"Do you want to Delete {user.UserName} from the System! It will lose {user.UserName}'s Registered Students and Course Details", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (vm == MessageBoxResult.Yes)
            {
                if (user.Role == UserRole.NormalUser)
                {

                    using (var context = new DataBaseContext())
                    {
                        context.Users.Remove(user);
                        context.SaveChanges();
                        Load();
                    }

                }
                else MessageBox.Show("An error occurred: Admin cannot be deleted", "Error", MessageBoxButton.OK, MessageBoxImage.Error);


            }


        }




        [RelayCommand]
        public void Load()
        {
            context = new DataBaseContext();
            var list = context.Users.ToList();
            userList = new ObservableCollection<User>(list);
            OnPropertyChanged(nameof(userList));
        }




        [RelayCommand]

        public void AddCourse()
        {
            var addCourseVM = new AdminCourseMenuVM();
            AdminCourseMenu window = new AdminCourseMenu(addCourseVM);

            window.ShowDialog();

           
        }

        [RelayCommand]
        public void editUser(User user)
        {

            int temp = user.UserId;
            if (user != null)
            {
                var editUserVM = new AddUserWindowVM(user);
                var window = new AddUserWindow(editUserVM);
                using (context = new DataBaseContext())
                {
                    var oldEntry = context.Users.FirstOrDefault(User => User.UserId == temp);



                }

                window.ShowDialog();



                using (context = new DataBaseContext())
                {
                    var oldEntry = context.Users.FirstOrDefault(User => User.UserId == temp);

                    oldEntry.UserName = editUserVM.User.UserName;
                    oldEntry.Password = editUserVM.User.Password;
                    oldEntry.Role = editUserVM.User.Role;
                    context.SaveChanges();
                    Load();




                }








            }




        }

        [RelayCommand]
        public void exit()
        {
            CloseAction();
            Application.Current.MainWindow.Show();

        }


    }
}





    

    
