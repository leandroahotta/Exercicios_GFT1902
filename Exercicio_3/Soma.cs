namespace Exercicio_3
{
    public class Soma
    {
        double x{get; set;}
        double y{get; set;}

        public double efetuarOperacao(double x, double y)
        {
            this.x = x;
            this.y = y;
            return x + y;
        }
    }
}