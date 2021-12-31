using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP2
{
    public interface IAnimal
    {
        public string Noise { get; set; }

        void MakeNoise();
    }
}
