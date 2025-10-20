namespace Ejercicio1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            lsbEmpleados = new ListBox();
            btnVerListado = new Button();
            btnImportarEmpleados = new Button();
            btnExportarEmpleados = new Button();
            btnGenerarRecibos = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lsbEmpleados);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(263, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Listado de empleados";
            // 
            // lsbEmpleados
            // 
            lsbEmpleados.FormattingEnabled = true;
            lsbEmpleados.ItemHeight = 15;
            lsbEmpleados.Location = new Point(6, 22);
            lsbEmpleados.Name = "lsbEmpleados";
            lsbEmpleados.Size = new Size(251, 394);
            lsbEmpleados.TabIndex = 0;
            lsbEmpleados.SelectedIndexChanged += lsbEmpleados_SelectedIndexChanged;
            // 
            // btnVerListado
            // 
            btnVerListado.Location = new Point(281, 33);
            btnVerListado.Name = "btnVerListado";
            btnVerListado.Size = new Size(75, 51);
            btnVerListado.TabIndex = 1;
            btnVerListado.Text = "Ver Listado";
            btnVerListado.UseVisualStyleBackColor = true;
            btnVerListado.Click += btnVerListado_Click;
            // 
            // btnImportarEmpleados
            // 
            btnImportarEmpleados.Location = new Point(281, 131);
            btnImportarEmpleados.Name = "btnImportarEmpleados";
            btnImportarEmpleados.Size = new Size(75, 60);
            btnImportarEmpleados.TabIndex = 2;
            btnImportarEmpleados.Text = "Importar Empleados";
            btnImportarEmpleados.UseVisualStyleBackColor = true;
            btnImportarEmpleados.Click += btnImportarEmpleados_Click;
            // 
            // btnExportarEmpleados
            // 
            btnExportarEmpleados.Location = new Point(281, 252);
            btnExportarEmpleados.Name = "btnExportarEmpleados";
            btnExportarEmpleados.Size = new Size(75, 55);
            btnExportarEmpleados.TabIndex = 3;
            btnExportarEmpleados.Text = "Exportar Empleados";
            btnExportarEmpleados.UseVisualStyleBackColor = true;
            btnExportarEmpleados.Click += btnExportarEmpleados_Click;
            // 
            // btnGenerarRecibos
            // 
            btnGenerarRecibos.Location = new Point(281, 367);
            btnGenerarRecibos.Name = "btnGenerarRecibos";
            btnGenerarRecibos.Size = new Size(75, 60);
            btnGenerarRecibos.TabIndex = 4;
            btnGenerarRecibos.Text = "Generar Recibos";
            btnGenerarRecibos.UseVisualStyleBackColor = true;
            btnGenerarRecibos.Click += btnGenerarRecibos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 450);
            Controls.Add(btnGenerarRecibos);
            Controls.Add(btnExportarEmpleados);
            Controls.Add(btnImportarEmpleados);
            Controls.Add(btnVerListado);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox lsbEmpleados;
        private Button btnVerListado;
        private Button btnImportarEmpleados;
        private Button btnExportarEmpleados;
        private Button btnGenerarRecibos;
    }
}
