using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Desktop_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Group_Project.ViewModel
{
    public partial class StudentPasswordChangeVM : ObservableObject
    {


        public Action? CloseAction { get; set; }


        [ObservableProperty]
        public string oldPassword;

        [ObservableProperty]
        public string newPassword;


        public Student Student { get; set; }


        public StudentPasswordChangeVM(Student student)
        {



            Student = student;



        }


        [RelayCommand]
        public void save()
        {
            if(Student.Password != oldPassword)
            {
                MessageBox.Show("Old Password is Wrong!");

            }
            else
            {

                if(newPassword == null || newPassword == "") {


                    MessageBox.Show("Password cannot be empty");
                }
                else
                {

                    using(DataBaseContext context = new DataBaseContext())
                    {
                        var std = context.Students.FirstOrDefault(s => s.StudentId == Student.StudentId);
                        std.Password = newPassword;
                        context.SaveChanges();
                        CloseAction();


                    }

                }
            }
        }








    }
}
