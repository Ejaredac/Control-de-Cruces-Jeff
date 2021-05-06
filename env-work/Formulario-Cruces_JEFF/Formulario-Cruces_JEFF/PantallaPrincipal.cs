using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Formulario_Cruces_JEFF
{
    public partial class PantallaPrincipal : Form
    {
        ConexionBDJeff ne = new ConexionBDJeff();
        Cruce scru;
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
                MessageBox.Show("Se ha agregado un nuevo cruce");
            }
            catch (MySql.Data.MySqlClient.MySqlException mex)
            {

                MessageBox.Show(mex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea elminar el registro?", "ELIMINACION", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ne.Eliminar(scru, (a) => MessageBox.Show(a));
                Recargar();
                MessageBox.Show("Se elimino el registro seleccionado");
            }
            else
            {
                MessageBox.Show("No se elimino ningun registro");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text;
            List<Cruce> lista = ne.ObtenerListaCrucesBuscados((s) => MessageBox.Show(s), busqueda);
            dtgTablaDatos.Rows.Clear();
            foreach (Cruce cruz in lista)
            {
                dtgTablaDatos.Rows.Add(cruz.CodigoCruce, cruz.CodigoCruce, cruz.TipoServicio, cruz.Cliente, cruz.Caja, cruz.Remision, cruz.EstatusCobro, cruz.FechaCarga.ToString("f"), cruz.FechaEntrega.ToString("f"), cruz.LugarCarga, cruz.LugarDescarga, cruz.PrecioPesos, cruz.PrecioDolares, cruz.Intermediario, cruz.Unidad, cruz.Conductor, cruz.FechaPagoPedimento.ToString("f"), cruz.FechaVencimientoPedimento.ToString("f"), cruz.Asignada);
            }
        }

        private void dtgTablaDatos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                MySqlDataReader msdrLector = null;
                int ind = dtgTablaDatos.CurrentCell.RowIndex;
                int num = int.Parse(dtgTablaDatos.Rows[ind].Cells[0].Value.ToString());
                string strSelec = @"SELECT * FROM crucesjeffbd.tablacruces
where id_CodigoCruces = " + num;
                MySqlCommand mcmComando = new MySqlCommand(strSelec,ne.ConexionRemota);
                ne.ConexionRemota.Open();
                msdrLector = mcmComando.ExecuteReader();
                if (msdrLector.Read())
                {
                    Cruce cruceNuevo = new Cruce();
                    cruceNuevo.CodigoCruce = msdrLector.GetInt32(0);
                    cruceNuevo.TipoServicio = msdrLector.GetString(1);
                    cruceNuevo.Cliente = msdrLector.GetString(2);
                    cruceNuevo.Caja = msdrLector.GetString(3);
                    cruceNuevo.Remision = msdrLector.GetString(4);
                    cruceNuevo.EstatusCobro = msdrLector.GetString(5);
                    cruceNuevo.FechaCarga = msdrLector.GetDateTime(6);
                    cruceNuevo.FechaEntrega = msdrLector.GetDateTime(7);
                    cruceNuevo.LugarCarga = msdrLector.GetString(8);
                    cruceNuevo.LugarDescarga = msdrLector.GetString(9);
                    cruceNuevo.PrecioPesos = msdrLector.GetDouble(10);
                    cruceNuevo.PrecioDolares = msdrLector.GetDouble(11);
                    cruceNuevo.Intermediario = msdrLector.GetString(12);
                    cruceNuevo.Unidad = msdrLector.GetInt32(13);
                    cruceNuevo.Conductor = msdrLector.GetString(14);
                    cruceNuevo.FechaPagoPedimento = msdrLector.GetDateTime(15);
                    cruceNuevo.FechaVencimientoPedimento = msdrLector.GetDateTime(16);
                    cruceNuevo.Asignada = msdrLector.GetString(17);
                    scru = cruceNuevo;
                }
            }
            catch (MySqlException mex)
            {
                MessageBox.Show(mex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            finally
            {
                ne.ConexionRemota.Close();
            }
            try
            {
                dtpFechaCarga.Value = scru.FechaCarga;
                dtpFechaEntrega.Value = scru.FechaEntrega;
                dtpFechaPagoPedimento.Value = scru.FechaPagoPedimento;
                dtpFechaVencimientoPedimento.Value = scru.FechaVencimientoPedimento;
                txtAsignada.Text = scru.Asignada;
                txtCaja.Text = scru.Caja;
                txtCliente.Text = scru.Cliente;
                txtCodigoCruce.Text = scru.CodigoCruce.ToString();
                txtConductor.Text = scru.Conductor;
                txtEstatusCobro.Text = scru.EstatusCobro;
                txtIntermediario.Text = scru.Intermediario;
                txtLugarCarga.Text = scru.LugarCarga;
                txtLugarDescarga.Text = scru.LugarDescarga;
                txtPrecioDolares.Text = scru.PrecioDolares.ToString();
                txtPrecioPesos.Text = scru.PrecioPesos.ToString();
                txtRemision.Text = scru.Remision;
                txtTipoServicio.Text = scru.TipoServicio;
                txtUnidad.Text = scru.Unidad.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cruce edCruce = new Cruce();
            if (MessageBox.Show("¿Desea editar el registro?", "ELIMINACION", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                edCruce.CodigoCruce = int.Parse(txtCodigoCruce.Text);
                edCruce.TipoServicio = txtTipoServicio.Text;
                edCruce.Cliente = txtCliente.Text;
                edCruce.Caja = txtCaja.Text;
                edCruce.Remision = txtRemision.Text;
                edCruce.EstatusCobro = txtEstatusCobro.Text;
                edCruce.FechaCarga = dtpFechaCarga.Value;
                edCruce.FechaEntrega = dtpFechaEntrega.Value;
                edCruce.LugarCarga = txtLugarCarga.Text;
                edCruce.LugarDescarga = txtLugarDescarga.Text;
                edCruce.PrecioPesos = double.Parse(txtPrecioPesos.Text);
                edCruce.PrecioDolares = double.Parse(txtPrecioDolares.Text);
                edCruce.Intermediario = txtIntermediario.Text;
                edCruce.Unidad = int.Parse(txtUnidad.Text);
                edCruce.Conductor = txtConductor.Text;
                edCruce.FechaPagoPedimento = dtpFechaPagoPedimento.Value;
                edCruce.FechaVencimientoPedimento = dtpFechaVencimientoPedimento.Value;
                edCruce.Asignada = txtAsignada.Text;
                ne.Editar(edCruce, (a) => MessageBox.Show(a));
                Recargar();
                MessageBox.Show("Se edito el registro seleccionado");
            }
            else
            {
                MessageBox.Show("No se edito ningun registro");
            }
        }
    }
}
