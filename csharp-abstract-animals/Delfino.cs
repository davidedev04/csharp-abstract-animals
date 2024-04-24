using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Delfino : Animale
    {
        public override void Verso()
        {
            Console.Write("Il verso del delfino é IIIIIIIIIIIII");
        }
        public override void Mangia()
        {
            Console.WriteLine(" - Il delfino mangia non lo so");
        }
    }
}
