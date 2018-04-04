using System;

namespace Bridge
{
    class MensagemAdministrativa: IMensagem
    {
        public MensagemAdministrativa(string cliente, IEnviador enviador)
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
            return $"Mensagem Administrativa enviada para o cliente {this.Cliente}";
        }
    }
}
