using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDePresentacion
{
    public partial class VentanaPrincipal : Form
	{
        private Login l;
        public int xClick = 0, yClick = 0;

        public VentanaPrincipal()
		{
			InitializeComponent();
		}
        public VentanaPrincipal(Login l)
        {
            InitializeComponent();
            this.l = l;
        }

        private void btnCerrarLog_Click(object sender, EventArgs e)
        {
            if (l != null)
            {
                this.l.Dispose();
                this.l.Close();
            }
            this.Close();
            int a = 0;
        }

        private void btnMinLog_Click(object sender, EventArgs e)
        {

        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        private void btnVentas_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button) sender;
            //Resize Animation
            btn.Width = 252;
            btn.Height = 67;
            btn.Location = new Point(btn.Location.X - 5, btn.Location.Y - 5);
            //ChangeColor
            btn.BackColor = ColorTranslator.FromHtml("#DB4E41");
            //ChangeFont
            btn.Font = new Font(new FontFamily("Segoe UI"), 25f,FontStyle.Italic);
            btn.ForeColor = Color.White;


            lbX.Text = btn.Width.ToString();
            lbY.Text = btn.Height.ToString();


        }

        private void btnVentas_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //Resize Animation
            btn.Width = 242;
            btn.Height = 57;
            btn.Location = new Point(btn.Location.X + 5, btn.Location.Y + 5);
            //ChangeColor
            btn.BackColor = ColorTranslator.FromHtml("#FFFF");
            //ChangeFont
            btn.Font = new Font(new FontFamily("Segoe UI"), 22.2f, FontStyle.Italic);
            btn.ForeColor = Color.Black;

            lbX.Text = btn.Width.ToString();
            lbY.Text = btn.Height.ToString();



        }

        private void VentanaPrincipal_Paint(object sender, PaintEventArgs e)
        {
            lbX.Text = btnVentas.Width.ToString();
            lbY.Text = btnVentas.Height.ToString();

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            DialogResult result = MessageBox.Show("¿Está seguro de que desea salir?", "Cerrar Aplicación", MessageBoxButtons.OKCancel);
            switch (result)
            {
                case DialogResult.OK:
                    l.Dispose();
                    this.Dispose();
                    Application.Exit();
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }
    }
}
