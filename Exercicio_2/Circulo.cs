using System;

namespace Exercicio_2
{
    public class Circulo
    {
        double raio{get; set;}

        public Circulo(double raio)
        {
            this.raio = raio;
        }

        public double CalcularArea()
        {
            return Math.PI*raio*raio;
        } 
    }
}