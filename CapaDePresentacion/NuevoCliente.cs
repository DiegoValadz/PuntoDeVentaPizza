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

        public NuevoCliente()
        {
            InitializeComponent();
        }

        public NuevoCliente(VentanaPrincipal vp)
        {
            InitializeComponent();
            this.vp = vp;
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
            string msg = "";

            try
            {
                /*   if (!txtTipoMaq.Text.ToString().Equals("") && !txtIP.Text.ToString().Equals("") && !txtIP2.Text.ToString().Equals("")
                       && !txtIP3.Text.ToString().Equals("") && !txtIP4.Text.ToString().Equals("") && !txtProdHora.Text.ToString().Equals("")
                    && !txtProd.Text.ToString().Equals("") && !txtPuerto.Text.ToString().Equals("") && !txtIdenti.Text.ToString().Equals(""))
                   {
                       Maquina m = new Maquina();
                       msg = "Introduce un ID único y válido";
                       m.ID = Convert.ToInt32(txtIdenti.Text.ToString());                   
                       msg = "La produccion/hora debe ser un valor numerico";
                       m.ProduccionHora = Convert.ToInt32(txtProdHora.Text.ToString());
                       msg = "Introduce un producto válido";
                       m.Producto = txtProd.Text.ToString();
                       msg = "Introduce un número de puerto valido";
                       m.Puerto = Convert.ToInt32(txtPuerto.Text.ToString());
                       msg = "Introduce un tipo/nombre de máquina valido";
                       m.Tipo = txtTipoMaq.Text.ToString();
                       msg = "Aegurate de que la IP de la maquina tiene el formato \"0.0.0.0\"";
                       int[] auxIP = new int[4];
                       auxIP[0] = Convert.ToInt32(txtIP.Text.ToString());
                       auxIP[1] = Convert.ToInt32(txtIP2.Text.ToString());
                       auxIP[2] = Convert.ToInt32(txtIP3.Text.ToString());
                       auxIP[3] = Convert.ToInt32(txtIP4.Text.ToString());
                       m.IP = auxIP[0] + "." + auxIP[1] + "." + auxIP[2] + "." + auxIP[3];*/

                Cliente clienteNuevo = new Cliente();
                clienteNuevo.Id = this.txtID.Text.ToString();
                clienteNuevo.Nombre = this.txtNombre.Text.ToString();
                clienteNuevo.Correo = this.txtCorreo.Text.ToString();
                clienteNuevo.Telefono = this.txtTelefono.Text.ToString();
                clienteNuevo.Direccion = this.txtDireccion.Text.ToString();


                MessageBox.Show( ValidadorConsultas.insertarCliente(clienteNuevo));
                    

            //    }
           //     else
          //      {
           //         MessageBox.Show("Asegurate de llenar todos los campos");
           //     }
                }
                catch (FormatException)
                {
                    MessageBox.Show(msg);
                }
          
        }
    }

  /*  class AutomataIP
    {
        private char[] ip;
        private bool valida;
        private int posActual;
        private int ascciActual;

        public AutomataIP(string ip)
        {
            this.ip = ip.ToCharArray();
            analizar();

        }

        private void analizar()
        {
            valida = false;
            q0();


        }

        private void q0()
        {
            bool cont = true;
            posActual = 0;
            if (posActual > ip.Length)
            {
                cont = false;
                valida = true;
            }

            while (cont)
            {
                if (esDigito(ip[posActual])){
                    posActual++;
                    
                } else if (ip[posActual] == '.')
                {
                    posActual++;
                    cont = false;
                    q0();
                }
                else
                {
                    valida = false;
                    cont = false;

                }
            }
        }

        

        private bool esDigito(char asciiActual)
        {
            return (asciiActual >= '0' && asciiActual <= '9');
        }

        public bool Valida
        {
            get { return valida; }
            set { valida = value; }
        }
    }
    */
     

    }
