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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelVentas = new System.Windows.Forms.Panel();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.cbRepartidor = new System.Windows.Forms.ComboBox();
            this.lbRepartidor = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.lbCliente = new System.Windows.Forms.Label();
            this.btnChooseIng = new System.Windows.Forms.Button();
            this.listBSelect = new System.Windows.Forms.ListBox();
            this.listBDisponibles = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.lbProd = new System.Windows.Forms.Label();
            this.tbTicket = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSupremo = new System.Windows.Forms.RadioButton();
            this.rbGrande = new System.Windows.Forms.RadioButton();
            this.rbMed = new System.Windows.Forms.RadioButton();
            this.rbChica = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.button2 = new System.Windows.Forms.Button();
            this.lbVentas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.lbY = new System.Windows.Forms.Label();
            this.lbX = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelCenter.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelVentas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelClientes.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panelCenter.Controls.Add(this.panelClientes);
            this.panelCenter.Controls.Add(this.tabControl1);
            this.panelCenter.Controls.Add(this.lbY);
            this.panelCenter.Controls.Add(this.lbX);
            this.panelCenter.Controls.Add(this.panel2);
            resources.ApplyResources(this.panelCenter, "panelCenter");
            this.panelCenter.Name = "panelCenter";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelVentas);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelVentas
            // 
            this.panelVentas.Controls.Add(this.btnRemover);
            this.panelVentas.Controls.Add(this.btnGenerar);
            this.panelVentas.Controls.Add(this.cbRepartidor);
            this.panelVentas.Controls.Add(this.lbRepartidor);
            this.panelVentas.Controls.Add(this.cbCliente);
            this.panelVentas.Controls.Add(this.lbCliente);
            this.panelVentas.Controls.Add(this.btnChooseIng);
            this.panelVentas.Controls.Add(this.listBSelect);
            this.panelVentas.Controls.Add(this.listBDisponibles);
            this.panelVentas.Controls.Add(this.label1);
            this.panelVentas.Controls.Add(this.cbProducto);
            this.panelVentas.Controls.Add(this.lbProd);
            this.panelVentas.Controls.Add(this.tbTicket);
            this.panelVentas.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.panelVentas, "panelVentas");
            this.panelVentas.Name = "panelVentas";
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.Moccasin;
            resources.ApplyResources(this.btnRemover, "btnRemover");
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnGenerar
            // 
            resources.ApplyResources(this.btnGenerar, "btnGenerar");
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // cbRepartidor
            // 
            this.cbRepartidor.FormattingEnabled = true;
            resources.ApplyResources(this.cbRepartidor, "cbRepartidor");
            this.cbRepartidor.Name = "cbRepartidor";
            this.cbRepartidor.SelectedIndexChanged += new System.EventHandler(this.cbRepartidor_SelectedIndexChanged);
            // 
            // lbRepartidor
            // 
            resources.ApplyResources(this.lbRepartidor, "lbRepartidor");
            this.lbRepartidor.Name = "lbRepartidor";
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            resources.ApplyResources(this.cbCliente, "cbCliente");
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.SelectedIndexChanged += new System.EventHandler(this.cbCliente_SelectedIndexChanged);
            // 
            // lbCliente
            // 
            resources.ApplyResources(this.lbCliente, "lbCliente");
            this.lbCliente.Name = "lbCliente";
            // 
            // btnChooseIng
            // 
            this.btnChooseIng.BackColor = System.Drawing.Color.LightGreen;
            resources.ApplyResources(this.btnChooseIng, "btnChooseIng");
            this.btnChooseIng.Name = "btnChooseIng";
            this.btnChooseIng.UseVisualStyleBackColor = false;
            this.btnChooseIng.Click += new System.EventHandler(this.btnChooseIng_Click);
            // 
            // listBSelect
            // 
            this.listBSelect.FormattingEnabled = true;
            resources.ApplyResources(this.listBSelect, "listBSelect");
            this.listBSelect.Name = "listBSelect";
            // 
            // listBDisponibles
            // 
            this.listBDisponibles.FormattingEnabled = true;
            this.listBDisponibles.Items.AddRange(new object[] {
            resources.GetString("listBDisponibles.Items"),
            resources.GetString("listBDisponibles.Items1"),
            resources.GetString("listBDisponibles.Items2"),
            resources.GetString("listBDisponibles.Items3"),
            resources.GetString("listBDisponibles.Items4"),
            resources.GetString("listBDisponibles.Items5"),
            resources.GetString("listBDisponibles.Items6"),
            resources.GetString("listBDisponibles.Items7"),
            resources.GetString("listBDisponibles.Items8"),
            resources.GetString("listBDisponibles.Items9")});
            resources.ApplyResources(this.listBDisponibles, "listBDisponibles");
            this.listBDisponibles.Name = "listBDisponibles";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cbProducto
            // 
            this.cbProducto.FormattingEnabled = true;
            resources.ApplyResources(this.cbProducto, "cbProducto");
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.SelectedIndexChanged += new System.EventHandler(this.cbProducto_SelectedIndexChanged);
            // 
            // lbProd
            // 
            resources.ApplyResources(this.lbProd, "lbProd");
            this.lbProd.Name = "lbProd";
            // 
            // tbTicket
            // 
            resources.ApplyResources(this.tbTicket, "tbTicket");
            this.tbTicket.Name = "tbTicket";
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
            this.rbSupremo.CheckedChanged += new System.EventHandler(this.rbChica_CheckedChanged);
            // 
            // rbGrande
            // 
            resources.ApplyResources(this.rbGrande, "rbGrande");
            this.rbGrande.Image = global::CapaDePresentacion.Properties.Resources.pizzamed;
            this.rbGrande.Name = "rbGrande";
            this.rbGrande.TabStop = true;
            this.rbGrande.UseVisualStyleBackColor = true;
            this.rbGrande.CheckedChanged += new System.EventHandler(this.rbChica_CheckedChanged);
            // 
            // rbMed
            // 
            resources.ApplyResources(this.rbMed, "rbMed");
            this.rbMed.Image = global::CapaDePresentacion.Properties.Resources.pizzach;
            this.rbMed.Name = "rbMed";
            this.rbMed.TabStop = true;
            this.rbMed.UseVisualStyleBackColor = true;
            this.rbMed.CheckedChanged += new System.EventHandler(this.rbChica_CheckedChanged);
            // 
            // rbChica
            // 
            resources.ApplyResources(this.rbChica, "rbChica");
            this.rbChica.Image = global::CapaDePresentacion.Properties.Resources.pizzaper;
            this.rbChica.Name = "rbChica";
            this.rbChica.TabStop = true;
            this.rbChica.UseVisualStyleBackColor = true;
            this.rbChica.CheckedChanged += new System.EventHandler(this.rbChica_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.lbVentas);
            this.panel1.Controls.Add(this.label2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
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
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
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
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbVentas
            // 
            this.lbVentas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lbVentas.FullRowSelect = true;
            resources.ApplyResources(this.lbVentas, "lbVentas");
            this.lbVentas.Name = "lbVentas";
            this.lbVentas.UseCompatibleStateImageBehavior = false;
            this.lbVentas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // columnHeader4
            // 
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // columnHeader5
            // 
            resources.ApplyResources(this.columnHeader5, "columnHeader5");
            // 
            // columnHeader6
            // 
            resources.ApplyResources(this.columnHeader6, "columnHeader6");
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
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
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnConfig);
            this.panel2.Controls.Add(this.btnClientes);
            this.panel2.Controls.Add(this.btnVentas);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaDePresentacion.Properties.Resources.pizzalogo;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
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
            // VentanaPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "VentanaPrincipal";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.VentanaPrincipal_Paint);
            this.panelCenter.ResumeLayout(false);
            this.panelCenter.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelVentas.ResumeLayout(false);
            this.panelVentas.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelClientes.ResumeLayout(false);
            this.panelClientes.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.RichTextBox tbTicket;
        private System.Windows.Forms.ListBox listBSelect;
        private System.Windows.Forms.ListBox listBDisponibles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.Label lbProd;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ComboBox cbRepartidor;
        private System.Windows.Forms.Label lbRepartidor;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.Button btnChooseIng;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ListView lbVentas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

