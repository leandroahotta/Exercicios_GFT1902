using System;

namespace Exercicio_2
{
    class Teste
    {
        static void Main(string[] args)
        {
            Quadrado quadrado = new Quadrado(10);
            Circulo circulo = new Circulo(10);
            Retangulo retangulo = new Retangulo(10, 20);

            Console.WriteLine($"A área do quadrado é:{quadrado.CalcularArea()}");
            Console.WriteLine($"A área do retangulo é:{retangulo.CalcularArea()}");
            Console.WriteLine($"A área do circulo é:{circulo.CalcularArea()}");
        }
    }
}
