using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace Tarea4
{
    class Triangulo: Figuras_Geometricas,ILados
    {
        public Triangulo()
        {
            nombre = "Triangulo";
        }
        double B;
        double h;
        public int numeroDeLados()
        {
            return 3;
        }

        public override double calcular_area()
        {
            Console.Write("Digite base: ");
            B = double.Parse(Console.ReadLine());
            Console.Write("Digite altura: ");
            h = double.Parse(Console.ReadLine());
            area = (B * h) / 2;
            return area;

        }
        public override string ToString()
        {
            return $"Figura:{nombre} \nNumero de lados:{numeroDeLados()}\nBase:{B}\nAltura:{h}\nArea:{area}";
        }
        public override void guardar()
        {
            //crear archivo
            StreamWriter ESCRITURA = new StreamWriter("Datos.txt", append: true);
            //insertando datos
            ESCRITURA.WriteLine($"Figura:{nombre}\nNumero de lados:{numeroDeLados()} \nBase:{B}\nAltura:{h}\nArea:{area}\n----------------------------------------------------------------------------------------------------------------------");
            //Cerrar archivo
            ESCRITURA.Close();

        }
    }
}
