using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPattern
{
    public class SingletonDesignPattern
    {
        private SingletonDesignPattern() { }

        private static SingletonDesignPattern obj;
        private static object objLock = new object();

        public static SingletonDesignPattern GetObject()
        {
            if (obj == null)
            {
                lock (objLock)
                {
                    if(obj == null)
                    {
                        obj = new SingletonDesignPattern();
                    }
                }
            }
            return obj;
        }
    }
}
