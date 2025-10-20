using Ejercicio1.Models;
using System.Net;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Empleado> empleados = new List<Empleado>();

        private void btnVerListado_Click(object sender, EventArgs e)
        {
            lsbEmpleados.Items.Clear();
            foreach (Empleado emp in empleados)
            {
                lsbEmpleados.Items.Add(emp);
            }
        }

        private void btnImportarEmpleados_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(csv)|*.csv";
            ofd.Title = "IMPORTACIÓN DE EMPLEADOS";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                StreamReader sr = null;
                string path = ofd.FileName;
                try
                {

                    fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    sr.ReadLine();
                    sr.ReadLine();

                    while (!sr.EndOfStream)
                    {

                        string linea = sr.ReadLine();
                        string[] splitResult = linea.Split(';');

                        string tipoEmpleado = splitResult[0];
                        int dni = Convert.ToInt32(splitResult[1]);
                        string nombre = splitResult[2];

                        Empleado empleado = null;

                        if (tipoEmpleado == "Asalariado")
                        {
                            double basico = Convert.ToDouble(splitResult[3]);
                            double aportes = Convert.ToDouble(splitResult[4]);

                            empleado = new Asalariado(dni, nombre, basico, aportes);
                        }
                        else
                        if (tipoEmpleado == "Jornalero")
                        {
                            int horasTrabajadas = Convert.ToInt32(splitResult[3]);
                            double importePorHora = Convert.ToDouble(splitResult[4]);
                            double retenciones = Convert.ToDouble(splitResult[5]);

                            empleado = new Jornalero(dni, nombre, horasTrabajadas, importePorHora, retenciones);
                        }

                        empleados.Sort();
                        int idx = empleados.BinarySearch(empleado);
                        if (idx > -1)
                        {
                            if (empleado is Asalariado)
                            {
                                ((Asalariado)empleados[idx]).Basico = ((Asalariado)empleado).Basico;
                            }
                            if (empleado is Jornalero)
                            {
                                ((Jornalero)empleados[idx]).ImportePorHora = ((Jornalero)empleado).ImportePorHora;
                            }

                        }
                        else
                        {
                            empleados.Add(empleado);
                        }
                    }
                    btnVerListado.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR al Importar Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (sr != null) sr.Close();
                    if (fs != null) fs.Close();
                }
            }
        }

        private void btnExportarEmpleados_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "EXPORTACION DE EMPLEADOS";
            sfd.Filter = "(csv)|*.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                StreamWriter sw = null;
                string path = sfd.FileName;
                try
                {
                    fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                    sw = new StreamWriter(fs);

                    sw.WriteLine("Tipo:Asalariado;DNI;Nombre;Básico,Aportes provisionales");
                    sw.WriteLine("Tipo:Jornalero; DNI; Nombre; Horas Trabajadas; Importe Por Hora; Retenciones");

                    foreach (IExportable emp in empleados)
                    {
                        sw.WriteLine(emp.Exportar());
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR al Exportar Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (sw != null) sw.Close();
                    if (fs != null) fs.Close();
                }
            }

        }

        private void btnGenerarRecibos_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "GENERAR RECIBOS";
            sfd.Filter = "(txt)|*.txt";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                StreamWriter sw = null;
                string path = sfd.FileName;
                try
                {
                    fs = new FileStream(path, FileMode.CreateNew, FileAccess.Write);
                    sw = new StreamWriter(fs);
                    foreach(Empleado emp in empleados)
                    {
                        foreach(string linea in emp.GenerarRecibo())
                        {
                            sw.WriteLine(linea);
                        }
                        sw.WriteLine("---");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR al Generar Recibo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (sw != null) sw.Close();
                    if (fs != null) fs.Close();
                }

            }
        }
    }
}
