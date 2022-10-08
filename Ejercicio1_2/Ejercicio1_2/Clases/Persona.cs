using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1_2.Clases
{
    public class Persona
    {
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public int edad { get; set; }
        public string correo { get; set; }

        public Persona (string nombres, string apellidos, int edad, string correo)
        {
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.edad = edad;
            this.correo = correo;
        }
    }
}
