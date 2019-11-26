using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeEntidades;
using CapaDeNegocios;

namespace CapaDePresentacion
{
    public partial class NuevoCliente : Form
    {
        private int xClick = 0, yClick = 0;
        private VentanaPrincipal vp;
        public static int NUEVOCLIENTE = 0;
        public static int MODIFICARCLIENTE = 1
        private int tipo;

        public NuevoCliente()
        {
            InitializeComponent();
        }

        public NuevoCliente(VentanaPrincipal vp,int tipo)
        {
            InitializeComponent();
            this.vp = vp;
            this.tipo = tipo;
            switch (tipo)
            {
                case 0:
                    this.lbTitle.Text = "Nuevo Cliente";
                    this.btnAddMaq.Text = "Agregar Cliente";

                    break;
                case 1:
                    this.lbTitle.Text = "Modificar Cliente";
                    this.btnAddMaq.Text = "Modificar Cliente";
                    this.txtID.Text = vp.lvClientes.SelectedItems[0].SubItems[0].Text.ToString();
                    this.txtNombre.Text = vp.lvClientes.SelectedItems[0].SubItems[1].Text.ToString();
                    this.txtCorreo.Text = vp.lvClientes.SelectedItems[0].SubItems[2].Text.ToString();
                    this.txtTelefono.Text = vp.lvClientes.SelectedItems[0].SubItems[3].Text.ToString();
                    this.txtDireccion.Text = vp.lvClientes.SelectedItems[0].SubItems[4].Text.ToString();








                    break;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        private void NuevaMaquina_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void btnAddMaq_Click(object sender, EventArgs e)
        {
            switch (tipo)
            {
                case 0:
                    string msg = "";

                    try
                    {
                        if (!txtID.Text.ToString().Equals("") && !txtNombre.Text.ToString().Equals("") && !txtCorreo.Text.ToString().Equals("")
                            && !txtTelefono.Text.ToString().Equals("") && !txtDireccion.Text.ToString().Equals(""))
                        {
                            Cliente clienteNuevo = new Cliente();
                            msg = "Introduce un ID único y válido";
                            clienteNuevo.Id = this.txtID.Text.ToString();
                            msg = "Introduce un nombre valido";
                            clienteNuevo.Nombre = this.txtNombre.Text.ToString();
                            msg = "Introduce un correo valido";
                            clienteNuevo.Correo = this.txtCorreo.Text.ToString();
                            msg = "Introduce un correo valido";
                            clienteNuevo.Telefono = this.txtTelefono.Text.ToString();
                            msg = "Introduce una dirección valida";
                            clienteNuevo.Direccion = this.txtDireccion.Text.ToString();
                            MessageBox.Show(ValidadorConsultas.insertarCliente(clienteNuevo));
                        }
                        else
                        {
                            MessageBox.Show("Asegurate de llenar todos los campos");
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show(msg);
                    }
                    break;
                case 1:
                    Cliente clienteModifi = new Cliente();
                    clienteModifi.Id = this.txtID.Text.ToString();
                    clienteModifi.Nombre = this.txtNombre.Text.ToString();
                    clienteModifi.Correo = this.txtCorreo.Text.ToString();
                    clienteModifi.Telefono = this.txtTelefono.Text.ToString();
                    clienteModifi.Direccion = this.txtDireccion.Text.ToString();                   
                    ValidadorConsultas.updateCliente(clienteModifi);
                    cCat.actualizarPanelIndicadores();
                    this.Close();








                    break;
            }




           

        }
        
    }  

}
