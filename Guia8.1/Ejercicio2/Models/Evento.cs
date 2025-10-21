using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class Evento
    {
        public DateTime Fecha { get; private set; }
        public string NombreEvento { get; private set; }

        public Evento(DateTime fecha, string nombreEv) {
            this.Fecha = fecha;
            this.NombreEvento = nombreEv;
        }

        List<Tecnico> tecnicos = new List<Tecnico>();
        List<Persona> personas = new List<Persona>();

        public void RegistrarExportable(IExportable exportable) {
            if(exportable is Tecnico)
            {
                tecnicos.Add(exportable as Tecnico);
            }
            else
            if(exportable is Persona) {
                personas.Add(exportable as Persona);
            }
        }

        public List<IExportable> VerExportables()
        {
            List<IExportable> exportables = new List<IExportable>();
            foreach(Tecnico t in tecnicos)
            {
                exportables.Add(t);
            }
            foreach(Persona p in personas)
            {
                if(p is IExportable)
                {
                    exportables.Add(p as IExportable);
                }
            }
            return exportables;
        }

        public override string ToString()
        {
            return $"Nombre: {this.NombreEvento} - Fecha: {this.Fecha:dd/MM/yyyy}";
        }
    }
}
