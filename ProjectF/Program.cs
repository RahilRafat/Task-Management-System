using Microsoft.EntityFrameworkCore;
using ProjectF.Models;
using ProjectF.TaskForms;


namespace ProjectF
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
        //    // To customize application configuration such as set high DPI settings or default font,
        //    // see https://aka.ms/applicationconfiguration.
          //ApplicationConfiguration.Initialize();
        //    Application.Run(new Form1());

         Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        //LogInForm loginForm = new LogInForm();
        using(var context =new TaskManagmentContext())
            {
                RegisterForm registerForm = new RegisterForm(context);

                Application.Run(registerForm);
            }
        


        }
    }
}