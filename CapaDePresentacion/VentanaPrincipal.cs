using CapaDeEntidades;
using CapaDeNegocios;
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
        /*    lbX.Text = btnVentas.Width.ToString();
            lbY.Text = btnVentas.Height.ToString();*/

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            //   this.panelVentas.Visible = false;
            this.tabControl1.Visible = false;
            this.panelClientes.Visible = true;
            actualizarListaClientes();

            

        }

        public void actualizarListaClientes()
        {
            this.lvClientes.Items.Clear();

            List<Cliente> clientList = ValidadorConsultas.getClientes();
            foreach (Cliente aux in clientList)
            {
                ListViewItem lista = new ListViewItem();
                lista.Text = aux.Id;
                lista.SubItems.Add(aux.Nombre);
                lista.SubItems.Add(aux.Correo);
                lista.SubItems.Add(aux.Telefono);
                lista.SubItems.Add(aux.Direccion);
                this.lvClientes.Items.Add(lista);
            }
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            this.tabControl1.Visible = true;
            this.panelClientes.Visible = false;

        }


        public void actualizarListaVentas()
        {
            this.lbVentas.Items.Clear();

            List<Venta> ventList = ValidadorConsultas.getVentas();
            foreach (Venta aux in ventList)
            {
                ListViewItem lista = new ListViewItem();
                lista.Text = aux.VentaID.ToString();
                lista.SubItems.Add(aux.Usuario);
                lista.SubItems.Add(aux.Producto);
                lista.SubItems.Add(aux.Cliente);
                lista.SubItems.Add(aux.Repartidor);
                lista.SubItems.Add(aux.PrecioTotal);
                lista.SubItems.Add(aux.Fecha);
                lista.SubItems.Add(aux.EstadoVenta);
                this.lbVentas.Items.Add(lista);
            }
        }

    

        private void btnAgregarClientes_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["NuevoCliente"] == null)
            {
                NuevoCliente nc = new NuevoCliente(this,NuevoCliente.NUEVOCLIENTE);
                nc.StartPosition = FormStartPosition.CenterScreen;
                nc.Show();
            }
        }

        private void panelClientes_Paint(object sender, PaintEventArgs e)
        {
            this.lvClientes.FullRowSelect = true;
            this.lbVentas.FullRowSelect = true;
            

        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.lvClientes.FocusedItem.Text.ToString();
                if (Application.OpenForms["NuevoCliente"] == null)
                {
                    NuevoCliente m = new NuevoCliente(this,NuevoCliente.MODIFICARCLIENTE);
                    m.StartPosition = FormStartPosition.CenterScreen;
                    m.Show();
                }

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Debes seleccionar primero un elemento a modificar");
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.lvClientes.FocusedItem.Text.ToString();
                ValidadorConsultas.deleteCliente(id);
                actualizarListaClientes();

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Debes seleccionar primero un elemento a modificar");
            }
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            TempObjects.productos = ValidadorConsultas.getProductos();
            TempObjects.tamaños = ValidadorConsultas.getTamaños();
            TempObjects.clientes = ValidadorConsultas.getClientes();
            TempObjects.ventas = ValidadorConsultas.getVentas();

            TempObjects.repartidores = ValidadorConsultas.getRepartidores();


            //  TempObjects.ingredientes = ValidadorConsultas.getColumna("Nombre","Ingredientes");
            //  listBDisponibles.DataSource = TempObjects.ingredientes;

            List<string> prodNames  = extractNames();
            List<string> clientesNames = extractClientes();
            List<string> repNames = extractReps();

            this.cbRepartidor.DataSource = repNames;
            this.cbProducto.DataSource = prodNames;
            this.cbCliente.DataSource = clientesNames;
        }

        private List<string> extractReps()
        {
            List<string> aux = new List<string>();
            foreach (Repartidor r in TempObjects.repartidores)
            {
                aux.Add(r.Nombre);
            }
            return aux;
        }

        private List<string> extractClientes()
        {
            List<string> aux = new List<string>();
            foreach (Cliente c in TempObjects.clientes)
            {
                aux.Add(c.Nombre);
            }
            return aux;
        }

        private void cbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string catAux = this.cbProducto.SelectedValue.ToString();
            TempObjects.productosActualVenta = findProductData(catAux);
            updateTicket();

        }

        private void updateTicket()
        {
            TempObjects.fechaActualVenta = Utilities.GetDateTimeUtc(); ;
            TempObjects.ticketActualVenta = "\t\t\tTicket de Venta";
            TempObjects.ticketActualVenta += "\n\nFecha: \t" + TempObjects.fechaActualVenta;
            TempObjects.ticketActualVenta += "\nProducto: " + TempObjects.productosActualVenta.Nombre;
            TempObjects.ticketActualVenta += "\nDescripción: " + TempObjects.productosActualVenta.Descripcion;
            TempObjects.ticketActualVenta += "\nIngredientes: "+ TempObjects.ingredientes;
            TempObjects.ticketActualVenta += "\nTamaño de la Orden: " + TempObjects.tamañoActualVenta.TamañoValue;
            TempObjects.ticketActualVenta += "\nCliente: " + TempObjects.clienteActualVenta.Nombre;
            TempObjects.ticketActualVenta += "\nDirección: "+ TempObjects.clienteActualVenta.Direccion; 
            TempObjects.ticketActualVenta += "\nRepartidor: " + TempObjects.repartidoreActualVenta.Nombre; 
            TempObjects.ticketActualVenta += "\nPrecio Unitario: $" + TempObjects.productosActualVenta.PrecioUnitario;
            TempObjects.ticketActualVenta += "\nIVA: 16%";
            TempObjects.ticketActualVenta += "\nCostos Adicionales: $"+ Utilities.calcularCostosAdd();
            TempObjects.ticketActualVenta += "\nTotal: $"+ Utilities.calcularTotal();

            tbTicket.Text = TempObjects.ticketActualVenta;


        }
        private void btnChooseIng_Click(object sender, EventArgs e)
        {
            moveListBoxItems(listBDisponibles, listBSelect,0);
            updateTicket();
        }
        private void btnRemover_Click(object sender, EventArgs e)
        {
            moveListBoxItems( listBSelect, listBDisponibles,1);
            updateTicket();

        }

        private void moveListBoxItems(ListBox source, ListBox destination,int selector)
        {
            try
            {
                ListBox.SelectedObjectCollection sourceItems = source.SelectedItems;
                foreach (var item in sourceItems)
                {
                    destination.Items.Add(item);
                    switch (selector)
                    {
                        case 0:
                            TempObjects.ingredientesList.Add(item.ToString());
                            Utilities.updateIngredientes();

                            break;
                        case 1:

                            foreach (string s in TempObjects.ingredientesList)
                            {
                                if (s.Equals(item.ToString()))
                                {
                                    TempObjects.ingredientesList.Remove(s);
                                    Utilities.updateIngredientes();

                                }
                            }
                            break;
                    }
                }
                while (source.SelectedItems.Count > 0)
                {
                    source.Items.Remove(source.SelectedItems[0]);
                    switch (selector)
                    {

                    }
                }
            }
            catch (InvalidOperationException)
            {

            }
            
        }

        private List<string> extractNames()
        {
            List<string> aux = new List<string>();
            foreach (Producto p in TempObjects.productos)
            {
                aux.Add(p.Nombre);
            }
            return aux;
        }
        private Producto findProductData(string name)
        {
            Producto aux = new Producto();
            foreach (Producto p in TempObjects.productos)
            {
                if (p.Nombre.Equals(name))
                    aux = p;
            }
            return aux;
        }
        private Tamaño findSizeData(string size)
        {
            Tamaño aux = new Tamaño();
            foreach (Tamaño t in TempObjects.tamaños)
            {
                if (t.TamañoValue.Equals(size))
                    aux = t;
            }
            return aux;
        }

        private void rbChica_CheckedChanged(object sender, EventArgs e)
        {
            if (rbChica.Checked == true)
            {
                TempObjects.tamañoActualVenta = findSizeData("Chica");
            }
            else if (rbMed.Checked == true)
            {
                TempObjects.tamañoActualVenta = findSizeData("Mediana");

            }
            else if (rbGrande.Checked == true)
            {
                TempObjects.tamañoActualVenta = findSizeData("Grande");

            }
            else if (rbSupremo.Checked == true)
            {
                TempObjects.tamañoActualVenta = findSizeData("Suprema");
            }
            updateTicket();
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string catAux = this.cbCliente.SelectedValue.ToString();
            TempObjects.clienteActualVenta = findClientetData(catAux);
            updateTicket();
        }

        private Cliente findClientetData(string catAux)
        {
            Cliente aux = new Cliente();
            foreach (Cliente c in TempObjects.clientes)
            {
                if (c.Nombre.Equals(catAux))
                    aux = c;
            }
            return aux;
        }

        private void cbRepartidor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string catAux = this.cbRepartidor.SelectedValue.ToString();
            TempObjects.repartidoreActualVenta = findReptData(catAux);
            updateTicket();
        }

        private Repartidor findReptData(string catAux)
        {
            Repartidor aux = new Repartidor();
            foreach (Repartidor c in TempObjects.repartidores)
            {
                if (c.Nombre.Equals(catAux))
                    aux = c;
            }
            return aux;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            MessageBox.Show( ValidadorConsultas.generarVenta());
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            actualizarListaVentas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.lbVentas.FocusedItem.Text.ToString();
                if (ValidadorConsultas.deleteVenta(id))
                {
                    MessageBox.Show("La venta fue eliminada con exito");

                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al eliminar la venta");

                }
                actualizarListaVentas();

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Debes seleccionar primero un elemento a modificar");
            }
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
