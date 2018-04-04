using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = "victor";
            cliente.Endereco = "Rua Vergueiro";
            cliente.DataDeNascimento = DateTime.Now;

            GeradorDeXml gerador = new GeradorDeXml();
            String xml = gerador.GeraXml(cliente);

            Console.WriteLine(xml);
        }
    }
}
