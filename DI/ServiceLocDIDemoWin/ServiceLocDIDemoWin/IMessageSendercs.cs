using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadManagerDI1
{
    internal interface IMessageSender
    {
        void SendMessage(string message);
    }
}
