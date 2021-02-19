namespace Exercicio_2
{
    public class Retangulo
    {
        double altura{get; set;}
        double largura{get; set;}

        public Retangulo(double altura, double largura)
        {
            this.altura = altura;
            this.largura = largura;
        }

        public double CalcularArea()
        {
            return altura*largura;
        }
    }
}