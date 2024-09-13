using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_3D_Semana_3_Actividad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Seleccione la figura para calcular el área:");
                Console.WriteLine("1. Rectángulo");
                Console.WriteLine("2. Círculo");
                Console.WriteLine("3. Triángulo");
                Console.WriteLine("4. Salir");

                string opcion = Console.ReadLine();

                if (opcion == "4")
                {
                    break;
                }

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese la base del rectángulo:");
                        double anchoRectangulo = double.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese la altura del rectángulo:");
                        double alturaRectangulo = double.Parse(Console.ReadLine());

                        Figura_Rectangulo rectangulo = new Figura_Rectangulo(anchoRectangulo, alturaRectangulo);
                        Console.WriteLine($"El área del rectángulo es: {rectangulo.CalcularArea()}");
                        break;

                    case "2":
                        Console.WriteLine("Ingrese el radio del círculo:");
                        double radioCirculo = double.Parse(Console.ReadLine());

                        Figuras_Circulo circulo = new Figuras_Circulo(radioCirculo);
                        Console.WriteLine($"El área del círculo es: {circulo.CalcularArea()}");
                        break;

                    case "3":
                        Console.WriteLine("Ingrese la base del triángulo:");
                        double baseTriangulo = double.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese la altura del triángulo:");
                        double alturaTriangulo = double.Parse(Console.ReadLine());

                        Figura_Triangulo triangulo = new Figura_Triangulo(baseTriangulo, alturaTriangulo);
                        Console.WriteLine($"El área del triángulo es: {triangulo.CalcularArea()}");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción correcta.");
                        break;
                }

                Console.WriteLine("¿Desea calcular el área de otra figura? (s/n)");
                string respuesta = Console.ReadLine().ToLower();

                if (respuesta != "s")
                {
                    break;
                }
            }
        }
    }
}
