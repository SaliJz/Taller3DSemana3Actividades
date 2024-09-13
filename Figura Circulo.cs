using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_3D_Semana_3_Actividad_1
{
    class Figuras_Circulo : Figura
    {
        private double radio;

        public Figuras_Circulo(double radio)
        {
            this.radio = radio;
        }

        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }
}
