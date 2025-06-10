using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ServiceLocDIDemoWin
{
    internal class MyCustomDIContainer
    {
        static MyCustomDIContainer obj;
        private Dictionary<Type,object> Services=new Dictionary<Type,object>();
        private MyCustomDIContainer()
        {

        }
        public static MyCustomDIContainer Instance
        {
            get
            {
                if (obj == null)
                {
                    obj = new MyCustomDIContainer();
                }
                return obj;
            }
        }
        public object CreateObject<T>()
        {
            return CreateInstnce(typeof(T));
        }

        private object CreateInstnce(Type objType)
        {
            var conInfo = objType.GetConstructors();
            //Take First Constructor
            if (conInfo.Length > 0)
            {
                var Cinf=conInfo[0];
                var ParamsInfos = Cinf.GetParameters();
                object[] conParams = null;
                if (ParamsInfos.Length > 0)
                {
                    conParams = new object[ParamsInfos.Length];
                    int index = 0;
                    foreach (var Param in ParamsInfos)
                    {
                        var paramObj = CreateInstnce(Param.ParameterType);
                        conParams[index]= paramObj;
                        ++index;
                    }
                }
                return Activator.CreateInstance(objType, conParams);
            }
            else
            {
                throw new InvalidOperationException("Invalid Object");
            }
        }
    }
}
