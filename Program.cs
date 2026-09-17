using Polimorfismo.exer1;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometria g = new Geometria();

            double AreaQuadrado = g.CalcularArea(5);
            double AreaRetangulo = g.CalcularArea(8, 20);
            double AreaCirculo = g.CalcularArea(5, true);

            Console.WriteLine("Area do Quadrado: " + AreaQuadrado);
            Console.WriteLine("Area do Retangulo: " + AreaRetangulo);
            Console.WriteLine("Area do Circulo: " + AreaCirculo);
        }
    }
}
