namespace CapaDePresentacion
{
	partial class VentanaPrincipal
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panelVentas = new System.Windows.Forms.Panel();
            this.lbY = new System.Windows.Forms.Label();
            this.lbX = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelCenter.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(89)))), ((int)(((byte)(7)))));
            resources.ApplyResources(this.panelBottom, "panelBottom");
            this.panelBottom.Name = "panelBottom";
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.panelVentas);
            this.panelCenter.Controls.Add(this.lbY);
            this.panelCenter.Controls.Add(this.lbX);
            this.panelCenter.Controls.Add(this.panel2);
            resources.ApplyResources(this.panelCenter, "panelCenter");
            this.panelCenter.Name = "panelCenter";
            // 
            // panelVentas
            // 
            resources.ApplyResources(this.panelVentas, "panelVentas");
            this.panelVentas.Name = "panelVentas";
            // 
            // lbY
            // 
            resources.ApplyResources(this.lbY, "lbY");
            this.lbY.Name = "lbY";
            // 
            // lbX
            // 
            resources.ApplyResources(this.lbX, "lbX");
            this.lbX.Name = "lbX";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnConfig);
            this.panel2.Controls.Add(this.btnClientes);
            this.panel2.Controls.Add(this.btnVentas);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // btnConfig
            // 
            resources.ApplyResources(this.btnConfig, "btnConfig");
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.MouseEnter += new System.EventHandler(this.btnVentas_MouseEnter);
            this.btnConfig.MouseLeave += new System.EventHandler(this.btnVentas_MouseLeave);
            // 
            // btnClientes
            // 
            resources.ApplyResources(this.btnClientes, "btnClientes");
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.MouseEnter += new System.EventHandler(this.btnVentas_MouseEnter);
            this.btnClientes.MouseLeave += new System.EventHandler(this.btnVentas_MouseLeave);
            // 
            // btnVentas
            // 
            resources.ApplyResources(this.btnVentas, "btnVentas");
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.MouseEnter += new System.EventHandler(this.btnVentas_MouseEnter);
            this.btnVentas.MouseLeave += new System.EventHandler(this.btnVentas_MouseLeave);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(156)))), ((int)(((byte)(12)))));
            resources.ApplyResources(this.panelTop, "panelTop");
            this.panelTop.Name = "panelTop";
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            // 
            // VentanaPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "VentanaPrincipal";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.VentanaPrincipal_Paint);
            this.panelCenter.ResumeLayout(false);
            this.panelCenter.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Panel panelVentas;
    }
}

