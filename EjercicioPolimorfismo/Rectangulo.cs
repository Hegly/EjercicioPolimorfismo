using System;
namespace EjercicioPolimorfismo
{
    internal class Rectangulo : Figura
    {
        public Rectangulo(double ladoA, double ladoB)
        {
            LadoA = ladoA;
            LadoB = ladoB;
        }

        public override double CalcularArea()
        {
            return LadoA * LadoB;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (LadoA + LadoB);
        }
    }
}

