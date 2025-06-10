using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadManagerDI1
{

    
    internal class DownloadManager
    {
       
        public IMessageSender messageSender { get; set; }
        public DownloadManager()
        {
            //messageSender = new SMSSender();
            //messageSender= _messageSender;
        }
        public void DoAction(string Url)
        {
            //F-1:Implemetning Download op from input URL
            Console.WriteLine($"Downlaoding from URL:{Url}");
            //F:2 Send Email to Client.
            Console.WriteLine($"Email Message sent");
        }

        public void DoAction_V2(string Url)
        {
            EmailSender emailSender = new EmailSender();
            //IMessageSender sender = new EmailSender();
            //F-1:Implemetning Download op from input URL
            Console.WriteLine($"Downlaoding from URL:{Url}");
            /*//F:2 Send Email to Client.
            Console.WriteLine($"Email Message sent");*/
            emailSender.SendMessage("Success");
        }

        public void DoAction_V3(string Url)
        {
            //IMessageSender messageSender = new EmailSender();
            //F-1:Implemetning Download op from input URL
            Console.WriteLine($"Downlaoding from URL:{Url}");
            /*//F:2 Send Email to Client.
            Console.WriteLine($"Email Message sent");*/
            messageSender.SendMessage("Success");
            //msgSender.SendMessage("Success");
        }
    }
}
