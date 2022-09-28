namespace pryDoloresSP1
{
    partial class frmCultivos
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCargarcul = new System.Windows.Forms.Button();
            this.lblIDcult = new System.Windows.Forms.Label();
            this.txtCultivos = new System.Windows.Forms.TextBox();
            this.lblCultivos = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.mskIDcul = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(202, 148);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(171, 23);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCargarcul
            // 
            this.btnCargarcul.Location = new System.Drawing.Point(18, 148);
            this.btnCargarcul.Name = "btnCargarcul";
            this.btnCargarcul.Size = new System.Drawing.Size(171, 23);
            this.btnCargarcul.TabIndex = 12;
            this.btnCargarcul.Text = "Cargar";
            this.btnCargarcul.UseVisualStyleBackColor = true;
            this.btnCargarcul.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblIDcult
            // 
            this.lblIDcult.AutoSize = true;
            this.lblIDcult.Location = new System.Drawing.Point(15, 105);
            this.lblIDcult.Name = "lblIDcult";
            this.lblIDcult.Size = new System.Drawing.Size(68, 13);
            this.lblIDcult.TabIndex = 10;
            this.lblIDcult.Text = "Identificador:";
            // 
            // txtCultivos
            // 
            this.txtCultivos.Location = new System.Drawing.Point(94, 51);
            this.txtCultivos.Name = "txtCultivos";
            this.txtCultivos.Size = new System.Drawing.Size(126, 20);
            this.txtCultivos.TabIndex = 9;
            this.txtCultivos.TextChanged += new System.EventHandler(this.txtCultivos_TextChanged);
            // 
            // lblCultivos
            // 
            this.lblCultivos.AutoSize = true;
            this.lblCultivos.Location = new System.Drawing.Point(15, 54);
            this.lblCultivos.Name = "lblCultivos";
            this.lblCultivos.Size = new System.Drawing.Size(47, 13);
            this.lblCultivos.TabIndex = 8;
            this.lblCultivos.Text = "Cultivos:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(74, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(240, 23);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "INGRESAR CULTIVOS";
            // 
            // mskIDcul
            // 
            this.mskIDcul.Location = new System.Drawing.Point(94, 102);
            this.mskIDcul.Mask = "99999";
            this.mskIDcul.Name = "mskIDcul";
            this.mskIDcul.Size = new System.Drawing.Size(126, 20);
            this.mskIDcul.TabIndex = 14;
            this.mskIDcul.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskIDcul_MaskInputRejected);
            // 
            // frmCultivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 182);
            this.Controls.Add(this.mskIDcul);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCargarcul);
            this.Controls.Add(this.lblIDcult);
            this.Controls.Add(this.txtCultivos);
            this.Controls.Add(this.lblCultivos);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmCultivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cultivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCargarcul;
        private System.Windows.Forms.Label lblIDcult;
        private System.Windows.Forms.TextBox txtCultivos;
        private System.Windows.Forms.Label lblCultivos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.MaskedTextBox mskIDcul;
    }
}