using System;
using System.Collections.Generic;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido1 = new Pedido("Mauricio", 150.0);
            Pedido pedido2 = new Pedido("Marcelo", 250.0);

            FilaDeTrabalho fila = new FilaDeTrabalho();

            fila.Adiciona(new PagaPedido(pedido1));
            fila.Adiciona(new PagaPedido(pedido2));
            fila.Adiciona(new FinalizaPedido(pedido1));

            fila.Processa();
        }
    }

    public interface IComando 
    {
        void Executa();
    }

    public class FinalizaPedido : IComando 
    {
        private Pedido pedido;

        public FinalizaPedido(Pedido pedido) 
        {
            this.pedido = pedido;
        }

        public void Executa() 
        {
            Console.WriteLine($"Pedido do cliente {pedido.Cliente} Finalizado");
            pedido.Finaliza();
        }
    }

    public class PagaPedido : IComando 
    {
        private Pedido pedido;

        public PagaPedido(Pedido pedido)
        {
            this.pedido = pedido;
        }

        public void Executa() 
        {
            Console.WriteLine($"Pedido do cliente {pedido.Cliente} Pago");
            pedido.Paga();
        }
    }

    public class FilaDeTrabalho 
    {
        private IList<IComando> comandos = new List<IComando>();

        public void Adiciona(IComando comando) 
        {
            comandos.Add(comando);
        }

        public void Processa() 
        {
            foreach(IComando comando in comandos) 
            {
                comando.Executa();
            }
        }

    }


    public class Pedido 
    {
        public String Cliente { get; private set; }
        public double Valor  { get; private set; }
        public Status Status  { get; private set; }
        public DateTime DataFinalizacao { get; private set; }

        public Pedido(String cliente, double valor) 
        {
            this.Cliente = cliente;
            this.Valor = valor;
            this.Status = Status.Novo;
        }

        public void Paga() 
        {
            Status = Status.Pago;
        }

        public void Finaliza() 
        {
            DataFinalizacao = DateTime.Now;
            Status = Status.Entregue;
        }
    }

    public enum Status 
    {
        Novo,
        Processado,
        Pago,
        ItemSeparado,
        Entregue
    }
}
