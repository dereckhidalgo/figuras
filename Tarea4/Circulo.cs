using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;


namespace Tarea4
{
    class Circulo : Figuras_Geometricas
    {
        public Circulo()
        {
            nombre = "Circulo";
        }
        double radio = 0 ;

        public override double calcular_area()
        {
            Console.Write("Inserte Radio: ");
            radio = Int32.Parse(Console.ReadLine());
            area = (radio * radio) * 3.1416;
            return area;

        }
        public override string ToString()
        {
            return $"Figura: {nombre} \nRadio:{radio}\nÁrea:{area}  \n ";
        }
        public override void guardar()
        {
            //crear archivo
            StreamWriter ESCRITURA = new StreamWriter("Datos.txt", append: true);
            //insertando datos
            ESCRITURA.WriteLine($"Figura: {nombre} \nRadio:{radio}\nÁrea:{area}\n----------------------------------------------------------------------------------------------------------------------");
                    //Cerrar archivo
            ESCRITURA.Close();


        }
    }
}
