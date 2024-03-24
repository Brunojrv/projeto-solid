using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP___PrincípioDaInversãoDeDependência
{
    public class Luigi : ICharacter
    {
        //quem controla a criação de personagem é a interface.
        public void PerformAction()
        {
            Console.WriteLine("Luigi está pulando!");
        }
    }
}
