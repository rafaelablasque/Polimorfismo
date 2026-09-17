using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo.exer1
{
    internal class Geometria
    {
        public double CalcularArea(double Lado)
        {
            return Lado * Lado;
        }
        public double CalcularArea(double Altura, double Base)
        {
            return Altura * Base;
        }
        public double CalcularArea(double Raio, bool IsCirculo)
        {
            return Math.PI * Raio * Raio;
        }
    }
}
