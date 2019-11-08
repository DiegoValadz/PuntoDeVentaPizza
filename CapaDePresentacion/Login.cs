using System;
using System.Drawing;   
using System.Windows.Forms;
using CapaDeEntidades;
using CapaDeNegocios;

namespace CapaDePresentacion
{

    public partial class Login : Form
    {
        public int xClick = 0, yClick = 0;
        private VentanaPrincipal vp;

        public Login(VentanaPrincipal vp)
        {
            InitializeComponent();
            this.vp = vp;
        }

            public Login()
        {
            InitializeComponent();
        }
    
        private void btnMinLog_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelSupLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        private void txtBUsuario_Enter(object sender, EventArgs e)
        {
            if( txtBUsuario.Text == "Usuario") {
                txtBUsuario.Text = "";

                txtBUsuario.ForeColor = Color.Red;
            }
        }

        private void txtBUsuario_Leave(object sender, EventArgs e)
        {
            if (txtBUsuario.Text == "")
            {
                txtBUsuario.Text = "Usuario";
                txtBUsuario.ForeColor = Color.Silver;
            }
        }

        private void txtBContraseña_Enter(object sender, EventArgs e)
        {
            if (txtBContraseña.Text == "Contraseña")
            {
                txtBContraseña.Text = "";
                txtBContraseña.PasswordChar = '*';
                txtBContraseña.ForeColor = Color.Red;
            }
        }

        private void txtBContraseña_Leave(object sender, EventArgs e)
        {
            if (txtBContraseña.Text == "")
            {
                txtBContraseña.Text = "Contraseña";

                txtBContraseña.ForeColor = Color.Silver;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
          
            Usuario userObj = new Usuario();

            userObj.UserName = txtBUsuario.Text;
            userObj.Contraseña = txtBContraseña.Text;

                if(ValidadorConsultas.accesoSP(userObj) == 0)
                {
                    //No se pudo
                    MessageBox.Show("Usuario y/o contraseña incorrectos \n Intentelo nuevamente", "Acceso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBContraseña.Text = "";
                    txtBContraseña.Focus();
                }
                else
                {
                    this.Hide();
                    //Si se pudo
                    VentanaPrincipal Vp = new VentanaPrincipal(this);
                    Vp.Show();                  
                }
        }
        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (vp != null)
            {
                this.vp.Dispose();
                this.vp.Close();
            }
            this.Close();
            int a = 0;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;

        }     

        private void txtBContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnIngresar.PerformClick();
            }
        }            

        private void btnCerrarLog_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}