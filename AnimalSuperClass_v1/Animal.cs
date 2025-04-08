using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSuperClass_v1
{
    internal class Animal
    {
        //instans variable
        private int _eyeCount = 0;
        private int _legCount = 0;

        //properties
        public int LegCount { get => _legCount; set => _legCount = value; }
        public int EyeCount { get => _eyeCount; set => _eyeCount = value; }

        //constructer
        public Animal(int eyeCount, int legCount)
        {
            _eyeCount = eyeCount;
            _legCount = legCount;
            Console.WriteLine($"AnimalConstructorCalled");
        }

    }
}
