namespace CapaDePresentacion
{
    partial class Login
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
            this.txtBUsuario = new System.Windows.Forms.TextBox();
            this.txtBContraseña = new System.Windows.Forms.TextBox();
            this.panelCentralLog = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.panelSupLogin = new System.Windows.Forms.Panel();
            this.btnMinLog = new System.Windows.Forms.PictureBox();
            this.btnCerrarLog = new System.Windows.Forms.PictureBox();
            this.panelCentralLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSupLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarLog)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBUsuario
            // 
            this.txtBUsuario.BackColor = System.Drawing.Color.White;
            this.txtBUsuario.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBUsuario.Location = new System.Drawing.Point(128, 261);
            this.txtBUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtBUsuario.Name = "txtBUsuario";
            this.txtBUsuario.Size = new System.Drawing.Size(208, 31);
            this.txtBUsuario.TabIndex = 1;
            this.txtBUsuario.Text = "Usuario";
            this.txtBUsuario.Enter += new System.EventHandler(this.txtBUsuario_Enter);
            this.txtBUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBContraseña_KeyPress);
            this.txtBUsuario.Leave += new System.EventHandler(this.txtBUsuario_Leave);
            // 
            // txtBContraseña
            // 
            this.txtBContraseña.BackColor = System.Drawing.Color.White;
            this.txtBContraseña.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBContraseña.Location = new System.Drawing.Point(128, 322);
            this.txtBContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtBContraseña.Name = "txtBContraseña";
            this.txtBContraseña.PasswordChar = '*';
            this.txtBContraseña.Size = new System.Drawing.Size(208, 31);
            this.txtBContraseña.TabIndex = 2;
            this.txtBContraseña.Text = "Contraseña";
            this.txtBContraseña.Enter += new System.EventHandler(this.txtBContraseña_Enter);
            this.txtBContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBContraseña_KeyPress);
            this.txtBContraseña.Leave += new System.EventHandler(this.txtBContraseña_Leave);
            // 
            // panelCentralLog
            // 
            this.panelCentralLog.BackColor = System.Drawing.Color.White;
            this.panelCentralLog.Controls.Add(this.pictureBox1);
            this.panelCentralLog.Controls.Add(this.btnIngresar);
            this.panelCentralLog.Controls.Add(this.txtBContraseña);
            this.panelCentralLog.Controls.Add(this.txtBUsuario);
            this.panelCentralLog.Location = new System.Drawing.Point(0, 48);
            this.panelCentralLog.Margin = new System.Windows.Forms.Padding(4);
            this.panelCentralLog.Name = "panelCentralLog";
            this.panelCentralLog.Size = new System.Drawing.Size(462, 508);
            this.panelCentralLog.TabIndex = 1;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Red;
            this.btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(128, 388);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(208, 31);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // panelSupLogin
            // 
            this.panelSupLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(156)))), ((int)(((byte)(12)))));
            this.panelSupLogin.Controls.Add(this.btnMinLog);
            this.panelSupLogin.Controls.Add(this.btnCerrarLog);
            this.panelSupLogin.Location = new System.Drawing.Point(0, -2);
            this.panelSupLogin.Margin = new System.Windows.Forms.Padding(4);
            this.panelSupLogin.Name = "panelSupLogin";
            this.panelSupLogin.Size = new System.Drawing.Size(462, 43);
            this.panelSupLogin.TabIndex = 0;
            this.panelSupLogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSupLogin_MouseMove);        
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 559);
            this.Controls.Add(this.panelCentralLog);
            this.Controls.Add(this.panelSupLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panelCentralLog.ResumeLayout(false);
            this.panelCentralLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSupLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtBUsuario;
        private System.Windows.Forms.TextBox txtBContraseña;
        private System.Windows.Forms.Panel panelCentralLog;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelSupLogin;
        private System.Windows.Forms.PictureBox btnMinLog;
        private System.Windows.Forms.PictureBox btnCerrarLog;
    }
}