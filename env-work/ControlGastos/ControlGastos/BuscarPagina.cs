using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlGastos
{
    public partial class BuscarPagina : Form
    {
        string[] arrstrInert = new string[19];
        Gasto gastoBusqueda = new Gasto();
        public BuscarPagina()
        {
            InitializeComponent();
        }
        public BuscarPagina(ref string[] arrstrArreglo)
        {
            InitializeComponent();
            arrstrArreglo = arrstrInert;
        }
        public BuscarPagina(ref Gasto gastoBusqueda) { 
            InitializeComponent();
            this.gastoBusqueda = gastoBusqueda;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //arrstrInert[0] = txtCodigoCruce.Text;
            //arrstrInert[1] = txtTipoServicio.Text;
            //arrstrInert[2] = txtCaja.Text;
            //arrstrInert[3] = txtRemision.Text;
            //arrstrInert[4] = cboEstatusCobro.Text;
            //arrstrInert[5] = dtpFechaCarga.Value.ToString("yyyy-MM-dd HH:mm:ss");
            //arrstrInert[6] = dtpFechaEntrega.Value.ToString("yyyy-MM-dd HH:mm:ss");
            //arrstrInert[7] = txtLugarCarga.Text;
            //arrstrInert[8] = txtLugarDescarga.Text;
            //arrstrInert[9] = txtPrecioPesos.Text;
            //arrstrInert[10] = txtPrecioDolares.Text;
            //arrstrInert[11] = txtIntermediario.Text;
            //arrstrInert[12] = txtCliente.Text;
            //arrstrInert[13] = cboAsignada.Text;
            //arrstrInert[14] = cboUnidad.Text;
            //arrstrInert[15] = txtConductor.Text;
            //arrstrInert[16] = dtpFechaPagoPedimento.Value.ToString("yyyy-MM-dd HH:mm:ss");
            //arrstrInert[17] = dtpVencimientoPedimento.Value.ToString("yyyy-MM-dd HH:mm:ss");
            //arrstrInert[18] = txtDemora.Text;

            this.Close();
        }

        private void BuscarPagina_Load(object sender, EventArgs e)
        {
            txtCodigoGasto.DataBindings.Add("Text", gastoBusqueda, "IdGasto");
            txtTipoGasto.DataBindings.Add("Text", gastoBusqueda, "TipoGasto");
            cboUnidades.DataBindings.Add("Text", gastoBusqueda, "Unidad");
            txtImpuestos.DataBindings.Add("Text", gastoBusqueda, "Impuestos");
            txtCantidad.DataBindings.Add("Text", gastoBusqueda, "Cantidad");
            txtNoFactura.DataBindings.Add("Text", gastoBusqueda, "NumeroFactura");
            rtxtDemora.DataBindings.Add("Text", gastoBusqueda, "Demora");
            txtGarantia.DataBindings.Add("Text", gastoBusqueda, "Garantia");
            if (gastoBusqueda.FechaCompra < dtpFechaCompra.MinDate || gastoBusqueda.FechaCompra > dtpFechaCompra.MaxDate)
            {
                gastoBusqueda.FechaCompra = DateTime.Now; // or any valid date
            }
            dtpFechaCompra.DataBindings.Add("Value", gastoBusqueda, "FechaCompra");
        }
    }
}
