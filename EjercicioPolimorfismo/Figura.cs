using System;
namespace EjercicioPolimorfismo
{
    internal class Figura
    {
        public double LadoA { get; set; }
        public double LadoB { get; set; }
        public double LadoC { get; set; }

        public virtual double CalcularArea()
        {
            return 0;
        }

        public virtual double CalcularPerimetro()
        {
            return 0;
        }
    }
}

