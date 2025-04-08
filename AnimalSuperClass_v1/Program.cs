using System.Security.Cryptography.X509Certificates;

namespace AnimalSuperClass_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instantiating new objects
            Mammal mammal = new Mammal(2,4);
            Elephant e = new Elephant( 69);
            //prevents console from closing
            Console.ReadKey();
        }
    }
}
