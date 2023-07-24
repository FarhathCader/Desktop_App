using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop_App.Model;


namespace Desktop_App.Model
{
    public class Module
    {
        [Key]
        public int ModuleId { get; set; }
        public string? ModuleName { get; set; }
        public string? ModuleCode { get; set;}
        //public Lecturer? ModuleCoordinator { get; set; }

        public int Credits { get; set; }

        public Course Course { get; set; }


        public int CourseId { get; set; }


        [NotMapped] public List<string>? Grades { get; set; } = new List<string> { "A+", "A", "A-", "B+", "B", "B-", "C+", "C", "C-" ,"F"};

        public string Result { get; set; }

        public Module(string? moduleName, string? moduleCode, int credits)
        {
            ModuleName = moduleName;
            ModuleCode = moduleCode;
            Credits = credits;
            Result = "";
        }


        public Module() { 
            Result = "";
        }
    }



 
}
