using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace Tarea4
{
    class menu_principal
    {
        
        public static void menu()
        {
            Console.Clear();
            Console.WriteLine("1-Agregar figura");
            Console.WriteLine("2-Mostrar figuras guardadas");
            Console.WriteLine("3-Salir");
            Console.Write("Digite su opcion: ");
            int select = int.Parse(Console.ReadLine());
            switch (select)
            {
                case 1:
                    agregar();
                    menu();
                    break;
                case 2:
                    mostrar();
                    menu();
                    break;
                case 3:
                    Console.WriteLine("Gracias por usar nuestro programa, vuelva pronto...");
                    Console.Write("Presione una tecla para salir");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    menu();
                    break;
            }
        }


        //------------------------------------------------------------Funcion-Metodo MOSTRAR---------------------------------------------------------
        static void mostrar()
        {
            Console.Clear();

            Console.WriteLine("Estas son sus figuras guardadas");
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
            if (File.Exists("Datos.txt"))
            {
                StreamReader Lectura = new StreamReader("Datos.txt");
                string leer = Lectura.ReadLine();

                while (leer != null)
                {
                    Console.WriteLine(leer);
                    leer = Lectura.ReadLine();

                }
                Console.Write("Presione una tecla para continuar");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No existen figuras guardadas...");
                Console.Write("Presione una tecla para continuar");
                Console.ReadKey();
            }
        }
        //------------------------------------------------------------Funcion-Metodo AGREGAR---------------------------------------------------------
        static void agregar()
        {
            
            Figuras_Geometricas fig = null;
            Console.WriteLine("Calcular area");
            Console.WriteLine("1-Triangulo");
            Console.WriteLine("2-Cuadrado");
            Console.WriteLine("3-Circulo");
            Console.WriteLine("4-Hexagono");
            Console.Write("Seleccione figura para calcular su area: ");
            int seleccion = int.Parse(Console.ReadLine());
            switch (seleccion)
            {
                case 1:
                    fig = new Triangulo();
                    break;
                case 2:
                    fig = new Cuadrado();
                    break;
                case 3:
                    fig = new Circulo();
                    break;
                case 4:
                    fig = new Hexagono();
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }

            fig.calcular_area();
            Console.WriteLine(fig);
            Console.WriteLine("Figura agregada exitosamente");
            Console.WriteLine();
            Console.WriteLine("Desea guardar la figura?");
            Console.WriteLine("1-Si");
            Console.WriteLine("2-No");
            Console.WriteLine();
            Console.Write("Digite su opcion ");
            int select = int.Parse(Console.ReadLine());
            switch (select)
            {
                case 1:
                    fig.guardar();
                    Console.WriteLine("Figura guardada con Éxito");
                    break;
                default:
                    Console.WriteLine("No guardo la figura");
                    break;
            }
            Console.WriteLine();
            Console.Write("Presione una tecla para continuar ");
            Console.ReadKey();
        }
    }
}
