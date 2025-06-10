using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadManagerDI1
{
    public class NameServiceLocator
    {
        private static NameServiceLocator _Instance;
        private Dictionary<string,object> Services 
            = new Dictionary<string,object>();
        private NameServiceLocator()
        {

        }
        public static NameServiceLocator Instance
        {
            get
            {
                if(_Instance==null)
                {
                    _Instance = new NameServiceLocator();
                }
                return _Instance;
            }
        }

        public void RegisterService(string srvName,object serviceObj)
        {
            Services.Add(srvName,serviceObj);
        }

        public object GetService(string srvName)
        {
            bool IsAvailable=Services.TryGetValue(srvName, out object SrvObject);
            if (IsAvailable)
            {
                return SrvObject;
            }
            else
            {
                return null;
            }
        }

    }
}
