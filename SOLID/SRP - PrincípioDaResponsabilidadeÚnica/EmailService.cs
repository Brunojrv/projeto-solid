using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP___PrincípioDaResponsabilidadeÚnica
{
    public class EmailService
    {
        
        public void SendEmail(string subject, string recipient)
        {
            Console.WriteLine($"Enviando E-mail para: {recipient}");
            Console.WriteLine($"Informações do E-mail {subject}");

            // aqui estamos ferindo o princípio da responsabilidade única, pois o método enviar email não deveria ter dependência com o método gerar relatório,
            // nem tão pouco, o método de gerar relatório deveria está na classe EmailService, deveria está em outra classe correspondente a gerar relatório do cliente.
            GenerateReportClient();
        }

        public void GenerateReportClient()
        {
         // esse método será resposável por receber um cliente e gerar um relatório a partir de alguns dados dele.   
        }

    }
}
