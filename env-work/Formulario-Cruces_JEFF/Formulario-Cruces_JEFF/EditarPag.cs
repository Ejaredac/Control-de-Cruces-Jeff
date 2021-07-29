using System;
using System.Windows.Forms;

namespace Formulario_Cruces_JEFF
{
    public partial class EditarPag : Form
    {
        private Cruce cruEdi;

        public Cruce Edi
        {
            get { return cruEdi; }
            set { cruEdi = value; }
        }

        public EditarPag()
        {
            InitializeComponent();
        }
        public EditarPag(ref Cruce neu)
        {
            InitializeComponent();
            Edi = neu;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Edi.CodigoCruce = int.Parse(txtCodigoCruce.Text);
                Edi.TipoServicio = txtTipoServicio.Text;
                Edi.Cliente = txtCliente.Text;
                Edi.Caja = txtCaja.Text;
                Edi.Remision = txtRemision.Text;
                Edi.EstatusCobro = cboEstatusCobro.Text;
                Edi.FechaCarga = dtpFechaCarga.Value;
                Edi.FechaEntrega = dtpFechaEntrega.Value;
                Edi.LugarCarga = txtLugarCarga.Text;
                Edi.LugarDescarga = txtLugarDescarga.Text;
                Edi.PrecioPesos = double.Parse(txtPrecioPesos.Text);
                Edi.PrecioDolares = double.Parse(txtPrecioDolares.Text);
                Edi.Intermediario = txtIntermediario.Text;
                Edi.Unidad = cboUnidades.Text;
                Edi.Conductor = txtConductor.Text;
                Edi.FechaPagoPedimento = dtpFechaPagoPedimento.Value;
                Edi.FechaVencimientoPedimento = dtpFechaVencimientoPedimento.Value;
                Edi.Asignada = cboAsignada.Text;
                Edi.Demora = rtxtDemora.Text;
                this.Close();
                this.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void txtPrecioDolares_TextChanged(object sender, EventArgs e)
        {
            if (txtPrecioPesos.Text != "0")
            {
                txtPrecioPesos.Text = "0";
            }
        }

        private void txtPrecioPesos_TextChanged(object sender, EventArgs e)
        {
            if (txtPrecioDolares.Text != "0")
            {
                txtPrecioDolares.Text = "0";
            }
        }

        private void EditarPag_Load(object sender, EventArgs e)
        {
            try
            {
                dtpFechaCarga.Value = Edi.FechaCarga;
                dtpFechaEntrega.Value = Edi.FechaEntrega;
                dtpFechaPagoPedimento.Value = Edi.FechaPagoPedimento;
                dtpFechaVencimientoPedimento.Value = Edi.FechaVencimientoPedimento;
                cboAsignada.Text = Edi.Asignada;
                txtCaja.Text = Edi.Caja;
                txtCliente.Text = Edi.Cliente;
                txtCodigoCruce.Text = Edi.CodigoCruce.ToString();
                txtConductor.Text = Edi.Conductor;
                cboEstatusCobro.Text = Edi.EstatusCobro;
                txtIntermediario.Text = Edi.Intermediario;
                txtLugarCarga.Text = Edi.LugarCarga;
                txtLugarDescarga.Text = Edi.LugarDescarga;
                txtPrecioDolares.Text = Edi.PrecioDolares.ToString();
                txtPrecioPesos.Text = Edi.PrecioPesos.ToString();
                txtRemision.Text = Edi.Remision;
                txtTipoServicio.Text = Edi.TipoServicio;
                cboUnidades.Text = Edi.Unidad.ToString();
                rtxtDemora.Text = Edi.Demora;
            }
            catch (Exception ex)
            {


            }
        }
    }
}
