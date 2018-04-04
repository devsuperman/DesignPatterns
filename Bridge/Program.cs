using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnviador enviador = new EnviarPorEmail();
            IMensagem mensagem = new MensagemAdministrativa("mauricio", enviador);            

            mensagem.Enviar();
        }
    }
}
