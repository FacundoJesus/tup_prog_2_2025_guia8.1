using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Jornalero:Empleado,IComparable
    {
        public int HorasTrabajadas { get; private set; }
        public double ImportePorHora { get; set; }

        public double RetencionesImpositivas { get; private set; }

        public Jornalero(int dni, string nombre, int horas, double valorPorHora, double retencion):base(dni,nombre)
        {
            this.HorasTrabajadas = horas;
            this.ImportePorHora = valorPorHora;
            this.RetencionesImpositivas = retencion;
        }

        public override double CalcularImporteAPagar()
        {
            return (this.HorasTrabajadas * this.ImportePorHora) - this.RetencionesImpositivas;
        }

        public override string[] GenerarRecibo()
        {
            string[] recibo = new string[4];
            int i = 0;

            recibo[i++] = $" El Sr/a {base.Nombre}({base.DNI}) recibió la suma de ${CalcularImporteAPagar():f2} ";
            recibo[i++] = $" En concepto de horas de trabajo: ({this.HorasTrabajadas}) ";
            recibo[i++] = $" Siendo el valor de la hora {this.ImportePorHora} y  ";
            recibo[i++] = $" a la cual se le ha retenido por conceptos impositivos la suma de: {this.RetencionesImpositivas}";
            
            return recibo;
        }

        public string Exportar()
        {
            return $"Jornelero;{base.DNI};{base.Nombre};{this.HorasTrabajadas:f2},{this.RetencionesImpositivas:f2}";
        }
    }
}
