using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Desktop_App.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Group_Project.ViewModel
{
    public partial class AddStudentWindowVM : ObservableObject
    {
        [ObservableProperty]
        public string? name;



        public int UserId { get; set; }

        [ObservableProperty]
        public string regNo;

        [ObservableProperty]
        public ObservableCollection<Student> studentList;


        [ObservableProperty]
        public ObservableCollection<Course> coursesList;

        [ObservableProperty]
        public Course selectedCourse;

        [ObservableProperty]
        public string selectedCourseName;


        [ObservableProperty]
        public int courseId;

        [ObservableProperty]
        public int age;

        [ObservableProperty]
        public double gpa;

        public Student? Student { get; private set; }
        public Action? CloseAction { get; internal set; }

        public string temp;

        public Student OriginalStudent;

     

        public AddStudentWindowVM(Student u,int u_id)
        {



            UserId = u_id;

            Load();


            Student = u;
            temp = u.RegNo;
            name = u.Name;
            age = u.Age;
            regNo = u.RegNo;
            

            List<Course> courseList = coursesList.ToList();
            int index = courseList.FindIndex(course => course.CourseId == u.CourseId);


            selectedCourse = coursesList[index];
            gpa = u.Gpa;
            courseId = u.CourseId;
            selectedCourseName = u.SelectedCourseName;

            OriginalStudent = u;







        }
        public AddStudentWindowVM(int u_id)
        {

            UserId = u_id;
            Load();
            selectedCourse = coursesList[0];
            OriginalStudent = null;

        }
        public AddStudentWindowVM()
        {

            Load();

        }




        [RelayCommand]
        public void save()
        {

            if (regNo == null || regNo == "") MessageBox.Show("please enter the Reg No", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);

            else  if (name == null || name == "") MessageBox.Show("Name cannot be Empty ", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            else if (age == 0 || !(age is int)) MessageBox.Show("Invalid Age", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);

            else if (selectedCourse == null) MessageBox.Show("please select a course", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            else
            {

                if (Student == null)
                {


                    Student = new Student()
                    {
                        RegNo = regNo,
                        Name = name,
                        Age = age,
                        Gpa = gpa,
                   
                        UserId = UserId,
                        SelectedCourseName = selectedCourse.CourseName,
                        CourseId = selectedCourse.CourseId,




                    };


                }

                else
                {
                    Student.RegNo = regNo;
                    Student.Name = name;
                    Student.Age = age;
                    
                    Student.Gpa = gpa;
                    Student.CourseId = selectedCourse.CourseId;
                    Student.SelectedCourseName = selectedCourse.CourseName;
                    Student.UserId = UserId;
                    


                    }

                bool existingStudent;
                using (var context = new DataBaseContext())
                {

                    existingStudent = context.Students.Any(u => u.RegNo == Student.RegNo);


                }

                if (Student.RegNo != temp && existingStudent)
                {
                    MessageBox.Show("Student with same Reg No already Exists", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                   if(OriginalStudent == null)Student = null;

                }


                else
                {

                    var vm = MessageBox.Show("Are you sure want to make changes", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                    if (vm == MessageBoxResult.Yes)
                    {

                        CloseAction();
                        Application.Current.MainWindow.Show();
                    }

                }





            }















        }
        








        [RelayCommand]
        public void Cancel()
        {
            var vm = MessageBox.Show("Are you sure want to cancel", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (vm == MessageBoxResult.Yes)
            {
                if (OriginalStudent != null)
                {
                    Student.RegNo = OriginalStudent.RegNo;
                    Student.Name = OriginalStudent.Name;
                    Student.Age = OriginalStudent.Age;
                    Student.UserId = OriginalStudent.UserId;
                    Student.CourseId = OriginalStudent.CourseId;


                }
                else
                {
                    Student = null;

                }

                CloseAction();
                Application.Current.MainWindow.Show();
            }


        }

        [RelayCommand]
        public void Load()
        {
            DataBaseContext context = new DataBaseContext();

            var course = context.Users.Include(u => u.Courses).FirstOrDefault(u => u.UserId == UserId);
            var collection1 = new ObservableCollection<Course>();
            if (course != null)
            {
                collection1 = course.Courses;
            }
        
            var list1 = collection1.ToList();

            var course2 = context.Users.Include(u => u.Courses).FirstOrDefault(u => u.UserId == 1);
            var collection2 = course2.Courses;
            var list2 = collection2.ToList();



            List<Course> combinedList = list1.Concat(list2).ToList();
            coursesList = new ObservableCollection<Course>(combinedList);


            OnPropertyChanged(nameof(coursesList));


        }

    }
}
