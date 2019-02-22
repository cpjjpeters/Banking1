using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritingAConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("creating a BaseClass");
            BaseClass bc = new BaseClass();
            System.Console.WriteLine("Now creating a Subclass object (default)");
            SubClass sc = new SubClass();
            Console.WriteLine("\n Now creating SubClass object (int)");
            SubClass sc2 = new SubClass(0);

            //Console.WriteLine("\t Constructing BaseClass");
        }
    }
}
