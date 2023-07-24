using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Desktop_App.Model;
using Group_Project.View;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Group_Project.ViewModel
{
    public partial class AdminCourseMenuVM : ObservableObject
    {

        [ObservableProperty]
        public string? courseName;

        [ObservableProperty]
        public string? code;

        [ObservableProperty]
        public ObservableCollection<Course> courseList;

        public Course Course { get; set; }


        public string? temp;

        public Action CloseAction { get; internal set; }




        public Course OriginalCourse { get; set; }

        public AdminCourseMenuVM()
        {

            Load();




        }

        [RelayCommand]
        public void Load()
        {
            DataBaseContext context = new DataBaseContext();
            var course = context.Users.Include(u => u.Courses).FirstOrDefault(u => u.UserId == 1);
            courseList = course.Courses;
            OnPropertyChanged(nameof(courseList));
            OnPropertyChanged(nameof(courseName));
            OnPropertyChanged(nameof(code));



        }

        [RelayCommand]
        public void save()
        {

            if (code == null || code == "") MessageBox.Show("Course Code  cannot be Empty ", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            else if (courseName == null || courseName == "") MessageBox.Show("Course Name cannot be Empty ", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);

            else
            {


                if (Course == null)
                {
                    Course = new Course
                    {
                        UserId = 1,
                        Code = code,
                        CourseName = courseName,
                    };

                }
                else
                {
                    Course.Code = code;
                    Course.CourseName = courseName;
                    Course.UserId = 1;

                }

                var vm = MessageBox.Show("Are you sure want to make changes", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if(vm == MessageBoxResult.Yes)
                {
                    Course existingCourse;
                    using (var context = new DataBaseContext())
                    {

                        existingCourse = context.Courses.FirstOrDefault(u => u.CourseId == Course.CourseId);




                        if (existingCourse != null)
                        {
                            existingCourse.CourseName = courseName;
                            existingCourse.UserId = 1;
                            existingCourse.Code = code;
                            context.SaveChanges();
                            temp = null;
                            Course = null;
                            code = null;
                            courseName = null;
                            Load();



                        }

                        else
                        {
                            

                                existingCourse = context.Courses.FirstOrDefault(u => u.CourseName == Course.CourseName);

                            

                            if (existingCourse != null)
                            {
                                MessageBox.Show("Course with sameName already Exists", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                                if (OriginalCourse == null) Course = null;

                            }
                            else
                            {
                              
                                    context.Courses.Add(Course);
                                    var CurrUser = context.Users.FirstOrDefault(u => u.UserId == 1);
                                    CurrUser.Courses.Add(Course);
                                    Course.AddDefaultModules();
                                    context.SaveChanges();
                                    Course = null;
                                    code = null;
                                    courseName = null;
                                     Load();
                                   
                                  
                                

                            }


                        }



                    }


                }




                  

                



            }

            















        }



        [RelayCommand]
        public void editCourse(Course course)
        {

           courseName = course.CourseName;
           code = course.Code;
            temp = courseName;
            OriginalCourse = course;
               
            
            Course = course;
            Load();
            


                
            }


        




        [RelayCommand]

        public void exit()
        {
            CloseAction();
            Application.Current.MainWindow.Show();
        }

        [RelayCommand]
        public void removeCourse(Course course)
        {

            var vm = MessageBox.Show("Are you sure want to Delete!!! You will Lose all enrolled students for this course", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (vm == MessageBoxResult.Yes)
            {
                if (course.CourseName != "Mechanical Engineering" && course.CourseName != "Electrical Engineering" && course.CourseName != "Civil Engineering" && course.CourseName != "Computer Engineering")
                {

                    using (var context = new DataBaseContext())
                    {
                        context.Courses.Remove(course);
                        context.SaveChanges();
                        Load();
                    }


                }
                else
                {
                    MessageBox.Show("You cannot Delete default Courses. Contact Administration!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                }



            }

            courseName = null;
            code = null;
            temp = null;
            Load();



        }



        [RelayCommand]

        public void addModules(Course course)
        {

            int temp = course.CourseId;

            if (course != null)
            {

                var addmodulevm = new AddModuleWindowVM(course);
                var window = new AddModuleWindow(addmodulevm);

                window.ShowDialog();












            }

        }
    }


}