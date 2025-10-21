namespace Ejercicio2
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
            btnAltaEvento = new Button();
            tbNombreEvento = new TextBox();
            dtpFecha = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnExportar = new Button();
            btnImportar = new Button();
            lsbEventos = new ListBox();
            label3 = new Label();
            colorDialog1 = new ColorDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAltaEvento);
            groupBox1.Controls.Add(tbNombreEvento);
            groupBox1.Controls.Add(dtpFecha);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(500, 155);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Evento Nuevo";
            // 
            // btnAltaEvento
            // 
            btnAltaEvento.Location = new Point(352, 50);
            btnAltaEvento.Name = "btnAltaEvento";
            btnAltaEvento.Size = new Size(133, 47);
            btnAltaEvento.TabIndex = 4;
            btnAltaEvento.Text = "Alta Evento";
            btnAltaEvento.UseVisualStyleBackColor = true;
            btnAltaEvento.Click += btnAltaEvento_Click;
            // 
            // tbNombreEvento
            // 
            tbNombreEvento.Location = new Point(136, 82);
            tbNombreEvento.Multiline = true;
            tbNombreEvento.Name = "tbNombreEvento";
            tbNombreEvento.Size = new Size(193, 50);
            tbNombreEvento.TabIndex = 3;
            // 
            // dtpFecha
            // 
            dtpFecha.CustomFormat = "dd/MM/yyyy";
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(136, 35);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(132, 23);
            dtpFecha.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 82);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre Evento:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 35);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnExportar);
            groupBox2.Controls.Add(btnImportar);
            groupBox2.Controls.Add(lsbEventos);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(12, 182);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(500, 256);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Administración de Eventos";
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(352, 157);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(133, 47);
            btnExportar.TabIndex = 7;
            btnExportar.Text = "Exportar Asistentes/Expositores";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnImportar
            // 
            btnImportar.Location = new Point(352, 74);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(133, 47);
            btnImportar.TabIndex = 5;
            btnImportar.Text = "Importar Asistentes/Expositores";
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += btnImportar_Click;
            // 
            // lsbEventos
            // 
            lsbEventos.FormattingEnabled = true;
            lsbEventos.ItemHeight = 15;
            lsbEventos.Location = new Point(6, 47);
            lsbEventos.Name = "lsbEventos";
            lsbEventos.ScrollAlwaysVisible = true;
            lsbEventos.Size = new Size(323, 199);
            lsbEventos.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 29);
            label3.Name = "label3";
            label3.Size = new Size(323, 15);
            label3.TabIndex = 5;
            label3.Text = "Seleccione un evento del Listado y realice alguna operación:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAltaEvento;
        private TextBox tbNombreEvento;
        private DateTimePicker dtpFecha;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnImportar;
        private ListBox lsbEventos;
        private Label label3;
        private ColorDialog colorDialog1;
        private Button btnExportar;
    }
}
