using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class Expositor:Persona,IExportable
    {
        public string PapelProtagonico { get; set; }

        public Expositor():base() { }
        public Expositor(int dni, string nombre, string papel):base(dni,nombre)
        {
            this.PapelProtagonico = papel;
        }

        public string Escribir()
        {
            return $"EXPOSITOR;{base.dni};{base.nombre};{this.PapelProtagonico}";
        }

        public void Leer(string[] linea)
        {
            base.dni = Convert.ToInt32(linea[1]);
            base.nombre = linea[2];
            this.PapelProtagonico = linea[3];
        }
    }
}
