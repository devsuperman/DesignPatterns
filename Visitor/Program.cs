using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            IExpressao esquerda = new Subtracao(new Numero(10), new Numero(5));
            IExpressao direita = new Soma(new Numero(2), new Numero(10));

            IExpressao conta = new Soma(esquerda, direita);

            var impressora = new Impressora();

            conta.Aceita(impressora);
            
            
        }
    }
    
   
}
