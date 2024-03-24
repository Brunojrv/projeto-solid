using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP___PrincípioDaSubstituiçãoDeLiskov
{
    public class BolaFutebol : Bola
    {
        public override void MoverBola()
        {
            Console.WriteLine("Chutando a bola de futebol...");
        }
    }
}
