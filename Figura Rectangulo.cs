using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_3D_Semana_3_Actividad_1
{
    class Figura_Rectangulo : Figura
    {
        private double ancho;
        private double altura;

        public Figura_Rectangulo(double ancho, double altura)
        {
            this.ancho = ancho;
            this.altura = altura;
        }

        public override double CalcularArea()
        {
            return ancho * altura;
        }
    }
}
