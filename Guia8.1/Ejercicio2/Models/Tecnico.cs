using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class Tecnico:IExportable
    {
        public string CUIT {  get; private set; }
        public string Nombre { get; private set; }
        public string Cargo { get; set; }

        public Tecnico() { }
        public Tecnico(string cuit, string nombre, string cargo)
        {
            this.CUIT = cuit;
            this.Nombre = nombre;
            this.Cargo = cargo;
        }

        public void Leer(string[] linea)
        {
            this.CUIT = linea[1];
            this.Nombre = linea[2];
            this.Cargo = linea[3];
        }

        public string Escribir()
        {
            return $"TECNICO;{this.CUIT};{this.Nombre};{this.Cargo}";
        }
    }
}
