using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Asalariado:Empleado,IExportable
    {
        public double Basico { get; set; }
        public double AportesPrevisionales { get; private set; }

        public Asalariado(int dni, string nombre, double basico, double aportes) : base(dni, nombre)
        {
            this.Basico = basico;
            this.AportesPrevisionales = aportes;
        }

        public override double CalcularImporteAPagar()
        {
            return this.Basico - this.AportesPrevisionales;
        }

        public override string[] GenerarRecibo()
        {
            string[] recibo = new string[4];
            int i = 0;

            recibo[i++] = $"Nombre: {base.Nombre} - DNI: {base.DNI}";
            recibo[i++] = $"Básico: ${this.Basico:f2}";
            recibo[i++] = $"Aportes: $ - ${this.AportesPrevisionales:f2}";
            recibo[i++] = $"Importe a Percibir: ${CalcularImporteAPagar():f2}";

            return recibo;

        }

        public string Exportar()
        {
            return $"Asalariado;{base.DNI};{base.Nombre};{this.Basico:f2};{this.AportesPrevisionales:f2}";
        }

    }
}
