using System;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
             IExpressao esquerda = new Subtracao(new Numero(10), new Numero(5));
            IExpressao direita = new Soma(new Numero(2), new Numero(10));

            IExpressao conta = new Soma(esquerda, direita);

            int resultado = conta.Avalia();
            Console.WriteLine(resultado);
        }
    }
    
    public interface IExpressao 
    {
        int Avalia();
    }

    public class Subtracao : IExpressao 
    {

         private IExpressao esquerda;
        private IExpressao direita;

        public Subtracao(IExpressao esquerda, IExpressao direita) 
        {
            this.esquerda = esquerda;
            this.direita = direita;

        }

        public int Avalia() 
        {
            int resultadoDaEsquerda = esquerda.Avalia();
            int resultadoDaDireita = direita.Avalia();
            return resultadoDaEsquerda - resultadoDaDireita;
        }
    }

    public class Soma : IExpressao 
    {

        private IExpressao esquerda;
        private IExpressao direita;

        public Soma(IExpressao esquerda, IExpressao direita) 
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        public int Avalia() 
        {
            int resultadoDaEsquerda = esquerda.Avalia();
            int resultadoDaDireita = direita.Avalia();
            return resultadoDaEsquerda + resultadoDaDireita;
        }
    }
    public class Multiplicacao : IExpressao 
    {

        private IExpressao esquerda;
        private IExpressao direita;

        public Multiplicacao(IExpressao esquerda, IExpressao direita) 
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        public int Avalia() 
        {
            int resultadoDaEsquerda = esquerda.Avalia();
            int resultadoDaDireita = direita.Avalia();
            return resultadoDaEsquerda * resultadoDaDireita;
        }
    }

        public class Divisao : IExpressao 
        {

            private IExpressao esquerda;
            private IExpressao direita;

            public Divisao(IExpressao esquerda, IExpressao direita) 
            {
                this.esquerda = esquerda;
                this.direita = direita;
            }

            public int Avalia() 
            {
                int resultadoDaEsquerda = esquerda.Avalia();
                int resultadoDaDireita = direita.Avalia();
                return resultadoDaEsquerda / resultadoDaDireita;
            }
        }

    public class RaizQuadrada : IExpressao 
    {
        private IExpressao expressao;

        public RaizQuadrada(IExpressao e) 
        {
            this.expressao = e;
        }

        public int Avalia() 
        {
            return (int) Math.Sqrt(expressao.Avalia());
        }
}

    public class Numero : IExpressao 
    {

         private int numero;
        public Numero(int numero) 
        {
            this.numero = numero;
        }

        public int Avalia() 
        {
            return numero;
        }
    }
}
