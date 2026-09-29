namespace CapaVista_Seguridad
{
    partial class FrmNavegador
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
            this.navegador1 = new CapaVista_Navegador.Navegador();
            this.SeguridadbtnReporte = new System.Windows.Forms.Button();
            this.SeguridadbtnAyuda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(2, 26);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1438, 111);
            this.navegador1.TabIndex = 0;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // SeguridadbtnReporte
            // 
            this.SeguridadbtnReporte.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_reporte;
            this.SeguridadbtnReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeguridadbtnReporte.Location = new System.Drawing.Point(1446, 42);
            this.SeguridadbtnReporte.Name = "SeguridadbtnReporte";
            this.SeguridadbtnReporte.Size = new System.Drawing.Size(90, 76);
            this.SeguridadbtnReporte.TabIndex = 1;
            this.SeguridadbtnReporte.UseVisualStyleBackColor = true;
            this.SeguridadbtnReporte.Click += new System.EventHandler(this.SeguridadbtnReporte_Click);
            // 
            // SeguridadbtnAyuda
            // 
            this.SeguridadbtnAyuda.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_ayuda2;
            this.SeguridadbtnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeguridadbtnAyuda.Location = new System.Drawing.Point(1450, 133);
            this.SeguridadbtnAyuda.Name = "SeguridadbtnAyuda";
            this.SeguridadbtnAyuda.Size = new System.Drawing.Size(86, 81);
            this.SeguridadbtnAyuda.TabIndex = 2;
            this.SeguridadbtnAyuda.UseVisualStyleBackColor = true;
            this.SeguridadbtnAyuda.Click += new System.EventHandler(this.SeguridadbtnAyuda_Click);
            // 
            // FrmNavegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 530);
            this.Controls.Add(this.SeguridadbtnAyuda);
            this.Controls.Add(this.SeguridadbtnReporte);
            this.Controls.Add(this.navegador1);
            this.Name = "FrmNavegador";
            this.Text = "2001 - FrmNavegador";
            this.ResumeLayout(false);

        }

        #endregion

        private CapaVista_Navegador.Navegador navegador1;
        private System.Windows.Forms.Button SeguridadbtnReporte;
        private System.Windows.Forms.Button SeguridadbtnAyuda;
    }
}