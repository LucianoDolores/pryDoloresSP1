namespace pryDoloresSP1
{
    partial class frmProduccion
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
            this.lblTituloprod = new System.Windows.Forms.Label();
            this.lblLocalidad2 = new System.Windows.Forms.Label();
            this.lblCultivos2 = new System.Windows.Forms.Label();
            this.lblProduccion = new System.Windows.Forms.Label();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.cmbCultivo = new System.Windows.Forms.ComboBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtProduccion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTituloprod
            // 
            this.lblTituloprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloprod.Location = new System.Drawing.Point(59, 28);
            this.lblTituloprod.Name = "lblTituloprod";
            this.lblTituloprod.Size = new System.Drawing.Size(195, 23);
            this.lblTituloprod.TabIndex = 0;
            this.lblTituloprod.Text = "PRODUCCIÓN";
            // 
            // lblLocalidad2
            // 
            this.lblLocalidad2.AutoSize = true;
            this.lblLocalidad2.Location = new System.Drawing.Point(12, 76);
            this.lblLocalidad2.Name = "lblLocalidad2";
            this.lblLocalidad2.Size = new System.Drawing.Size(56, 13);
            this.lblLocalidad2.TabIndex = 1;
            this.lblLocalidad2.Text = "Localidad:";
            // 
            // lblCultivos2
            // 
            this.lblCultivos2.AutoSize = true;
            this.lblCultivos2.Location = new System.Drawing.Point(12, 120);
            this.lblCultivos2.Name = "lblCultivos2";
            this.lblCultivos2.Size = new System.Drawing.Size(42, 13);
            this.lblCultivos2.TabIndex = 2;
            this.lblCultivos2.Text = "Cultivo:";
            // 
            // lblProduccion
            // 
            this.lblProduccion.AutoSize = true;
            this.lblProduccion.Location = new System.Drawing.Point(12, 173);
            this.lblProduccion.Name = "lblProduccion";
            this.lblProduccion.Size = new System.Drawing.Size(64, 13);
            this.lblProduccion.TabIndex = 3;
            this.lblProduccion.Text = "Produccion:";
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(85, 73);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(155, 21);
            this.cmbLocalidad.TabIndex = 4;
            // 
            // cmbCultivo
            // 
            this.cmbCultivo.FormattingEnabled = true;
            this.cmbCultivo.Location = new System.Drawing.Point(85, 117);
            this.cmbCultivo.Name = "cmbCultivo";
            this.cmbCultivo.Size = new System.Drawing.Size(155, 21);
            this.cmbCultivo.TabIndex = 5;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(2, 211);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(128, 23);
            this.btnCargar.TabIndex = 7;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(136, 211);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(128, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtProduccion
            // 
            this.txtProduccion.Location = new System.Drawing.Point(85, 170);
            this.txtProduccion.Name = "txtProduccion";
            this.txtProduccion.Size = new System.Drawing.Size(155, 20);
            this.txtProduccion.TabIndex = 9;
            // 
            // frmProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 246);
            this.Controls.Add(this.txtProduccion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.cmbCultivo);
            this.Controls.Add(this.cmbLocalidad);
            this.Controls.Add(this.lblProduccion);
            this.Controls.Add(this.lblCultivos2);
            this.Controls.Add(this.lblLocalidad2);
            this.Controls.Add(this.lblTituloprod);
            this.Name = "frmProduccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producción";
            this.Load += new System.EventHandler(this.frmProduccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloprod;
        private System.Windows.Forms.Label lblLocalidad2;
        private System.Windows.Forms.Label lblCultivos2;
        private System.Windows.Forms.Label lblProduccion;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.ComboBox cmbCultivo;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtProduccion;
    }
}