namespace Ejercicio1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lsbRecibo = new ListBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // lsbRecibo
            // 
            lsbRecibo.FormattingEnabled = true;
            lsbRecibo.ItemHeight = 15;
            lsbRecibo.Location = new Point(12, 12);
            lsbRecibo.Name = "lsbRecibo";
            lsbRecibo.Size = new Size(378, 424);
            lsbRecibo.TabIndex = 0;
            // 
            // btnAceptar
            // 
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.Location = new Point(160, 442);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 474);
            Controls.Add(btnAceptar);
            Controls.Add(lsbRecibo);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recibo del Empleado";
            ResumeLayout(false);
        }

        #endregion

        public ListBox lsbRecibo;
        private Button btnAceptar;
    }
}