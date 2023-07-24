using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Desktop_App.Model;
using Group_Project.View;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Xml.Linq;
using Module = Desktop_App.Model.Module;

namespace Group_Project.ViewModel
{
    public partial class AddModuleWindowVM : ObservableObject
    {
        [ObservableProperty]
        public string? moduleName;

        [ObservableProperty]
        public string? moduleCode;

        [ObservableProperty]
        public int   credits;


        public Module Module { get; set; }


        public int CourseId { get; set; }


        [ObservableProperty]
        public ObservableCollection<Module> moduleList;


        public DataBaseContext context = new DataBaseContext();

        public Module OriginalModule;


        public string temp; 
        public Action? CloseAction { get; internal set; }




        public AddModuleWindowVM(Module u,int id_)
        {
             //Module = u;
            //Id = u.Id;
            //moduleName = u.ModuleName;
            //moduleCode = u.ModuleCode;
            //credits = u.Credits;
            //ModuleId = id_;
            //OriginalModule = u;
            temp = u.ModuleName;
            //Load();

        }
        public AddModuleWindowVM(Course u)
        {
             CourseId = u.CourseId;
             Load();
             OriginalModule = null;



        }


        [RelayCommand]
        public void save()
        {

            if (moduleCode == null || moduleCode == "") MessageBox.Show("hello", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            else if (moduleName == null || moduleName == "") MessageBox.Show("Module Name cannot be Empty ", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            else if (credits == null || !(credits is int)) MessageBox.Show("Invalid Credits ", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);

            else
            {


                if (Module == null)
                {
                    Module = new Module
                    {
                        ModuleCode = moduleCode,
                        ModuleName = moduleName,
                        Credits = credits,
                        CourseId = CourseId

                    };

                }
                else
                {
                    Module.ModuleCode = moduleCode;
                    Module.ModuleName = moduleName;
                    Module.Credits = credits;
                    Module.CourseId = CourseId;

                }

                var vm = MessageBox.Show("Are you sure want to make changes", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (vm == MessageBoxResult.Yes)
                {
                    Module existingModule;
                    using (var context = new DataBaseContext())
                    {

                        existingModule = context.Modules.FirstOrDefault(u => u.ModuleId == Module.ModuleId);




                        if (existingModule != null)
                        {
                            existingModule.ModuleName = moduleName;
                            existingModule.ModuleCode = moduleCode;
                            existingModule.Credits = credits;
                            context.SaveChanges();
                            temp = null;
                            Module = null;
                            credits = 0;
                            moduleName = null;
                            moduleCode = null;
                            Load();



                        }

                        else
                        {


                            existingModule = context.Modules.FirstOrDefault(u => u.ModuleName == Module.ModuleName && u.CourseId == CourseId);



                            if (existingModule != null)
                            {
                                MessageBox.Show("Module with sameName already Exists", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                                if (OriginalModule == null) Module = null;

                            }
                            else
                            {

                                context.Modules.Add(Module);
                               
                                var CurrCourse = context.Courses.FirstOrDefault(u => u.CourseId == CourseId);
                                CurrCourse.Modules.Add(Module);
                                Module = null;
                                moduleCode = null;
                                moduleName = null;
                                credits = 0;
                                context.SaveChanges();
                                Load();




                            }


                        }



                    }


                }










            }

















        }












        [RelayCommand]
        public void editModule(Module module)
        {
            credits = module.Credits;
            moduleCode = module.ModuleCode;
            moduleName = module.ModuleName;
            temp = module.ModuleName;
            OriginalModule = module;
            Module = module;
            Load();





        }



        [RelayCommand]
        public void removeModule(Module module)
        {

            var vm = MessageBox.Show("Are you sure want to delete module", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (vm == MessageBoxResult.Yes)
            {
                using (var context = new DataBaseContext())
                {
                    context.Modules.Remove(module);
                    context.SaveChanges();
                    Load();
                }
            }


            moduleCode = null;
            moduleName = null;
            credits = 0;
            Load();



        }





        [RelayCommand]
        public void Load()
        {

            DataBaseContext context = new DataBaseContext();
            var module = context.Courses.Include(u => u.Modules).FirstOrDefault(u => u.CourseId == CourseId);
            moduleList = module.Modules;
        
            OnPropertyChanged(nameof(moduleList));

            OnPropertyChanged(nameof(credits));
            OnPropertyChanged(nameof(moduleName));
            OnPropertyChanged(nameof(moduleCode));


        }
   


        [RelayCommand]
        public void exit()
        {

            CloseAction();
            Application.Current.MainWindow.Show();

        }



    }
}
