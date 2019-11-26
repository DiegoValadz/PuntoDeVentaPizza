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
            this.panelClientes = new System.Windows.Forms.Panel();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.btnAgregarClientes = new System.Windows.Forms.Button();
            this.lvClientes = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Correo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dirección = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbTitleClientes = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSupremo = new System.Windows.Forms.RadioButton();
            this.rbGrande = new System.Windows.Forms.RadioButton();
            this.rbMed = new System.Windows.Forms.RadioButton();
            this.rbChica = new System.Windows.Forms.RadioButton();
            this.lbY = new System.Windows.Forms.Label();
            this.lbX = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelCenter.SuspendLayout();
            this.panelVentas.SuspendLayout();
            this.panelClientes.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.panelVentas.Controls.Add(this.panelClientes);
            this.panelVentas.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.panelVentas, "panelVentas");
            this.panelVentas.Name = "panelVentas";
            // 
            // panelClientes
            // 
            this.panelClientes.Controls.Add(this.btnEliminarCliente);
            this.panelClientes.Controls.Add(this.btnEditarCliente);
            this.panelClientes.Controls.Add(this.btnAgregarClientes);
            this.panelClientes.Controls.Add(this.lvClientes);
            this.panelClientes.Controls.Add(this.lbTitleClientes);
            resources.ApplyResources(this.panelClientes, "panelClientes");
            this.panelClientes.Name = "panelClientes";
            this.panelClientes.Paint += new System.Windows.Forms.PaintEventHandler(this.panelClientes_Paint);
            // 
            // btnEliminarCliente
            // 
            resources.ApplyResources(this.btnEliminarCliente, "btnEliminarCliente");
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            // 
            // btnEditarCliente
            // 
            resources.ApplyResources(this.btnEditarCliente, "btnEditarCliente");
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // btnAgregarClientes
            // 
            resources.ApplyResources(this.btnAgregarClientes, "btnAgregarClientes");
            this.btnAgregarClientes.Name = "btnAgregarClientes";
            this.btnAgregarClientes.UseVisualStyleBackColor = true;
            this.btnAgregarClientes.Click += new System.EventHandler(this.btnAgregarClientes_Click);
            // 
            // lvClientes
            // 
            this.lvClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nombre,
            this.Correo,
            this.Telefono,
            this.Dirección});
            resources.ApplyResources(this.lvClientes, "lvClientes");
            this.lvClientes.Name = "lvClientes";
            this.lvClientes.UseCompatibleStateImageBehavior = false;
            this.lvClientes.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            resources.ApplyResources(this.ID, "ID");
            // 
            // Nombre
            // 
            resources.ApplyResources(this.Nombre, "Nombre");
            // 
            // Correo
            // 
            resources.ApplyResources(this.Correo, "Correo");
            // 
            // Telefono
            // 
            resources.ApplyResources(this.Telefono, "Telefono");
            // 
            // Dirección
            // 
            resources.ApplyResources(this.Dirección, "Dirección");
            // 
            // lbTitleClientes
            // 
            resources.ApplyResources(this.lbTitleClientes, "lbTitleClientes");
            this.lbTitleClientes.Name = "lbTitleClientes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSupremo);
            this.groupBox1.Controls.Add(this.rbGrande);
            this.groupBox1.Controls.Add(this.rbMed);
            this.groupBox1.Controls.Add(this.rbChica);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // rbSupremo
            // 
            resources.ApplyResources(this.rbSupremo, "rbSupremo");
            this.rbSupremo.Image = global::CapaDePresentacion.Properties.Resources.pizzagrande;
            this.rbSupremo.Name = "rbSupremo";
            this.rbSupremo.TabStop = true;
            this.rbSupremo.UseVisualStyleBackColor = true;
            // 
            // rbGrande
            // 
            resources.ApplyResources(this.rbGrande, "rbGrande");
            this.rbGrande.Image = global::CapaDePresentacion.Properties.Resources.pizzamed;
            this.rbGrande.Name = "rbGrande";
            this.rbGrande.TabStop = true;
            this.rbGrande.UseVisualStyleBackColor = true;
            // 
            // rbMed
            // 
            resources.ApplyResources(this.rbMed, "rbMed");
            this.rbMed.Image = global::CapaDePresentacion.Properties.Resources.pizzach;
            this.rbMed.Name = "rbMed";
            this.rbMed.TabStop = true;
            this.rbMed.UseVisualStyleBackColor = true;
            // 
            // rbChica
            // 
            resources.ApplyResources(this.rbChica, "rbChica");
            this.rbChica.Image = global::CapaDePresentacion.Properties.Resources.pizzaper;
            this.rbChica.Name = "rbChica";
            this.rbChica.TabStop = true;
            this.rbChica.UseVisualStyleBackColor = true;
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
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
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
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            this.btnClientes.MouseEnter += new System.EventHandler(this.btnVentas_MouseEnter);
            this.btnClientes.MouseLeave += new System.EventHandler(this.btnVentas_MouseLeave);
            // 
            // btnVentas
            // 
            resources.ApplyResources(this.btnVentas, "btnVentas");
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
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
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
            this.panelVentas.ResumeLayout(false);
            this.panelClientes.ResumeLayout(false);
            this.panelClientes.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSupremo;
        private System.Windows.Forms.RadioButton rbGrande;
        private System.Windows.Forms.RadioButton rbMed;
        private System.Windows.Forms.RadioButton rbChica;
        private System.Windows.Forms.Panel panelClientes;
        private System.Windows.Forms.Label lbTitleClientes;
        public System.Windows.Forms.ListView lvClientes;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Correo;
        private System.Windows.Forms.ColumnHeader Telefono;
        private System.Windows.Forms.ColumnHeader Dirección;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.Button btnAgregarClientes;
        private System.Windows.Forms.Button button1;
    }
}

