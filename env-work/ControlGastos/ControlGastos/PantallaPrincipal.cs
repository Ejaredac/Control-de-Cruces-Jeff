using MySql.Data.MySqlClient;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
namespace ControlGastos
{
    public partial class PantallaPrincipal : Form
    {
        ConexionBDJeff ne = new ConexionBDJeff();
        Cruce scru;
        Gasto sgasto;
        List<Cruce> listaCruces = new List<Cruce>();
        List<Gasto> listaGastos = new List<Gasto>();
        string strEstado = "PENDIENTE";
        public PantallaPrincipal()
        {
            InitializeComponent();

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
            listaGastos = ne.ObtenerListaGastos((s) => MessageBox.Show(s));
            dtgTablaDatos.Rows.Clear();
            int i = 1;
            foreach (Gasto gast in listaGastos)
            {
                dtgTablaDatos.Rows.Add(gast.IdGasto,i, gast.TipoGasto, gast.Cantidad,gast.Impuestos, gast.NumeroFactura, gast.FechaCompra, gast.Garantia, gast.Demora, gast.Unidad);
                i++;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea agregar un nuevo cruce?", "ADICION", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Gasto nuevoGasto = new Gasto();
                    AgregarPag agre = new AgregarPag(ref nuevoGasto, ne);
                    if (agre.ShowDialog() == DialogResult.OK)
                    {
                        ne.AgregarGasto(nuevoGasto, (s) => MessageBox.Show(s));
                        Recargar();
                        MessageBox.Show("Se ha agregado un nuevo cruce");
                    }
                    else
                    {
                        MessageBox.Show("No se agrega el nuevo cruce");
                    }
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
            VaciarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea elminar el registro?", "ELIMINACION", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Cont log = new Cont();
                ContrasenaPag con = new ContrasenaPag(ref log);
                con.ShowDialog();
                if (log.Logrado)
                {
                    ne.EliminarGasto(sgasto, (a) => MessageBox.Show(a));
                    Recargar();
                    MessageBox.Show("Se elimino el registro seleccionado");
                }
                else
                {
                    MessageBox.Show("No se accedio correctamente con la contraseña");
                }
            }
            else
            {
                MessageBox.Show("No se elimino ningun registro");
            }
            VaciarCampos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string[] busqueda = new string[0];
            Gasto gastoBusqueda = new Gasto();
            BuscarPagina bscPag = new BuscarPagina(ref gastoBusqueda);
            bscPag.ShowDialog();
            listaGastos = ne.ObtenerListaGastosBuscados((s) => MessageBox.Show(s), gastoBusqueda);
            dtgTablaDatos.Rows.Clear();
            int i = 1;
            foreach (Gasto gast in listaGastos)
            {
                dtgTablaDatos.Rows.Add(gast.IdGasto, i, gast.TipoGasto, gast.Cantidad,gast.Impuestos, gast.NumeroFactura, gast.FechaCompra, gast.Garantia, gast.Demora, gast.Unidad);
                i++;
            }
        }

        private void dtgTablaDatos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                MySqlDataReader msdrLector = null;
                int ind = dtgTablaDatos.CurrentCell.RowIndex;
                int num = int.Parse(dtgTablaDatos.Rows[ind].Cells[0].Value.ToString());
                string strSelec = @"SELECT * FROM crucesjeffbd.tablagastos
                    where id_gasto = " + num.ToString();
                MySqlCommand mcmComando = new MySqlCommand(strSelec, ne.ConexionRemota);
                ne.ConexionRemota.Open();
                msdrLector = mcmComando.ExecuteReader();
                if (msdrLector.Read())
                {
                    Gasto gasto = new Gasto();
                    gasto.IdGasto = msdrLector.GetInt32("id_gasto");
                    gasto.Cantidad = msdrLector.GetDouble("cantidad");
                    gasto.NumeroFactura = msdrLector.GetString("numero_factura");
                    gasto.FechaCompra = msdrLector.GetDateTime("fecha_compra");
                    gasto.Garantia= msdrLector.GetString("garantia");
                    gasto.Demora = msdrLector.GetString("demora");
                    gasto.NumeroFactura = msdrLector.GetString("numero_factura");
                    gasto.Unidad = msdrLector.GetString("unidad");
                    if(gasto != null)
                    sgasto = gasto;
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
                dtpFechaCompra.Value = sgasto.FechaCompra;
                txtGarantia.Text = sgasto.Garantia;
                txtCodigoGasto.Text = sgasto.IdGasto.ToString();
                txtCantidad.Text = sgasto.Cantidad.ToString();
                txtImpuestos.Text = sgasto.Impuestos.ToString();
                txtNoFactura.Text = sgasto.NumeroFactura;
                txtTipoGasto.Text = sgasto.TipoGasto;
                cboUnidades.Text = sgasto.Unidad;
                rtxtDemora.Text = sgasto.Unidad;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Gasto edGasto = new Gasto();
            if (!(txtCodigoGasto.Text == null || txtCodigoGasto.Text == ""))
            {
                if (MessageBox.Show("¿Desea editar el registro?", "EDITAR", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    EditarPag editpa = new EditarPag(ref sgasto, ne);

                    if (editpa.ShowDialog() == DialogResult.OK)
                    {
                        ne.EditarGasto(sgasto, (a) => MessageBox.Show(a));
                        Recargar();
                        MessageBox.Show("Se edito el registro seleccionado");
                    }
                    else
                    {
                        MessageBox.Show("No se edito el registro");
                    }
                }
                else
                {
                    MessageBox.Show("No se edito ningun registro");
                }
            }
            else
            {
                MessageBox.Show("No se selecciono ningun registro");
            }
            VaciarCampos();
        }

        private void eliminarBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }
        void VaciarCampos()
        {
            foreach (Control t in grpCampoDatos.Controls)
            {

                if (t is TextBox)
                {
                    t.Text = "";

                }
                if (t is DateTimePicker)
                {

                }
            }
            dtpFechaCompra.Value = DateTime.Now;
            rtxtDemora.Text = "";
            cboUnidades.Text = "";
            txtCantidad.Text = "0";
            txtImpuestos.Text = "0";
        }

