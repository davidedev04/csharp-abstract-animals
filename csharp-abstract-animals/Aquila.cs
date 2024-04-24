using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Aquila : Animale
    {
        public override void Verso()
        {
            Console.Write("Il verso dell'Aquila é RHAAAAAA");
        }
        public override void Mangia()
        {
            Console.WriteLine(" - l'aquila mangia la carne");
        }
    }
}
