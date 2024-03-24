using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP___PrincípioDaSegregaçãoDeInterfaces
{
    public class PaymentService : IPayment
    {
        // a classe PaymentService herda a interface IPayment, a princípio nada de errado, mas ao implementar os método da interface
        //percebemos que temos o método AddEmail que não deveria fazer parte dessa interface, pois não faz parte do pagamento
        //O ideal seria que AddEmail estivesse em outra interface relacionada ao Email.
        public void AddEmail()
        {
            throw new NotImplementedException();
        }

        public void ProcessPayment()
        {
            throw new NotImplementedException();
        }

        public void RemovePayment()
        {
            throw new NotImplementedException();
        }

        public void ValidPayment()
        {
            throw new NotImplementedException();
        }
    }
}
