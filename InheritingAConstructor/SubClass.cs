using System;

namespace InheritingAConstructor
{
    public class SubClass: BaseClass {
        public SubClass()
        {

            Console.WriteLine("\t Constructing SubClass (default)");
        }
        public SubClass(int i)
        {
            Console.WriteLine("\t Constructing SubClass with an integer");
        }
    }
}
