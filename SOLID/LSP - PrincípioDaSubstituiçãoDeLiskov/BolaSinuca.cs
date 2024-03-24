using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP___PrincípioDaSubstituiçãoDeLiskov
{
    public class BolaSinuca : Bola
    {
       // a classe bola de sinuca está utilizando bem o princípio de Liskov, pois a classe bola sinuca é substituível por bola,
       // ou seja, os dois seriam bola no final.

        // Quando ferimos o principio? caso minha classe herdada não conseguisse substituir minha classe base.
        public override void MoverBola()
        {
            Console.WriteLine("Movendo bola de sinuca...");
        }
    }
}
