using Ejercicio2.Models;
using System.Security.Cryptography;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnAltaEvento_Click(object sender, EventArgs e)
        {
            DateTime fecha = dtpFecha.Value;
            string nombreEvento = tbNombreEvento.Text;

            Evento nuevoEvento = new Evento(fecha, nombreEvento);

           
            lsbEventos.Items.Add(nuevoEvento);

            #region Limpio campos
            tbNombreEvento.Clear();
            dtpFecha.Value = DateTime.Now;
            #endregion
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            //Seleccionar Evento
            Evento eventoSeleccionado = lsbEventos.SelectedItem as Evento;
            if (eventoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un evento para proseguir. Sino hay un evento, darlo de alta", "Advertencia");
                return;
            }

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = $"IMPORTACION DE ASISTENTES Y EXPOSITORES PARA EL EVENTO {eventoSeleccionado.NombreEvento}";
            ofd.Filter = "(csv)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                StreamReader sr = null;

                try
                {
                    fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);

                    sr.ReadLine();
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        string linea = sr.ReadLine();
                        string[] splitResult = linea.Split(';');
                        IExportable exportable = null;
                        if (splitResult[0] == "EXPOSITOR")
                        {
                            exportable = new Expositor();
                        }
                        else
                        if (splitResult[0] == "TECNICO")
                        {
                            exportable = new Tecnico();
                        }

                        if (exportable != null)
                        {
                            exportable.Leer(splitResult);
                        }

                        eventoSeleccionado.RegistrarExportable(exportable);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR al Importar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (sr != null) sr.Close();
                    if (fs != null) fs.Close();
                }
            }

        }

        List<IExportable> exportables = new List<IExportable>();
        private void btnExportar_Click(object sender, EventArgs e)
        {
            //Seleccionar Evento
            Evento eventoSeleccionado = lsbEventos.SelectedItem as Evento;
            if (eventoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un evento para proseguir. Sino hay un evento, darlo de alta", "Advertencia");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = $"EXPORTACION DE ASISTENTES Y EXPOSITORES PARA EL EVENTO {eventoSeleccionado.NombreEvento}";
            sfd.Filter = "(csv)|*.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                StreamWriter sw = null;

                try
                {
                    fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    sw = new StreamWriter(fs);

                    sw.WriteLine("Tipo:TECNICO;CUIT;Nombre;Cargo");
                    sw.WriteLine("Tipo:EXPOSITOR;DNI;Nombre;Papel Protagónico");

                    foreach(IExportable exportable in eventoSeleccionado.VerExportables())
                    {
                        sw.WriteLine(exportable.Escribir());
                    }
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR al Importar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
