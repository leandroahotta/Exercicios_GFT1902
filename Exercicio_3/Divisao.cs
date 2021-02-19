using System;

namespace Exercicio_3
{
    public class Divisao
    {
        double x{get; set;}
        double y{get; set;}

        public double efetuarOperacao(double x, double y)
        {
            this.x = x;
            this.y = y;
            if(y == 0)
            {
                Console.WriteLine("Não foi possível realizar a operação.");
                return 0;
            }
            else
            {
                return x / y;
            }
        }
    }
}