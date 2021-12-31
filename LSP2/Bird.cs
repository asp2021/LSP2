using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP2
{
    public class Bird : Animal, ICanFly
    {
        public void Fly()
        {
            Console.WriteLine("Puedo volar");
        }
    }
}
