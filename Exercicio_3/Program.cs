using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de x:");
            double x = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de x:");
            double y = Double.Parse(Console.ReadLine());

            Subtracao a = new Subtracao();
            Soma b = new Soma();
            Multiplicacao c = new Multiplicacao();
            Divisao d = new Divisao();

            Console.WriteLine($"O valor da soma é {b.efetuarOperacao(x,y)}");
            Console.WriteLine($"O valor da subtração é {a.efetuarOperacao(x,y)}");
            Console.WriteLine($"O valor da multiplicação é {c.efetuarOperacao(x,y)}");
            Console.WriteLine($"O valor da divisão é {d.efetuarOperacao(x,y)}");
        }
    }
}
