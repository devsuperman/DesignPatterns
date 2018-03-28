using System;
using System.Collections.Generic;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            NotasMusicais notas = new NotasMusicais();

            IList<Nota> musica = new List<Nota>() {
                notas.Pega("do"),    
                notas.Pega("re"),    
                notas.Pega("mi"),    
                notas.Pega("fa"),    
                notas.Pega("fa"),    
                notas.Pega("fa"),    

                notas.Pega("do"),    
                notas.Pega("re"),    
                notas.Pega("do"),    
                notas.Pega("re"),    
                notas.Pega("re"),    
                notas.Pega("re"),

                notas.Pega("do"),    
                notas.Pega("sol"),    
                notas.Pega("fa"),    
                notas.Pega("mi"),    
                notas.Pega("mi"),    
                notas.Pega("mi"),

                notas.Pega("do"),    
                notas.Pega("re"),    
                notas.Pega("mi"),    
                notas.Pega("fa"),    
                notas.Pega("fa"),    
                notas.Pega("fa")
            };    


            var piano = new Piano();

            piano.Toca(musica);

            Console.WriteLine("Hello World!");
        }
    }

    class NotasMusicais
    {
        public static IDictionary<string, Nota> notas = new Dictionary<string, Nota>()
        {
            {"do", new Do()},
            {"re", new Re()},
            {"mi", new Mi()},
            {"fa", new Fa()},
            {"sol", new Sol()},
            {"la", new La()},
            {"si", new Si()}
        };

        public Nota Pega(string nome)
        {
            return notas[nome];
        }
    }

    class Musica
    {

    }

    class Piano
    {
        public void Toca(IList<Nota> musica)
        {
            foreach (var nota in musica)
            {
                Console.Beep(nota.Frequencia, 300);                
            }
        }
    }

    abstract class Nota
    {
        public int Frequencia { get; protected set; }
    }

    class Do : Nota
    {
        public Do() => Frequencia = 264;
    }

    class Re : Nota
    {
        public Re() => Frequencia = 297;
    }

    class Mi : Nota
    {
        public Mi() => Frequencia = 330;
    }

    class Fa : Nota
    {
        public Fa() => Frequencia = 352;
    }

    class Sol : Nota
    {
        public Sol() => Frequencia = 396;
    }

    class La : Nota
    {
        public La() => Frequencia = 440;
    }

    class Si : Nota
    {
        public Si() => Frequencia = 495;
    }
}
