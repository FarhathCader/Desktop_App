using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_App.Model
{
    public class Student
    {

        [Key]
        public int StudentId { get; set; }

        public string RegNo { get; set; }

        public string? Name { get; set; }
       
        public string  SelectedCourseName{ get; set; }
        public int Age { get; set; }
        public double Gpa { get; set; }

        
        public int CourseId { get; set; } // foreignkey
        public Course Course { get; set; } //


        public int UserId { get; set; } //Foreign Key

       
        public User User { get; set; }

        public string ImagePath { get; set; }

        public string? Password { get; set; }









        public Student()
        {
            Password = "123";

            Gpa = 0;
        }

    
    }
}
