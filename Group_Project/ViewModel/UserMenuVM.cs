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
using System.Windows.Media.Imaging;
using static Desktop_App.Model.User;

namespace Group_Project.ViewModel
{
    public partial class UserMenuVM : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<Student> studentList;

        [ObservableProperty]
        public ObservableCollection<Course> courseList;





        [ObservableProperty]
        public int userId;

        public Course? Course { get; internal set; }


        public DataBaseContext context = new DataBaseContext();


        public Action CloseAction { get; internal set; }


        [ObservableProperty]
        public string? courseId;

        [ObservableProperty]
        public string? userName;


        [ObservableProperty]
        public string? courseName;



        [ObservableProperty]
        public int credits;


        [ObservableProperty]
        public Student student;





        public User CurrUser { get; set; }



        public UserMenuVM(int user_id,string name)
        {

            userId = user_id;

            userName = name;


            Load();

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
                            adminExists.Courses.Add(course);
                            
                        }
                    }

                    context.SaveChanges();
                }
            }


            Load();





            using (DataBaseContext context = new DataBaseContext())
            {

                CurrUser = context.Users.FirstOrDefault(s => s.UserId == userId);
                if (CurrUser == null)
                    MessageBox.Show("User with this user name has not found");
            }





        }


        [RelayCommand]
        public void Load()
        {
            context = new DataBaseContext();


            //   var students = context.Students.Where(s => s.UserId == userId).ToList();
            //  var courses = context.Courses.Where(s => s.UserId == userId || s.UserId ==1).ToList();
           // courseList = new ObservableCollection<Course>(courses);
            // studentList = new ObservableCollection<Student>(students);
            var user = context.Users.Include(u => u.Students).FirstOrDefault(u => u.UserId == UserId);
            studentList = user.Students;
            OnPropertyChanged(nameof(studentList));

            var course = context.Users.Include(u => u.Courses).FirstOrDefault(u => u.UserId == UserId);
            courseList  = course.Courses;
            OnPropertyChanged(nameof(courseList));


        }

        [RelayCommand]
        public void registerStudent()
        {

            var addStudentVM = new AddStudentWindowVM(CurrUser.UserId);
            AddStudentWindow window = new AddStudentWindow(addStudentVM);

            window.ShowDialog();

            if (addStudentVM.Student != null)
            {
                using (context = new DataBaseContext())
                {
                    context.Users.Attach(CurrUser);

                    var exist = context.Students.FirstOrDefault(u => u.StudentId == addStudentVM.Student.StudentId);
                    if (exist == null)
                    {


                        BitmapImage image1 = new BitmapImage(new Uri($"/Model/Images/1.png", UriKind.Relative));
                        addStudentVM.Student.ImagePath = image1.ToString();

                        context.Students.Add(addStudentVM.Student);
                        CurrUser.Students.Add(addStudentVM.Student);
                        var course = context.Courses.FirstOrDefault(u => u.CourseId == addStudentVM.Student.CourseId);
                        course.Students.Add(addStudentVM.Student);
                       
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
        public void registerCourse()
        {

            var addCourseVM = new EditCourseWindowVM(CurrUser.UserId);
            EditCourseWindow window = new EditCourseWindow(addCourseVM);

            window.ShowDialog();

            if (addCourseVM.Course != null)
            {
                using (context = new DataBaseContext())
                {
                    var exist = context.Courses.FirstOrDefault(u => u.CourseId == addCourseVM.Course.CourseId);
                    if (exist == null)
                    {

                        context.Courses.Add(addCourseVM.Course);
                        CurrUser.Courses.Add(addCourseVM.Course) ;
                        if(!(context.Courses.Any(x=> x.CourseId == addCourseVM.Course.CourseId)))
                        {
                           addCourseVM.Course.AddDefaultModules();
                        }
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
        public void editStudent(Student student)
        {



            int temp = student.StudentId;

            if (student != null)
            {

                var editStudentVM = new AddStudentWindowVM(student,CurrUser.UserId);
                var window = new AddStudentWindow(editStudentVM);

                window.ShowDialog();





                using (context = new DataBaseContext())
                {
                    var oldEntry = context.Students.FirstOrDefault(Student => Student.StudentId == temp);

                    oldEntry.RegNo = student.RegNo;
                    oldEntry.Name = student.Name;
                    oldEntry.Age = student.Age;
                    oldEntry.SelectedCourseName = student.SelectedCourseName;
                    oldEntry.UserId = student.UserId;
                    oldEntry.CourseId = student.CourseId;

                    context.SaveChanges();
                    Load();




                }








            }





        }

        [RelayCommand]
        public void editCourse(Course course)
        {

            if (course.UserId == 1)
            {
                MessageBox.Show("You do not have permission to edit this course \nYou only have permission to delete courses created by your self", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            else
            {
                int temp = course.CourseId;

                if (course != null)
                {

                    var editCourseVM = new EditCourseWindowVM(course);
                    var window = new EditCourseWindow(editCourseVM);

                    window.ShowDialog();





                    using (context = new DataBaseContext())
                    {
                        var oldEntry = context.Courses.FirstOrDefault(x => x.CourseId == temp);

                        oldEntry.CourseName = course.CourseName;
                        oldEntry.Code = course.Code;
                        oldEntry.UserId = course.UserId;

                        context.SaveChanges();
                        Load();




                    }

                }









            }





        }
        [RelayCommand]
        public void removeStudent(Student student)
        {

            var vm = MessageBox.Show("Are you sure want to delete user", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (vm == MessageBoxResult.Yes)
            {
                using (var context = new DataBaseContext())
                {
                    context.Students.Remove(student);
                    context.SaveChanges();
                    Load();
                }
            }



        }



        [RelayCommand]
        public void removeCourse(Course course)
        {

            var vm = MessageBox.Show("Are you sure want to Delete!!! You will Lose all enrolled students for this course", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (vm == MessageBoxResult.Yes)
            {
                if(course.UserId != 1)
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
                        MessageBox.Show("You do not have permission to delete this course \nYou only have permission to delete courses created by your self", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                }



            }


        }



        [RelayCommand]
        public void addModule(Course course)
        {




            var addModuleVM = new AddModuleWindowVM(course);
            AddModuleWindow window = new AddModuleWindow(addModuleVM);

            window.Show();






        }
        [RelayCommand]
        public void exit()
        {
            CloseAction();
            Application.Current.MainWindow.Show();

        }




    }






    }


