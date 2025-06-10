using DownloadManagerDI1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject;
using System.Reflection;
namespace ServiceLocDIDemoWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*NameServiceLocator loc = NameServiceLocator.Instance;
            IMessageSender msgSender= loc.GetService("SMS") as IMessageSender;
            DownloadManager downloadManager=new DownloadManager(msgSender);*/

            GenericServiceLocator locator = GenericServiceLocator.Instance;
            var MsgSender=locator.GetService<IMessageSender>() as IMessageSender;
            DownloadManager downloadManager = new DownloadManager(MsgSender);
            downloadManager.DoAction_V3("path");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var kernal = new StandardKernel();
            kernal.Load(Assembly.GetExecutingAssembly());
            IMessageSender obj= kernal.Get<IMessageSender>();
            DownloadManager downloadManager = new DownloadManager(obj);
        }

        private void button3_Click(object sender, EventArgs e)
        {
          var obj=  MyCustomDIContainer.Instance.CreateObject<EmailSender>();
        }
    }
}
