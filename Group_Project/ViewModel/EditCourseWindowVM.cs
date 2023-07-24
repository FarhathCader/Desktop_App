using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Desktop_App.Model;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;

namespace Group_Project.ViewModel
{
    public partial class EditCourseWindowVM : ObservableObject
    {
        [ObservableProperty]
        public string courseName;
        [ObservableProperty]
        public string code;
        //[ObservableProperty]
        //public int credits;


        public int UserId { get; set; }
        public DataBaseContext context = new DataBaseContext();
        public Course Course { get; private set; }

        public string temp { get; set; }

        [ObservableProperty]
        public ObservableCollection<Course> courseList;

        public Action CloseAction { get; internal set; }
        public Course OriginalCourse;

        public EditCourseWindowVM(Course u)
        {
            Course = u;
            courseName = u.CourseName;
            //courseId = u.CourseId;
            UserId = u.UserId;
            OriginalCourse = u;
            temp = u.CourseName;

        }
        public EditCourseWindowVM(User u)
        {
            UserId = u.UserId;
            Load();
            OriginalCourse = null;



        }

        public EditCourseWindowVM(int u_id)
        {

            UserId = u_id;
            Load();
            // selectedCourseName = coursesList[0].CourseName;
          //  selectedCourse = coursesList[0];


            OriginalCourse = null;
        }



        public EditCourseWindowVM()
        {


        }

   

        [RelayCommand]
        public void save()
        {

            if (code == null || code== "") MessageBox.Show("Course Code  cannot be Empty ", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            else if (courseName == null || courseName == "") MessageBox.Show("Course Name cannot be Empty ", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);

            else
            {

               
                if (Course == null)
                {
                    Course = new Course
                    {
                        UserId = UserId,
                        Code = code,
                        CourseName = courseName,
                    };

                }
                else
                {
                    Course.Code = code;
                    Course.CourseName = courseName;
                    Course.UserId = UserId;

                }

             
                bool existingCourse;
                using (var context = new DataBaseContext())
                {

                    existingCourse = context.Courses.Any(u => u.CourseName == Course.CourseName);


                }

                if (Course.CourseName != temp && existingCourse)
                {
                    MessageBox.Show("Course with same name already Exists", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    if (OriginalCourse == null) Course = null;

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
                if (OriginalCourse != null)
                {
                    Course.Code = OriginalCourse.Code;
                    Course.CourseName = OriginalCourse.CourseName;
                   
                    Course.UserId = OriginalCourse.UserId;
                   


                }
                else
                {
                    Course = null;

                }

                CloseAction();
                Application.Current.MainWindow.Show();
            }


        }





        [RelayCommand]
        public void Load()
        {
            DataBaseContext context = new DataBaseContext();
            var courses = context.Courses.ToList();
            courseList = new ObservableCollection<Course>(courses);
            OnPropertyChanged(nameof(courseList));


        }



    }
}
