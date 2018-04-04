using System;
using System.IO;
using System.Xml.Serialization;

namespace Adapter
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public DateTime DataDeNascimento { get; set; }
    }
}
