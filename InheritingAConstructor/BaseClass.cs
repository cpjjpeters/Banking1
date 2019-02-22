using System;

namespace InheritingAConstructor
{
    public class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("\t Constructing BaseClass (default)");
        }
        public BaseClass(int i)
        {
            Console.WriteLine("Constructing BaseClass with an integer");
        }
    }
}
