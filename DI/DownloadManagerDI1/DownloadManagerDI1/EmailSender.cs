using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadManagerDI1
{
    internal class EmailSender: IMessageSender
    {
        public void SendMessage(string message)
        {
            //Code for sending email....
            Console.WriteLine("Mail Sent: "+message);
        }
    }
}
