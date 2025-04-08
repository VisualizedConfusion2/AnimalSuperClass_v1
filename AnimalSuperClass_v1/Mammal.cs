using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AnimalSuperClass_v1
{
    internal class Mammal : Animal
    {
        //Method
        public Mammal GiveBirth()
        {
            return new Mammal(2,4);
        }

        //constructor
        public Mammal(int eyeCount, int legCount):base(eyeCount,legCount)
        {
            Console.WriteLine($"MammalConstructorCalled");
        }
    }
}
