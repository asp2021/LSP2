using System;

namespace LSP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1- Animal");
            Animal animal = new Animal();
            animal.Noise = "AWWWN";
            animal.MakeNoise();
            //  animal.Fly();  no puede volar si es "Animal" daria error en tiempo de compilacion.

            Console.WriteLine();
            Console.WriteLine("2- Bird");
            ICanFly animal1 = new Bird();
            animal1.Noise = "AWWWN";
            animal1.MakeNoise();
            animal1.Fly();

        }
    }
}
