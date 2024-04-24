using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Cane : Animale
    {
        public override void Verso()
        {
            Console.Write("Il verso del cane é Bau Bau");
        }
        public override void Mangia()
        {
            Console.WriteLine("Il cane mangia la carne");
        }
    }
}
