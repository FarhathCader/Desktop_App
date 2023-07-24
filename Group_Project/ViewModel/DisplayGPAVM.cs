using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Group_Project.ViewModel
{
    public partial class DisplayGPAVM : ObservableObject
    {
        [ObservableProperty]
        public string gpa;

        public Action? CloseAction { get; set; }

        public DisplayGPAVM(double gpa_)
        {




            gpa = gpa_.ToString("F2");



        }


        [RelayCommand]
        public void exit()
        {

            CloseAction();
            Application.Current.MainWindow.Show();

        }





    }
}
