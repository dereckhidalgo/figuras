using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace Tarea4
{
    class Hexagono:Figuras_Geometricas, ILados
    {
        double perimetro;
        double apotema;
        double lado;
        public Hexagono()
        {
            nombre = "Hexagono";
        }
        public int numeroDeLados()
        {
            return 6;
        }

        public override double calcular_area()
        {  
            Console.Write("Inserte lado: ");
            lado = double.Parse(Console.ReadLine());
            perimetro = (lado * 6);
            apotema = Math.Sqrt((Math.Pow(lado, 2) - Math.Pow((lado / 2), 2)));
            area = (perimetro * apotema) / 2;
            return area;
        }
        
        public override string ToString()
        {
            return $"Figura: {nombre}\nNumero de lados:{numeroDeLados()}\nLado:{lado}\nPerimetro:{perimetro}\nApotema:{apotema}\nArea: {area}";
        }
        public override void guardar()
        {
            //crear archivo
            StreamWriter ESCRITURA = new StreamWriter("Datos.txt", append: true);
            //insertando datos
            ESCRITURA.WriteLine($"Figura: {nombre} \nNumero de lados:{numeroDeLados()}\nLado:{lado}\nPerimetro:{perimetro}\nApotema:{apotema}\nÁrea:{area}\n----------------------------------------------------------------------------------------------------------------------");
            //Cerrar archivo
            ESCRITURA.Close();

        }
    }
}
