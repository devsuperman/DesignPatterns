using System;

namespace Visitor
{
     public interface IExpressao 
    {
        int Avalia();
        void Aceita(IVisitor impressora);
    }

    public class Subtracao : IExpressao 
    {
        public IExpressao Esquerda{get;set;}
        public IExpressao Direita{get;set;}

        public Subtracao(IExpressao esquerda, IExpressao direita) 
        {
            this.Esquerda = esquerda;
            this.Direita = direita;
        }

        public int Avalia() 
        {
            int resultadoDaEsquerda = Esquerda.Avalia();
            int resultadoDaDireita = Direita.Avalia();
            return resultadoDaEsquerda - resultadoDaDireita;
        }
        
        public void Aceita(IVisitor impressora) 
        {
            impressora.ImprimeSubtracao(this);
        }
    }

    public class Soma : IExpressao 
    {
        public IExpressao Esquerda {get;set;}
        public IExpressao Direita {get;set;}

        public Soma(IExpressao Esquerda, IExpressao direita) 
        {
            this.Esquerda = Esquerda;
            this.Direita = direita;
        }

        public int Avalia() 
        {
            int resultadoDaEsquerda = Esquerda.Avalia();
            int resultadoDaDireita = Direita.Avalia();
            return resultadoDaEsquerda + resultadoDaDireita;
        }

        public void Aceita(IVisitor impressora) 
        {
            impressora.ImprimeSoma(this);
        }
    }

    // public class Multiplicacao : IExpressao 
    // {

    //     private IExpressao Esquerda;
    //     private IExpressao direita;

    //     public Multiplicacao(IExpressao esquerda, IExpressao direita) 
    //     {
    //         this.Esquerda = esquerda;
    //         this.direita = direita;
    //     }

    //     public int Avalia() 
    //     {
    //         int resultadoDaEsquerda = Esquerda.Avalia();
    //         int resultadoDaDireita = direita.Avalia();
    //         return resultadoDaEsquerda * resultadoDaDireita;
    //     }
    // }

    // public class Divisao : IExpressao 
    // {

    //     private IExpressao Esquerda;
    //     private IExpressao direita;

    //     public Divisao(IExpressao esquerda, IExpressao direita) 
    //     {
    //         this.Esquerda = esquerda;
    //         this.direita = direita;
    //     }

    //     public int Avalia() 
    //     {
    //         int resultadoDaEsquerda = Esquerda.Avalia();
    //         int resultadoDaDireita = direita.Avalia();
    //         return resultadoDaEsquerda / resultadoDaDireita;
    //     }
    // }

    // public class RaizQuadrada : IExpressao 
    // {
    //     private IExpressao expressao;

    //     public RaizQuadrada(IExpressao e) 
    //     {
    //         this.expressao = e;
    //     }

    //     public int Avalia() 
    //     {
    //         return (int) Math.Sqrt(expressao.Avalia());
    //     }
    // }

    public class Numero : IExpressao 
    {
        public int Valor {get;set;}

        public Numero(int valor) 
        {
            this.Valor = valor;
        }

        public int Avalia() 
        {
            return Valor;
        }

        public void Aceita(IVisitor impressora) 
        {
            impressora.ImprimeNumero(this);
        }
    }

}