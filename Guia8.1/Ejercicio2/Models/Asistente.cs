using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class Asistente:Persona
    {
        public double ValorSeguro { get; set; }

        public Asistente(int dni, string nombre,double seguro):base(dni,nombre) {
            this.ValorSeguro = seguro;
        }
    }
}
