using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Formulario_Cruces_JEFF
{
    public partial class PantallaPrincipal : Form
    {
        ConexionBDJeff ne = new ConexionBDJeff();
        public PantallaPrincipal()
        {
            InitializeComponent();
            //ConexionRemotaFormulario entradaCon = new ConexionRemotaFormulario(ref ne);

            //entradaCon.ShowDialog();

            //ne.EstablecerConexionServidorRemoto(ne.Usuario, ne.Port, ne.Contrasena, ne.Servidor, (s) => MessageBox.Show(s), ne.Database);
        }

        private void crearBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ne.CrearBaseDatosLocal((s) => MessageBox.Show(s));
        }

        private void conectarABaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ConexionRemotaFormulario entradaCon = new ConexionRemotaFormulario(ref ne);

            entradaCon.ShowDialog();

            ne.EstablecerConexionServidorRemoto(ne.Usuario, ne.Port, ne.Contrasena, ne.Servidor, (s) => MessageBox.Show(s), ne.Database);
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            Recargar();
        }

        void Recargar()
        {
            List<Cruce> lista = ne.ObtenerListaCruces((s) => MessageBox.Show(s));
            dtgTablaDatos.Rows.Clear();
            foreach (Cruce cruz in lista)
            {
                dtgTablaDatos.Rows.Add(cruz.CodigoCruce, cruz.CodigoCruce, cruz.TipoServicio, cruz.Cliente, cruz.Caja, cruz.Remision, cruz.EstatusCobro, cruz.FechaCarga.ToString("f"), cruz.FechaEntrega.ToString("f"), cruz.LugarCarga, cruz.LugarDescarga, cruz.PrecioPesos, cruz.PrecioDolares, cruz.Intermediario, cruz.Unidad, cruz.Conductor, cruz.FechaPagoPedimento.ToString("f"), cruz.FechaVencimientoPedimento.ToString("f"), cruz.Asignada);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Cruce nuevoCruce = new Cruce();
                nuevoCruce.TipoServicio = txtTipoServicio.Text;
                nuevoCruce.Cliente = txtCliente.Text;
                nuevoCruce.Caja = txtCaja.Text;
                nuevoCruce.Remision = txtRemision.Text;
                nuevoCruce.EstatusCobro = txtEstatusCobro.Text;
                nuevoCruce.FechaCarga = dtpFechaCarga.Value;
                nuevoCruce.FechaEntrega = dtpFechaEntrega.Value;
                nuevoCruce.LugarCarga = txtLugarCarga.Text;
                nuevoCruce.LugarDescarga = txtLugarDescarga.Text;
                nuevoCruce.PrecioPesos = double.Parse(txtPrecioPesos.Text);
                nuevoCruce.PrecioDolares = double.Parse(txtPrecioDolares.Text);
                nuevoCruce.Intermediario = txtIntermediario.Text;
                nuevoCruce.Unidad = int.Parse(txtUnidad.Text);
                nuevoCruce.Conductor = txtConductor.Text;
                nuevoCruce.FechaPagoPedimento = dtpFechaPagoPedimento.Value;
                nuevoCruce.FechaVencimientoPedimento = dtpFechaVencimientoPedimento.Value;
                nuevoCruce.Asignada = txtAsignada.Text;
                ne.AgregarCruce(nuevoCruce, (s) => MessageBox.Show(s));
                Recargar();
            }
            catch (MySql.Data.MySqlClient.MySqlException mex)
            {

                MessageBox.Show(mex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
