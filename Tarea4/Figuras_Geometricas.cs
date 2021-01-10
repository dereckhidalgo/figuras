using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace Tarea4
{
    class Figuras_Geometricas
    {
        public double area;
        public string nombre;
        public virtual double calcular_area()
        {
            
            return area;
        }
        public virtual void guardar()
        {

        }
    }
}
