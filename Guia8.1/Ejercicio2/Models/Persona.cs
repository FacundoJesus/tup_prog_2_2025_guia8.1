using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class Persona:IComparable
    {
        protected int dni;
        protected string nombre;
        public int DNI { get { return dni; } }
        public string Nombre { get { return nombre; } }

        public Persona() { }
        public Persona(int dni, string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public int CompareTo(object obj) {
            Persona nuevaPersona = obj as Persona;
            if(nuevaPersona != null) {
                return this.dni.CompareTo(nuevaPersona.dni);
            }
            return -1;
        }

        public override string ToString()
        {
            return $"{this.nombre} ({this.dni})";
        }
    }
}
