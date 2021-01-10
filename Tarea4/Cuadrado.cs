using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace Tarea4
{
    class Cuadrado : Figuras_Geometricas, ILados
    {
        public Cuadrado()
        {
            nombre = "Cuadrado";
        }
        double lado;
        public int numeroDeLados()
        {
            return 4;
        }
        public override double calcular_area()
        {
            Console.Write("Digite lado: ");
            lado = double.Parse(Console.ReadLine());
            area = lado * lado;

            return area;

        }
        public override string ToString()
        {
            return $"Figura: {nombre}\nnNumero de lados:{numeroDeLados()}\nLado:{lado}\nArea:{area}";
        }
        public override void guardar()
        {
            //crear archivo
            StreamWriter ESCRITURA = new StreamWriter("Datos.txt", append: true);
            //insertando datos
            ESCRITURA.WriteLine($"Figura: {nombre}\nNumero de lados:{numeroDeLados()}\nLado:{lado}\nÁrea:{area}\n----------------------------------------------------------------------------------------------------------------------");
            //Cerrar archivo
            ESCRITURA.Close();

        }
    }
}
