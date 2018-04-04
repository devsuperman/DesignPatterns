using System;

namespace Bridge
{
    class MensagemCliente : IMensagem
    {
        public MensagemCliente(string cliente, IEnviador enviador)
        {
            Cliente = cliente;
            Enviador = enviador;
        }

        public string Cliente { get; set; }
        public IEnviador Enviador { get; set; }
        
        public void Enviar()
        {
            Enviador.Enviar(this);
        }

        public string Formata()
        {
            return $"Mensagem Cliente enviada para o cliente {this.Cliente}";
        }
    }
}
