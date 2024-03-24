using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP___PrincípioDaSegregaçãoDeInterfaces
{
    public interface IPayment
    {
        void ProcessPayment();
        void ValidPayment();
        void RemovePayment();
        void AddEmail();

    }
}
