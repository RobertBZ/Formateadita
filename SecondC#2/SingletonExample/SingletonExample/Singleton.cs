using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    public class Singleton
    {
        private static Singleton _instance = null;

        public string message { get; set; }
        private Singleton() {
            this.message = "Singleton esta en uso 1";
        }

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }
    }
}
