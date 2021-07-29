using System;
using System.Windows.Forms;

namespace Formulario_Cruces_JEFF
{
    public partial class AgregarPag : Form
    {
        private Cruce cruAgreg = new Cruce();

        public Cruce Agreg
        {
            get { return cruAgreg; }
            set { cruAgreg = value; }
        }

        public AgregarPag()
        {
            InitializeComponent();
        }
        public AgregarPag(ref Cruce neu)
        {
            InitializeComponent();
            neu = Agreg;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Agreg.CodigoCruce = 0;
                Agreg.TipoServicio = txtTipoServicio.Text;
                Agreg.Cliente = txtCliente.Text;
                Agreg.Caja = txtCaja.Text;
                Agreg.Remision = txtRemision.Text;
                Agreg.EstatusCobro = cboEstatusCobro.Text;
                Agreg.FechaCarga = dtpFechaCarga.Value;
                Agreg.FechaEntrega = dtpFechaEntrega.Value;
                Agreg.LugarCarga = txtLugarCarga.Text;
                Agreg.LugarDescarga = txtLugarDescarga.Text;
                Agreg.PrecioPesos = double.Parse(txtPrecioPesos.Text);
                Agreg.PrecioDolares = double.Parse(txtPrecioDolares.Text);
                Agreg.Intermediario = txtIntermediario.Text;
                Agreg.Unidad = cboUnidades.Text;
                Agreg.Conductor = txtConductor.Text;
                Agreg.FechaPagoPedimento = dtpFechaPagoPedimento.Value;
                Agreg.FechaVencimientoPedimento = dtpFechaVencimientoPedimento.Value;
                Agreg.Asignada = cboAsignada.Text;
                Agreg.Demora = rtxtDemora.Text;
                this.Close();
            }
            catch (Exception ex)
            {

                this.Close();
            }

        }

        private void txtPrecioPesos_TextChanged(object sender, EventArgs e)
        {
            if (txtPrecioDolares.Text != "0")
            {
                txtPrecioDolares.Text = "0";
            }
        }

        private void txtPrecioDolares_TextChanged(object sender, EventArgs e)
        {
            if (txtPrecioPesos.Text != "0")
            {
                txtPrecioPesos.Text = "0";
            }
        }

        private void AgregarPag_Load(object sender, EventArgs e)
        {
            try
            {
                dtpFechaCarga.Value = DateTime.Now;
                dtpFechaEntrega.Value = DateTime.Now;
                dtpFechaPagoPedimento.Value = DateTime.Now;
                dtpFechaVencimientoPedimento.Value = DateTime.Now;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