        private void txtPrecioPesos_TextChanged(object sender, EventArgs e)
        {
            txtCantidad.Text = "0";

        }

        private void txtPrecioDolares_TextChanged(object sender, EventArgs e)
        {
            txtImpuestos.Text = "0";
        }

        private void obtenerDireccionDeEsteEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La direccion de esta maquina es: " + ObtenerIP());
        }

        public static string ObtenerIP()
        {
            string hostName = Dns.GetHostName();
            string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            return myIP;
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {

            ConexionRemotaFormulario entradaCon = new ConexionRemotaFormulario(ref ne);

            entradaCon.ShowDialog();

            ne.EstablecerConexionServidorRemoto(ne.Usuario, ne.Port, ne.Contrasena, ne.Servidor, (s) => MessageBox.Show(s), ne.Database);
        }

        private void btnBuscarFechaCarga_Click(object sender, EventArgs e)
        {

        }

        private void btnOrdenarFechaCarga_Click(object sender, EventArgs e)
        {
            listaGastos = ne.OrdenarPorFechaCompraGasto((s) => MessageBox.Show(s));
            dtgTablaDatos.Rows.Clear();
            int i = 1;
            foreach (Gasto gast in listaGastos)
            {
                dtgTablaDatos.Rows.Add(gast.IdGasto, i, gast.TipoGasto, gast.Cantidad,gast.Impuestos, gast.NumeroFactura, gast.FechaCompra, gast.Garantia, gast.Demora, gast.Unidad);
                i++;
            }
        }

        private void grpTablaDeDatos_Enter(object sender, EventArgs e)
        {

        }

        private void btnVaciarCampos_Click(object sender, EventArgs e)
        {
            VaciarCampos();
        }

        private void añadirColumnaDemoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ne.AnadirDemora((s) => MessageBox.Show(s));
        }

        private void chkEstado_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void exportarReporteAExcelxlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Va a exportar los datos de la tabla a un archivo de Excel", "EXPORTACION", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                try
                {


                    string path = "C:\\Reporte.xlsx";
                    SaveFileDialog folderBrowser = new SaveFileDialog();
                    folderBrowser.ValidateNames = false;
                    folderBrowser.CheckFileExists = false;
                    folderBrowser.CheckPathExists = true;
                    folderBrowser.FileName = "Reporte.xlsx";
                    if (folderBrowser.ShowDialog() == DialogResult.OK)
                    {
                        path = Path.GetFullPath(folderBrowser.FileName);
                    }

                    SLDocument sLDocument = new SLDocument();

                    DataTable data = new DataTable();
                    //Columnas
                    data.Columns.Add("Codigo de Gasto", typeof(int));
                    data.Columns.Add("Tipo de Gasto", typeof(string));
                    data.Columns.Add("Cantidad", typeof(double));
                    data.Columns.Add("Impuestos", typeof(double));
                    data.Columns.Add("Numero Factura", typeof(string));
                    data.Columns.Add("Fecha de Compra", typeof(string));
                    data.Columns.Add("Demora", typeof(string));
                    data.Columns.Add("Garantia", typeof(string));

                    //registros
                    foreach (Gasto gas in listaGastos)
                    {
                        data.Rows.Add(gas.IdGasto,
                            gas.TipoGasto, gas.Cantidad,
                            gas.Impuestos, gas.NumeroFactura,
                            gas.FechaCompra.ToString("g"),gas.Unidad,
                            gas.Demora, gas.Garantia);
                    }
                    sLDocument.ImportDataTable(1, 1, data, true);
                    sLDocument.SaveAs(path);
                    MessageBox.Show("Se exportó el archivo correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No se exportó ningun archivo");
            }
        }

        private void lblCodigoCruce_Click(object sender, EventArgs e)
        {

        }
    }
}
