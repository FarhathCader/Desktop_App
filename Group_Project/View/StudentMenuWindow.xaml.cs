using Group_Project.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Group_Project.View
{
    /// <summary>
    /// Interaction logic for StudentMenuWindow.xaml
    /// </summary>
    public partial class StudentMenuWindow : Window
    {
        public StudentMenuWindow(StudentMenuWindowVM vm)
        {
            DataContext = vm;
            InitializeComponent();
            vm.CloseAction = () => Close();

        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    var window = new MainWindow();
        //    window.Show();
        //    this.Close();
        //}
    }
}
