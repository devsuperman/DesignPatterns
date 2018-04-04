using System;

namespace Bridge
{
    class EnviarPorSms : IEnviador
    {
        public void Enviar(IMensagem mensagem)
        {
            Console.WriteLine(mensagem.Formata());
            Console.WriteLine($"A mensagem foi enviada por SMS.");
        }
    }
}
