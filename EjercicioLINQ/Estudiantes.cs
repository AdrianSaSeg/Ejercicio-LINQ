using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLINQ
{

    public class Estudiantes
    {
        public int Edad { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Estudiantes(int edad, string nombre, string apellido)
        {
            Edad = edad;
            Nombre = nombre;
            Apellido = apellido;
        }
       
    }
}
