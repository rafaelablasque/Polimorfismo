using Polimorfismo.exer1;
using Polimorfismo.exer3;
using Polimorfismo.exer4;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Geometria g = new Geometria();

            //double AreaQuadrado = g.CalcularArea(5);
            //double AreaRetangulo = g.CalcularArea(8, 20);
            //double AreaCirculo = g.CalcularArea(5, true);

            //Console.WriteLine("Area do Quadrado: " + AreaQuadrado);
            //Console.WriteLine("Area do Retangulo: " + AreaRetangulo);
            //Console.WriteLine("Area do Circulo: " + AreaCirculo);

            //List<Animal> listAnimal = new List<Animal>();

            //listAnimal.Add(new Leao());
            //listAnimal.Add(new Macaco());
            //listAnimal.Add(new Cobra());

            //foreach (Animal animal in listAnimal)
            //{
            //    animal.EmitirSom();
            //}

            List<Inotificacao> listNot = new List<Inotificacao>();

            listNot.Add(new NotificacaoEmail());
            listNot.Add(new NotificacaoSMS());
            listNot.Add(new NotificacaoPush());
            listNot.Add(new Inotificacao());

            foreach (Inotificacao inotificacao in listNot)
            {
                inotificacao.Enviar();
            }
        }
    }
}
