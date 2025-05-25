using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FoodDeliveryApp.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace FoodDeliveryApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new LoginForm());
        }
    }
}
