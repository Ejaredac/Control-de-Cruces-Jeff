using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ControlGastos
{
    public partial class EditarPag : Form
    {
        private Cruce cruEdi;
        private Gasto gastoEdi;

        public Cruce Edi
        {
            get { return cruEdi; }
            set { cruEdi = value; }
        }

        public EditarPag()
        {
            InitializeComponent();
        }
        private ConexionBDJeff _bdConex;

        public ConexionBDJeff Conex
        {
            get { return _bdConex; }
            set { _bdConex = value; }
        }

        public EditarPag(ref Cruce neu, ConexionBDJeff cone)
        {
            InitializeComponent();
            Edi = neu;
            Conex = cone;
        }
        public EditarPag(ref Gasto neu, ConexionBDJeff cone)
        {
            InitializeComponent();
            gastoEdi = neu;
            Conex = cone;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Edi.CodigoCruce = int.Parse(txtCodigoCruce.Text);
            //    Edi.TipoServicio = txtTipoServicio.Text;
            //    Edi.Cliente = txtCliente.Text;
            //    Edi.Caja = txtCaja.Text;
            //    Edi.Remision = txtRemision.Text;
            //    Edi.EstatusCobro = cboEstatusCobro.Text;
            //    Edi.FechaCarga = dtpFechaCarga.Value;
            //    Edi.FechaEntrega = dtpFechaEntrega.Value;
            //    Edi.LugarCarga = txtLugarCarga.Text;
            //    Edi.LugarDescarga = txtLugarDescarga.Text;
            //    Edi.PrecioPesos = double.Parse(txtPrecioPesos.Text);
            //    Edi.PrecioDolares = double.Parse(txtPrecioDolares.Text);
            //    Edi.Intermediario = txtIntermediario.Text;
            //    Edi.Unidad = cboUnidades.Text;
            //    Edi.Conductor = txtConductor.Text;
            //    Edi.FechaPagoPedimento = dtpFechaPagoPedimento.Value;
            //    Edi.FechaVencimientoPedimento = dtpFechaVencimientoPedimento.Value;
            //    Edi.Asignada = cboAsignada.Text;
            //    Edi.Demora = rtxtDemora.Text;
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




        private void EditarPag_Load(object sender, EventArgs e)
        {
            try
            {
                txtCantidad.Text = gastoEdi.Cantidad.ToString();
                txtCodigoGasto.Text = gastoEdi.IdGasto.ToString();
                txtGarantia.Text = gastoEdi.Garantia;
                txtImpuestos.Text = gastoEdi.Impuestos.ToString();
                txtNoFactura.Text = gastoEdi.NumeroFactura;
                txtTipoGasto.Text = gastoEdi.TipoGasto;
                cboUnidades.Text = gastoEdi.Unidad;
                rtxtDemora.Text = gastoEdi.Demora;
                dtpFechaCompra.Value = gastoEdi.FechaCompra;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            txtCodigoGasto.DataBindings.Add("Text", gastoEdi, "IdGasto");
            txtTipoGasto.DataBindings.Add("Text", gastoEdi, "TipoGasto");
            cboUnidades.DataBindings.Add("Text", gastoEdi, "Unidad");
            txtImpuestos.DataBindings.Add("Text", gastoEdi, "Impuestos");
            txtCantidad.DataBindings.Add("Text", gastoEdi, "Cantidad");
            txtNoFactura.DataBindings.Add("Text", gastoEdi, "NumeroFactura");
            rtxtDemora.DataBindings.Add("Text", gastoEdi, "Demora");
            txtGarantia.DataBindings.Add("Text", gastoEdi, "Garantia");
            if (gastoEdi.FechaCompra < dtpFechaCompra.MinDate || gastoEdi.FechaCompra > dtpFechaCompra.MaxDate)
            {
                gastoEdi.FechaCompra = DateTime.Now; // or any valid date
            }
            dtpFechaCompra.DataBindings.Add("Value", gastoEdi, "FechaCompra");
        }
        
        
    }
}
