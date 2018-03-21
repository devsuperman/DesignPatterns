using System;

namespace factory
{
    class Program
    {
        static void Main(string[] args)
        {   
            var conexao = new SqlConnectionFactory().Criar();
            Console.WriteLine("Hello World!");
        }
    }

    public class SqlConnection
    {
        public string ConnectionString { get; set; }             

        public void AbrirConexao()
        {

        }
    }

    public class SqlConnectionFactory
    {
        public SqlConnection Criar()
        {
            var conexao = new SqlConnection();
            conexao.ConnectionString = "User Id=root;Password=;Server=localhost;Database=banco";
            conexao.AbrirConexao();
            return conexao;
        }
    }
}
