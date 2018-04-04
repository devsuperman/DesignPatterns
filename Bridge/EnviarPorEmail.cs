using System;

namespace Bridge
{
    class EnviarPorEmail : IEnviador
    {
        public void Enviar(IMensagem mensagem)
        {
            Console.WriteLine(mensagem.Formata());
            Console.WriteLine($"A mensagem foi enviada por E-Mail.");
        }
    }
}
