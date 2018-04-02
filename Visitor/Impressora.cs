using System;

namespace Visitor
{
    public interface IVisitor
    {
        void ImprimeSoma(Soma soma);
        void ImprimeSubtracao(Subtracao subtracao);
        void ImprimeNumero(Numero numero);
    }

    public class Impressora : IVisitor
    {

        public void ImprimeSoma(Soma soma) 
        {
            Console.Write("(");
            Console.Write(" + ");
            Console.Write(" ");
            soma.Esquerda.Aceita(this);
            Console.Write(" ");
            soma.Direita.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeSubtracao(Subtracao subtracao) 
        {
             Console.Write("(");
            Console.Write(" - ");
            Console.Write(" ");
            subtracao.Esquerda.Aceita(this);
            Console.Write(" ");
            subtracao.Direita.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeNumero(Numero numero) 
        {
            Console.WriteLine(numero.Valor);

        }
    }
}