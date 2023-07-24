using Desktop_App.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_App.Model
{
    public class Course
    {

        [Key]
        public int CourseId { get; set; }


        public string Code { get; set; }
        public string? CourseName { get; set; }
        // public int Credits { get; set; }
        //public List<Module>? Modules { get;}



        public ObservableCollection<Module> Modules { get; set; }
        public ObservableCollection<Student> Students { get; set; }


        public int UserId { get; set; } //Foreign Key


        public User User { get; set; }






        public Course()
        {
            Modules = new ObservableCollection<Module>();

          

               //Modules.Add(new Module("Digital Animatoin","IS4102",1));
               //Modules.Add(new Module("Econommic","IS4201",2));
               //Modules.Add(new Module("Maths","IS4302",3));


            Students = new ObservableCollection<Student>();





        }

        public Course(string code, string? courseName, int userId)
        {

            Modules = new ObservableCollection<Module>();

            Students = new ObservableCollection<Student>();


            //Modules.Add(new Module("Digital Animatoin", "IS4102", 1));
            //Modules.Add(new Module("Econommic", "IS4201", 2));
            //Modules.Add(new Module("Maths", "IS4302", 3));

            Code = code;
            CourseName = courseName;
            UserId = userId;
        }

        public void AddDefaultModules()
        {
            Modules.Add(new Module("Digital Animation", "IS4102", 1));
            Modules.Add(new Module("Economics", "IS4201", 2));
            Modules.Add(new Module("Maths", "IS4302", 3));
        }
    }
}
