using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

using CommunityToolkit.Mvvm.Input;
using Desktop_App.Model;

using System.Windows;
using System.Windows.Media.Imaging;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Module = Desktop_App.Model.Module;
using Group_Project.View;

namespace Group_Project.ViewModel
{
    public partial class GPACalculationWindowVM : ObservableObject
    {

        [ObservableProperty]
        public ObservableCollection<Module> courseModules;

        [ObservableProperty]
        public ObservableCollection<string> grades;


        [ObservableProperty]
        public string studentName;

        [ObservableProperty]
        public string courseName;


        public int StudentId { get; set; }


        public Student Student { get; set; }

        public GPACalculationWindowVM(Student student)
        {

            Student = student;

            using (DataBaseContext context = new DataBaseContext())
            {


              //  var currStudent = context.Students.FirstOrDefault(x => x.StudentId == studentId);
                studentName = student.Name;
                //var selectedCourse = context.Courses.FirstOrDefault(x=>x.CourseId == currStudent.CourseId);
                var course = context.Courses.Include(u => u.Modules).FirstOrDefault(u => u.CourseId == student.CourseId);

                courseModules = course.Modules;
                courseName = course.CourseName;
                StudentId = student.StudentId;





            }








        }


        public Action? CloseAction { get; set; }

        [RelayCommand]
        public void calculateGPA()
        {
            double totalCredits = courseModules.Sum(m => m.Credits);
            double totalWeightedGrade = courseModules.Sum(m => m.Credits * GetGradeWeight(m.Result));
            double gpa = totalWeightedGrade / totalCredits;

            var displayVM = new DisplayGPAVM(gpa);
            var window = new DisplayGPA(displayVM);
            using (DataBaseContext context = new DataBaseContext())
            {

                var currStudent = context.Students.FirstOrDefault(x => x.StudentId == StudentId);
                currStudent.Gpa = gpa;
                context.SaveChanges();

            }

            window.ShowDialog();
            Student.Gpa = gpa;

        }



        public double GetGradeWeight(string grade)
        {

            switch (grade)
            {
                case "A+": return 4.0;
                case "A": return 4.0;
                case "A-": return 3.7;
                case "B+": return 3.4;
                case "B": return 3.0;
                case "B-": return 2.7;
                case "C+": return 2.4;
                case "C": return 2.0;
                case "C-": return 1.7;
                default: return 0.0;
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
