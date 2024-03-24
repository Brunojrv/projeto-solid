using SOLID.OCP___PrincípioDoAbertoFechado.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP___PrincípioDoAbertoFechado
{
    public class ElectronicSegment : IProductProcess
    {
        public void ProcessProduct()
        {
            Console.WriteLine("Processamento do segmento eletronico");
        }
    }
}
