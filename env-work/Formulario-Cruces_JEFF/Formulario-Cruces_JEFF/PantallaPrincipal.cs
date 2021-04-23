using System;
using System.Windows.Forms;
using System.Collections.Generic;
namespace Formulario_Cruces_JEFF
{
    public partial class PantallaPrincipal : Form
    {
        ConexionBDJeff ne = new ConexionBDJeff();
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
            List<Cruces> lista = ne.ObtenerListaCruces((s)=>MessageBox.Show(s));
            dtgTablaDatos.Rows.Clear();
            foreach (Cruces cruz in lista)
            {
                dtgTablaDatos.Rows.Add(cruz.CodigoCruce,cruz.CodigoCruce, cruz.TipoServicio, cruz.Cliente,cruz.Caja ,cruz.Remision, cruz.EstatusCobro, cruz.FechaCarga, cruz.FechaEntrega, cruz.LugarCarga, cruz.LugarDescarga, cruz.PrecioPesos, cruz.PrecioDolares, cruz.Intermediario, cruz.Unidad, cruz.Conductor, cruz.FechaPagoPedimento, cruz.FechaVencimientoPedimento, cruz.Asignada);
            }
        }
    }
}
