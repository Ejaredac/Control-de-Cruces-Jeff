using MySql.Data.MySqlClient;
using System.Collections.Generic;
namespace Formulario_Cruces_JEFF
{
    public class ConexionBDJeff
    {
        private string _strServidor;

        public string Servidor
        {
            get { return _strServidor; }
            set { _strServidor = value; }
        }
        private string _strDatabase;

        public string Database
        {
            get { return _strDatabase; }
            set { _strDatabase = value; }
        }
        private string _strPort;

        public string Port
        {
            get { return _strPort; }
            set { _strPort = value; }
        }

        private MySqlConnection _conConexionRemota;

        public MySqlConnection ConexionRemota
        {
            get { return _conConexionRemota; }
            set { _conConexionRemota = value; }
        }
        private string _strUsuario;

        public string Usuario
        {
            get { return _strUsuario; }
            set { _strUsuario = value; }
        }
        private string _strContrasena;

        public string Contrasena
        {
            get { return _strContrasena; }
            set { _strContrasena = value; }
        }




        public delegate void delegMensajeExcepcionador(string me);
        /// <summary>
        /// Metodo Para crear una base de datos en el equipo local
        /// </summary>
        /// <param name="dele">
        /// Delegado para el uso de mensajes de texto en otros componentes.
        /// </param>
        public void CrearBaseDatosLocal(delegMensajeExcepcionador dele)
        {
            //server=localhost;user=root;port=3306;password=******
            string connStr = "server=localhost;user=root;port=3306;password=112601";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd;
            string s0;
            try
            {
                conn.Open();
                s0 = "CREATE SCHEMA IF NOT EXISTS crucesjeffbd";
                cmd = new MySqlCommand(s0, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                dele("Base de Datos Creada exitosamente");
            }
            catch (MySqlException mEx)
            {
                dele(mEx.Message);
            }
        }

        public void EstablecerConexionServidorRemoto(string strUser, string strPort, string strPassword, string strSource, delegMensajeExcepcionador dele, string strBDA)
        {

            string connstr = "database=" + strBDA + ";user=" + strUser + ";port=" + strPort + ";password=" + strPassword + ";datasource=" + strSource + ";";
            ConexionRemota = new MySqlConnection(connstr);
            MySqlDataReader msdrLector = null;
            string strDatos = "";
            try
            {
                string strConsulta = "SHOW DATABASES";
                MySqlCommand mcmComando = new MySqlCommand(strConsulta);
                mcmComando.Connection = ConexionRemota;
                ConexionRemota.Open();
                msdrLector = mcmComando.ExecuteReader();
                while (msdrLector.Read())
                {
                    strDatos += msdrLector.GetString(0) + "\n";
                }

                dele(strDatos);
                //ConexionRemota = ConexionRemota;
            }
            catch (MySqlException mex)
            {

                dele(mex.Message);
            }
            finally
            {
                ConexionRemota.Close();
            }

        }
        public List<Cruces> ObtenerListaCruces(delegMensajeExcepcionador dele)
        {
            List<Cruces> listaCruces = new List<Cruces>();
            MySqlDataReader msdrLector = null;
            string strDatos = "";
            try
            {
                string strConsulta = "SELECT * FROM crucesjeffbd.tablacruces;";
                MySqlCommand mcmComando = new MySqlCommand(strConsulta);
                mcmComando.Connection = ConexionRemota;
                ConexionRemota.Open();
                msdrLector = mcmComando.ExecuteReader();
                while (msdrLector.Read())
                {
                    Cruces cruceNuevo = new Cruces();
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
                    listaCruces.Add(cruceNuevo);
                }
                return listaCruces;
            }
            catch (MySqlException mex)
            {

                dele(mex.Message);
            }
            finally
            {
                ConexionRemota.Close();

            }
            return listaCruces;
        }
    }
}
