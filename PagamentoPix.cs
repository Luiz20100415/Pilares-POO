using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class PagamentoPix : IPagamento
    {
        public void Pagar(decimal valor)
        {
        //     throw new NotImplementedException(); // Metodo para nao gerar erro, caso o metodo seja utilizado
        // }
        Console.WriteLine($"Pagamento via Pix: {valor:C}");
        }
    }
}