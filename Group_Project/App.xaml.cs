using Desktop_App.Model;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using static Desktop_App.Model.User;

namespace Group_Project
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
          
            using (var context = new DataBaseContext())
            {

                bool adminExists = context.Users.Any(u => u.Role == UserRole.Admin);
               
               

                if (!adminExists)
                {
                    User adminUser = new User
                    {
                        UserName = "admin",
                        Password = "123",
                        Role = UserRole.Admin
                    };

                    context.Users.Add(adminUser);
                    context.SaveChanges();
                }

             
            }

        }
    }
}
