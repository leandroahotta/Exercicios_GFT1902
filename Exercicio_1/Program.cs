using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Multiplicando:");
            int multiplicando = Int32.Parse(Console.ReadLine());

            if(multiplicando < 0 || multiplicando > 3000)
            {
                throw new ArgumentException("Valor do multiplicando deve ser maior que zero e menor que 3001");
            } 
            
            Console.WriteLine("Início do intervalo:");
            int inicio = Int32.Parse(Console.ReadLine());
            if(inicio < 0 || inicio > 3000)
            {
                throw new ArgumentException("Valor do início do intervalo deve ser maior que zero e menor que 3001");
            }

            Console.WriteLine("Fim do intervalo:");
            int fim = Int32.Parse(Console.ReadLine());
            if(fim < 0 || fim > 3000)
            {
                throw new ArgumentException("Valor do fim do intervalo deve ser maior que zero e menor que 3001");
            } else if(fim - inicio > 9)
            {
                throw new ArgumentException("O intervalo deve ter no máximo 10 números.");
            } else if(fim < inicio)
            {
                throw new ArgumentException("O valor do fim do intervalo deve ser maior que do início.");
            }

            for(int i = inicio; i <= fim; i++)
            {
                var j = multiplicando * i;
                Console.WriteLine($"{multiplicando}x{i} = {j}");
            }

        }
    }
}
