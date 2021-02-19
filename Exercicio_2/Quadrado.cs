namespace Exercicio_2
{
    public class Quadrado
    {
        double lado{get; set;}

        public Quadrado(double lado)
        {
            this.lado = lado;
        }

        public double CalcularArea()
        {
            return lado*lado;
        }
    }
}