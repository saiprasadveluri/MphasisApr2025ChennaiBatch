using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DownloadManagerDI1;
namespace ServiceLocDIDemoWin
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Register Services
            /*NameServiceLocator Nameloc= NameServiceLocator.Instance;
            Nameloc.RegisterService("SMS", new SMSSender());
            Nameloc.RegisterService("EMAIL", new EmailSender());*/
            GenericServiceLocator locator = GenericServiceLocator.Instance;
            //locator.RegisterService<IMessageSender>(new EmailSender());
            Application.Run(new Form1());
        }
    }
}
