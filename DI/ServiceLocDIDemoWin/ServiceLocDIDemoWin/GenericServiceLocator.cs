using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocDIDemoWin
{
    internal class GenericServiceLocator
    {
        private static GenericServiceLocator instance;
        private Dictionary<Type, object> Services = new Dictionary<Type, object>();

        public void RegisterService<T>(T obj)
        {
            Services[typeof(T)] = obj;
        }

        public object GetService<T>()
        {
            return Services[typeof(T)];
        }

        private GenericServiceLocator()
        {

        }

        public static GenericServiceLocator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GenericServiceLocator();
                }
                return instance;
            }
        }
    }
}
