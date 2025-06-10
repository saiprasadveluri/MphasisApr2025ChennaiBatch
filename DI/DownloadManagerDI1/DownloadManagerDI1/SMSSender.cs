using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadManagerDI1
{
    internal class SMSSender: IMessageSender
    {
        public void SendMessage(string message)
        {
            //Code for sending email....
            Console.WriteLine("SMS Sent: " + message);
        }
    }
}
