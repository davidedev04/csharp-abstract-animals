using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Passerotto : Animale
    {
        public override void Verso()
        {
            Console.Write("Il verso del passerotto é Bohh passerotto");
        }
        public override void Mangia()
        {
            Console.WriteLine(" - Il passerotto mangia l'erba");
        }
    }
}
