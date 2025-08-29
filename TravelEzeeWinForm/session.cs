using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelEzeeConsole
{
    internal class Sesssion
    {
        private static Sesssion _state = null;
        private Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
        private Sesssion()
        {

        }
        
        public void SetValue(string key, string value)
        {
            keyValuePairs[key] = value;
        }

        public string GetValue(string key)
        {
            if (keyValuePairs.ContainsKey(key))
            {
                return keyValuePairs[key];
            }
            return null;
        }
        public static Sesssion Current
        {
            get
            {
                if (_state == null)
                    _state = new Sesssion();
                return _state;
            }
        }
    }
}