using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Desktop_App.Model;
using Group_Project.View;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Group_Project.ViewModel
{
    public partial class StudentMenuWindowVM : ObservableObject
    {

        [ObservableProperty]
        public string? name;

        [ObservableProperty]
        public string? regNo;
        [ObservableProperty]
        public string? selectedCourseName;
        [ObservableProperty]
        public int age;
        [ObservableProperty]
        public string gpa;


        [ObservableProperty]
        public Student student;


        public int StudentId { get; set; }
        public int UserId { get; set; }


        [ObservableProperty]
        public string imagePath;

        public Action CloseAction { get; internal set; }

        public StudentMenuWindowVM(int studentId)
        {
            StudentId = studentId;
            using (DataBaseContext context = new DataBaseContext())
            {
                student = context.Students.FirstOrDefault(x => x.StudentId == StudentId);

            }
            UserId = student.UserId;
            Load();

        }



        [RelayCommand]
        public void editStudent(Student std)
        {



            int temp = std.StudentId;

            if (student != null)
            {

                var editStudentVM = new AddStudentWindowVM(std, UserId);
                var window = new AddStudentWindow(editStudentVM);

                window.ShowDialog();





                using (DataBaseContext context = new DataBaseContext())
                {
                    var oldEntry = context.Students.FirstOrDefault(Student => Student.StudentId == temp);
                    oldEntry.RegNo = std.RegNo;
                    oldEntry.Name = std.Name;
                    oldEntry.Age = std.Age;
                    oldEntry.SelectedCourseName = std.SelectedCourseName;
                    oldEntry.UserId = std.UserId;
                    oldEntry.CourseId = std.CourseId;
                    
                    context.SaveChanges();
                    Load();




                }








            }





        }


        [RelayCommand]
        public void editPhoto(int studentId)
        {

            using (var context = new DataBaseContext())
            {
                var std = context.Students.FirstOrDefault(x => x.StudentId == studentId);


                OpenFileDialog dialog = new OpenFileDialog();

                dialog.Filter = "Image files | *.bmp; *.png; *.jpg";
                dialog.FilterIndex = 1;
                if (dialog.ShowDialog() == true)
                {
                    BitmapImage image = new BitmapImage(new Uri(dialog.FileName));

                    std.ImagePath = image.ToString();
                    context.SaveChanges();
                    imagePath = image.ToString();
                    OnPropertyChanged(nameof(imagePath));


                    MessageBox.Show(std.ImagePath);
                }


            }

        }




        public void Load()
        {
            name = student.Name;
            OnPropertyChanged(nameof(name));
            age = student.Age;
            OnPropertyChanged(nameof(age));

            regNo = student.RegNo;
            OnPropertyChanged(nameof(regNo));

            gpa = student.Gpa.ToString("F2");
            OnPropertyChanged(nameof(gpa));

            selectedCourseName = student.SelectedCourseName;
            OnPropertyChanged(nameof(selectedCourseName));

            imagePath = student.ImagePath;
            OnPropertyChanged(nameof(imagePath));

        }



        [RelayCommand]
        public void changePassword(Student student)
        {

            var editpasswordvm = new StudentPasswordChangeVM(student);
            var window = new StudentPasswordChangeWindow(editpasswordvm);
            window.ShowDialog();

        }


        [RelayCommand]
        public void calGpa(Student student)
        {
            var calGpaVM = new GPACalculationWindowVM(student);
            var window = new GPACalculationWindow(calGpaVM);
            window.ShowDialog();
            Load();
            OnPropertyChanged(nameof(gpa));

        }


        [RelayCommand]
        public void exit()
        {
            CloseAction();
            Application.Current.MainWindow.Show();

        }


    }
}
