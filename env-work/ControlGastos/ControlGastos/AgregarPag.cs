using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ControlGastos
{
    public partial class AgregarPag : Form
    {
        private Cruce cruAgreg = new Cruce();
        private Gasto gastoAgreg = new Gasto();
        public Cruce Agreg
        {
            get { return cruAgreg; }
            set { cruAgreg = value; }
        }

        private ConexionBDJeff _bdConex;

        public ConexionBDJeff Conex
        {
            get { return _bdConex; }
            set { _bdConex = value; }
        }

        public AgregarPag()
        {
            InitializeComponent();
        }
        public AgregarPag(ref Cruce neu, ConexionBDJeff cone)
        {
            InitializeComponent();
            neu = Agreg;
            Conex = cone;
        }

        public AgregarPag(ref Gasto neu, ConexionBDJeff cone)
        {
            InitializeComponent();
            neu = gastoAgreg;
            Conex = cone;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Agreg.CodigoCruce = 0;
            //    Agreg.TipoServicio = txtTipoServicio.Text;
            //    Agreg.Cliente = txtCliente.Text;
            //    Agreg.Caja = txtCaja.Text;
            //    Agreg.Remision = txtRemision.Text;
            //    Agreg.EstatusCobro = cboEstatusCobro.Text;
            //    Agreg.FechaCarga = dtpFechaCarga.Value;
            //    Agreg.FechaEntrega = dtpFechaEntrega.Value;
            //    Agreg.LugarCarga = txtLugarCarga.Text;
            //    Agreg.LugarDescarga = txtLugarDescarga.Text;
            //    Agreg.PrecioPesos = double.Parse(txtPrecioPesos.Text);
            //    Agreg.PrecioDolares = double.Parse(txtPrecioDolares.Text);
            //    Agreg.Intermediario = txtIntermediario.Text;
            //    Agreg.Unidad = cboUnidades.Text;
            //    Agreg.Conductor = txtConductor.Text;
            //    Agreg.FechaPagoPedimento = dtpFechaPagoPedimento.Value;
            //    Agreg.FechaVencimientoPedimento = dtpFechaVencimientoPedimento.Value;
            //    Agreg.Asignada = cboAsignada.Text;
            //    Agreg.Demora = rtxtDemora.Text;
            //    this.DialogResult = DialogResult.OK;
            //    this.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    this.DialogResult = DialogResult.None;
            //    this.Close();
            //}
            try
            {
                gastoAgreg.IdGasto = 0;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.DialogResult = DialogResult.None;
                this.Close();
            }

        }

       

        private void AgregarPag_Load(object sender, EventArgs e)
        {
            try
            {
                dtpFechaCompra.Value = DateTime.Now;
                cboUnidades.Text = "";
                txtCantidad.Text = "0";
                txtImpuestos.Text = "0";
                txtGarantia.Text = "0";
                txtNoFactura.Text = "0";
                txtTipoGasto.Text = "";
                rtxtDemora.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtTipoGasto.DataBindings.Add("Text", gastoAgreg, "TipoGasto");
            cboUnidades.DataBindings.Add("Text", gastoAgreg, "Unidad");
            txtImpuestos.DataBindings.Add("Text", gastoAgreg, "Impuestos");
            txtCantidad.DataBindings.Add("Text", gastoAgreg, "Cantidad");
            txtNoFactura.DataBindings.Add("Text", gastoAgreg, "NumeroFactura");
            rtxtDemora.DataBindings.Add("Text", gastoAgreg, "Demora");
            txtGarantia.DataBindings.Add("Text", gastoAgreg, "Garantia");
            if (gastoAgreg.FechaCompra < dtpFechaCompra.MinDate || gastoAgreg.FechaCompra > dtpFechaCompra.MaxDate)
            {
                gastoAgreg.FechaCompra = DateTime.Now; // or any valid date
            }
            dtpFechaCompra.DataBindings.Add("Value", gastoAgreg, "FechaCompra");

        }




    }
}
