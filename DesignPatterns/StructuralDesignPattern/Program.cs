using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AdapterDesignPattern.PerformPattern();

            FacadeDesignPattern fp = new FacadeDesignPattern();
            fp.PerformPattern();
        }
    }
}
