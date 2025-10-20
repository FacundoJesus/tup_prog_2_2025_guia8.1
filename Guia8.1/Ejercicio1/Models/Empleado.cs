using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public abstract class Empleado:IComparable
    {
        public int DNI { get; private set; }
        public string Nombre { get; private set; }

        public Empleado(int dni, string nombre) {
            this.DNI = dni;
            this.Nombre = nombre;   
        }

        public abstract double CalcularImporteAPagar();
        public abstract string[] GenerarRecibo();

        public override string ToString()
        {
            return $"{this.Nombre}({DNI})";
        }

        public int CompareTo(object obj)
        {
            Empleado nuevoEmpleado = obj as Empleado;
            if(nuevoEmpleado != null)
            {
                return this.DNI.CompareTo(nuevoEmpleado.DNI);
            }
            return -1;
        }
    }
}
