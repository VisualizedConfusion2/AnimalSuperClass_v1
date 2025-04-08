using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSuperClass_v1
{
    internal class Elephant:Mammal
    {
        //constructor
        public Elephant(int tuskLength):base(2,4)
        {
            Console.WriteLine($"ElephantConstructorCalled");

        }
    }
}
