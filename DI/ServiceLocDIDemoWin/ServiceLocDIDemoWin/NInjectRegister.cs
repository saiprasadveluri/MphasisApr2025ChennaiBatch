using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DownloadManagerDI1;
using Ninject.Modules;
namespace ServiceLocDIDemoWin
{
    internal class NInjectRegister : NinjectModule
    {
        public override void Load()
        {
            Bind<IMessageSender>().To(typeof(EmailSender));
        }
    }
}
