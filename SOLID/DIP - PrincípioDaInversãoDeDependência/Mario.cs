using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP___PrincípioDaInversãoDeDependência
{
    public class Mario : ICharacter
    {
        //quem controla a criação de personagem é a interface.

        public void PerformAction()
        {
            Console.WriteLine("Mario está pulando!");
        }
    }
}
