using System;

namespace FacadeSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    public class Servico
    {

    }

    public class ServicoSingleton
    {
        private static Servico instancia = new Servico();

        public Servico Instancia {get{return instancia;}}

    }

    public class EmpresaFacadeSingleton 
    {
        private static EmpresaFacade instancia = new EmpresaFacade();

        public EmpresaFacade Instancia 
        {
            get 
            {
                return instancia;
            }
        }
    }

    public class EmpresaFacade 
    {
        public object Tipo { get; private set; }

        public Cliente BuscaCliente(String cpf) 
        {
            return new ClienteDao().BuscaPorCpf(cpf);
        }

        public Fatura CriaFatura(Cliente cliente, double valor) 
        {
            Fatura fatura = new Fatura(cliente, valor);
            return fatura;
        }

        public Cobranca GeraCobranca(Fatura fatura) 
        {
            Cobranca cobranca = new Cobranca(TipoDeCobranca.Boleto, fatura);
            cobranca.Emite();
            return cobranca;
        }

        public ContatoCliente FazContato(Cliente cliente, Cobranca cobranca) 
        {
            ContatoCliente contato = new ContatoCliente(cliente, cobranca);
            contato.Dispara();
            return contato;
        }
    }

    public class ContatoCliente
    {
        private Cliente cliente;
        private Cobranca cobranca;

        public ContatoCliente(Cliente cliente, Cobranca cobranca)
        {
            this.cliente = cliente;
            this.cobranca = cobranca;
        }

        internal void Dispara()
        {
            throw new NotImplementedException();
        }
    }

    public class Cobranca
    {
        private TipoDeCobranca tipo;
        private Fatura fatura;

        public Cobranca(TipoDeCobranca tipo, Fatura fatura)
        {
            this.tipo  = tipo;
            this.fatura = fatura;
        }

        internal void Emite()
        {
            throw new NotImplementedException();
        }
    }

    public class Fatura
    {
        private Cliente cliente;
        private double valor;

        public Fatura(Cliente cliente, double valor)
        {
            this.cliente = cliente;
            this.valor = valor;
        }
    }

    internal class ClienteDao
    {
        public ClienteDao()
        {
        }

        internal Cliente BuscaPorCpf(string cpf)
        {
            throw new NotImplementedException();
        }
    }

    public class Cliente
    {
        
    }

    public enum TipoDeCobranca
    {
        Boleto,
        Cartao
    }
}
