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
            string s1;
            try
            {
                conn.Open();
                s0 = "CREATE SCHEMA IF NOT EXISTS crucesjeffbd";
                s1 = @"use crucesjeffbd;
CREATE TABLE if not exists TablaCruces (
    id_CodigoCruces INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
    TipoServicio VARCHAR(50),
    Cliente VARCHAR(40),
    Caja VARCHAR(30),
    Remision VARCHAR(45),
    EstatusCobro VARCHAR(25),
    FechaCarga DATETIME,
    FechaEntrega DATETIME,
    LugarCarga VARCHAR(60),
    LugarDescarga VARCHAR(60),
    PrecioPesos DOUBLE,
    PrecioDolares DOUBLE,
    Intermediario VARCHAR(45),
    Unidad VARCHAR(4),
    Conductor VARCHAR(45),
    FechaPagoPedimento DATETIME,
    FechaVencimientoPedimento DATETIME,
    Asignada VARCHAR(2),
    Demora VARCHAR(120)
)";
                cmd = new MySqlCommand(s0, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                conn.Open();
                cmd = new MySqlCommand(s1, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                dele("Base de Datos Creada exitosamente");
            }
            catch (MySqlException mEx)
            {
                dele(mEx.Message);
            }
        }
        public void AnadirDemora(delegMensajeExcepcionador dele)
        {
            string connStr = "server=localhost;user=root;port=3306;password=112601";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd;
            string s0;
            
            try
            {
                conn.Open();
                s0 = @"use crucesjeffbd;
alter table tablacruces
add column Demora varchar(120);
update crucesjeffbd.tablacruces
set Demora = ''
where id_CodigoCruces > 0;
";
                cmd = new MySqlCommand(s0, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                dele("Añadida columna de demora exitosamente");
            }
            catch (MySqlException mex)
            {

                dele(mex.Message);
            }
            catch (System.Exception ex)
            {
                dele(ex.Message);
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
                string strConsulta = "use crucesjeffbd; describe tablacruces";
                MySqlCommand mcmComando = new MySqlCommand(strConsulta);
                mcmComando.Connection = ConexionRemota;
                ConexionRemota.Open();
                msdrLector = mcmComando.ExecuteReader();
                while (msdrLector.Read())
                {
                    strDatos += msdrLector.GetString(0) + " - " + msdrLector.GetString(1) + "\n";
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
        public List<Cruce> ObtenerListaCruces(delegMensajeExcepcionador dele)
        {
            List<Cruce> listaCruces = new List<Cruce>();
            MySqlDataReader msdrLector = null;
            try
            {
                string strConsulta = "SELECT * FROM crucesjeffbd.tablacruces;";
                MySqlCommand mcmComando = new MySqlCommand(strConsulta);
                mcmComando.Connection = ConexionRemota;
                ConexionRemota.Open();
                msdrLector = mcmComando.ExecuteReader();
                while (msdrLector.Read())
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
                    cruceNuevo.Unidad = msdrLector.GetString(13);
                    cruceNuevo.Conductor = msdrLector.GetString(14);
                    cruceNuevo.FechaPagoPedimento = msdrLector.GetDateTime(15);
                    cruceNuevo.FechaVencimientoPedimento = msdrLector.GetDateTime(16);
                    cruceNuevo.Asignada = msdrLector.GetString(17);
                    cruceNuevo.Demora = msdrLector.GetString(18);
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
        public List<Cruce> ObtenerListaCrucesBuscados(delegMensajeExcepcionador dele, string b)
        {
            List<Cruce> listaCruces = new List<Cruce>();
            MySqlDataReader msdrLector = null;
            try
            {
                string strConsulta = "SELECT * FROM crucesjeffbd.tablacruces"
                + "\n where " +
                $"id_CodigoCruces like '%{b}%' " +
                $"or TipoServicio like '%{b}%' " +
                $"or Cliente like '%{b}%' " +
                $"or Caja like '%{b}%' " +
                $"or Remision like '%{b}%' " +
                $"or EstatusCobro like '%{b}%' " +
                $"or FechaCarga like '%{b}%' " +
                $"or FechaEntrega like '%{b}%' " +
                $"or LugarCarga like '%{b}%' " +
                $"or LugarDescarga like '%{b}%' " +
                $"or PrecioPesos like '%{b}%' " +
                $"or PrecioDolares like '%{b}%' " +
                $"or Intermediario like '%{b}%' " +
                $"or Unidad like '%{b}%' " +
                $"or Conductor like '%{b}%' " +
                $"or FechaPagoPedimento like '%{b}%' " +
                $"or FechaVencimientoPedimento like '%{b}%' " +
                $"or Asignada like '%{b}%' " +
                $"or Demora like '%{b}%' " +
                "ORDER BY FechaCarga ASC";
                MySqlCommand mcmComando = new MySqlCommand(strConsulta);
                mcmComando.Connection = ConexionRemota;
                ConexionRemota.Open();
                mcmComando.Prepare();
                msdrLector = mcmComando.ExecuteReader();
                while (msdrLector.Read())
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
                    cruceNuevo.Unidad = msdrLector.GetString(13);
                    cruceNuevo.Conductor = msdrLector.GetString(14);
                    cruceNuevo.FechaPagoPedimento = msdrLector.GetDateTime(15);
                    cruceNuevo.FechaVencimientoPedimento = msdrLector.GetDateTime(16);
                    cruceNuevo.Asignada = msdrLector.GetString(17);
                    cruceNuevo.Demora = msdrLector.GetString(18);
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
        public List<Cruce> ObtenerListaCrucesBuscados(delegMensajeExcepcionador dele, string[] b)
        {
            List<Cruce> listaCruces = new List<Cruce>();
            MySqlDataReader msdrLector = null;
            try
            {
                string strConsulta = "SELECT * FROM crucesjeffbd.tablacruces"
                + "\n where " +
                $"id_CodigoCruces like '%{b[0]}%' " +
                $"and TipoServicio like '%{b[1]}%' " +
                $"and Cliente like '%{b[12]}%' " +
                $"and Caja like '%{b[2]}%' " +
                $"and Remision like '%{b[3]}%' " +
                $"and EstatusCobro like '%{b[4]}%' " +
                $"and FechaCarga > '{b[5]}' " +
                $"and FechaEntrega > '{b[6]}' " +
                $"and LugarCarga like '%{b[7]}%' " +
                $"and LugarDescarga like '%{b[8]}%' " +
                $"and PrecioPesos like '%{b[9]}%' " +
                $"and PrecioDolares like '%{b[10]}%' " +
                $"and Intermediario like '%{b[11]}%' " +
                $"and Unidad like '%{b[14]}%' " +
                $"and Conductor like '%{b[15]}%' " +
                $"and FechaPagoPedimento > '{b[16]}' " +
                $"and FechaVencimientoPedimento > '{b[17]}' " +
                $"and Asignada like '%{b[13]}%' " +
                $"and Demora like '%{b[18]}%' " +
                "ORDER BY FechaCarga ASC";
                MySqlCommand mcmComando = new MySqlCommand(strConsulta);
                mcmComando.Connection = ConexionRemota;
                ConexionRemota.Open();
                mcmComando.Prepare();
                msdrLector = mcmComando.ExecuteReader();
                while (msdrLector.Read())
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
                    cruceNuevo.Unidad = msdrLector.GetString(13);
                    cruceNuevo.Conductor = msdrLector.GetString(14);
                    cruceNuevo.FechaPagoPedimento = msdrLector.GetDateTime(15);
                    cruceNuevo.FechaVencimientoPedimento = msdrLector.GetDateTime(16);
                    cruceNuevo.Asignada = msdrLector.GetString(17);
                    cruceNuevo.Demora = msdrLector.GetString(18);
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
        public Cruce AgregarCruce(Cruce agCruce, delegMensajeExcepcionador dele)
        {

            try
            {
                string strAdicion = $"INSERT INTO crucesjeffbd.tablacruces(id_CodigoCruces,TipoServicio,Cliente,Caja,Remision,EstatusCobro,FechaCarga,FechaEntrega,LugarCarga,LugarDescarga,PrecioPesos,PrecioDolares,Intermediario,Unidad,Conductor,FechaPagoPedimento,FechaVencimientoPedimento,Asignada,Demora)" +
                $"values(null," +
                $"'{agCruce.TipoServicio}'," +
                $"'{agCruce.Cliente}'," +
                $"'{agCruce.Caja}'," +
                $"'{agCruce.Remision}'," +
                $"'{agCruce.EstatusCobro}'," +
                $"'{agCruce.FechaCarga.ToString("yyyy-MM-dd HH:mm:ss")}'," +
                $"'{agCruce.FechaEntrega.ToString("yyyy-MM-dd HH:mm:ss")}'," +
                $"'{agCruce.LugarCarga}'," +
                $"'{agCruce.LugarDescarga}'," +
                $"'{agCruce.PrecioPesos}'," +
                $"'{agCruce.PrecioDolares}'," +
                $"'{agCruce.Intermediario}'," +
                $"'{agCruce.Unidad}'," +
                $"'{agCruce.Conductor}'," +
                $"'{agCruce.FechaPagoPedimento.ToString("yyyy-MM-dd HH:mm:ss")}'," +
                $"'{agCruce.FechaVencimientoPedimento.ToString("yyyy-MM-dd HH:mm:ss")}'," +
                $"'{agCruce.Asignada}'," +
                $"'{agCruce.Demora}')";
                MySqlCommand mcmComando = new MySqlCommand(strAdicion);
                mcmComando.Connection = ConexionRemota;
                ConexionRemota.Open();
                mcmComando.ExecuteNonQuery();
            }
            catch (MySqlException mex)
            {
                dele(mex.Message);

            }
            finally
            {
                ConexionRemota.Close();
            }
            return agCruce;
        }
        public void Eliminar(Cruce elicruce, delegMensajeExcepcionador dele)
        {
            string strEliminar = @"delete from crucesjeffbd.tablacruces where id_CodigoCruces = " +
                elicruce.CodigoCruce;
            try
            {
                MySqlCommand mcmComando = new MySqlCommand(strEliminar);
                mcmComando.Connection = ConexionRemota;
                ConexionRemota.Open();
                mcmComando.ExecuteNonQuery();
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
        public void Editar(Cruce edcruce, delegMensajeExcepcionador dele)
        {
            string strEditar = $"UPDATE crucesjeffbd.tablacruces set TipoServicio = '{edcruce.TipoServicio}'," +
            $"Cliente = '{edcruce.Cliente}'," +
            $"Caja = '{edcruce.Caja}'," +
            $"Remision = '{edcruce.Remision}'," +
            $"EstatusCobro = '{edcruce.EstatusCobro}'," +
            $"FechaCarga = '{edcruce.FechaCarga.ToString("yyyy-MM-dd HH:mm:ss")}'," +
            $"FechaEntrega = '{edcruce.FechaEntrega.ToString("yyyy-MM-dd HH:mm:ss")}'," +
            $"LugarCarga = '{edcruce.LugarCarga}'," +
            $"LugarDescarga = '{edcruce.LugarDescarga}'," +
            $"PrecioPesos = '{edcruce.PrecioPesos}'," +
            $"PrecioDolares = '{edcruce.PrecioDolares}'," +
            $"Intermediario = '{edcruce.Intermediario}'," +
            $"Unidad = '{edcruce.Unidad}'," +
            $"Conductor = '{edcruce.Conductor}'," +
            $"FechaPagoPedimento = '{edcruce.FechaPagoPedimento.ToString("yyyy-MM-dd HH:mm:ss")}'," +
            $"FechaVencimientoPedimento = '{edcruce.FechaVencimientoPedimento.ToString("yyyy-MM-dd HH:mm:ss")}'," +
            $"Asignada = '{edcruce.Asignada}'," +
            $"Demora = '{edcruce.Demora}' " +
            $"where id_CodigoCruces = '{edcruce.CodigoCruce}'";
            try
            {
                MySqlCommand mcmComando = new MySqlCommand(strEditar);
                mcmComando.Connection = ConexionRemota;
                ConexionRemota.Open();
                mcmComando.ExecuteNonQuery();
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
        public void EliminarBaseDeDatos(delegMensajeExcepcionador dele)
        {
            //server=localhost;user=root;port=3306;password=******
            string connStr = "server=localhost;user=root;port=3306;password=112601";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd;
            
            string s1;
            try
            {

                //cmd = new MySqlCommand(s0, conn);
                //cmd.ExecuteNonQuery();
                //conn.Close();
                s1 = "drop schema if exists crucesjeffbd";
                conn.Open();
                cmd = new MySqlCommand(s1, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                dele("Base de Datos Creada exitosamente");
            }
            catch (System.Exception ex)
            {
                dele(ex.Message);

            }
        }
        public List<Cruce> BuscarPorFecha(delegMensajeExcepcionador dele, string b)
        {

            List<Cruce> listaCruces = new List<Cruce>();
            MySqlDataReader msdrLector = null;
            try
            {
                string strConsulta = "SELECT * FROM crucesjeffbd.tablacruces" + "\n where " + $"FechaCarga >= '{b}' ORDER BY FechaCarga ASC";
                MySqlCommand mcmComando = new MySqlCommand(strConsulta);
                mcmComando.Connection = ConexionRemota;
                ConexionRemota.Open();
                msdrLector = mcmComando.ExecuteReader();
                while (msdrLector.Read())
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
                    cruceNuevo.Unidad = msdrLector.GetString(13);
                    cruceNuevo.Conductor = msdrLector.GetString(14);
                    cruceNuevo.FechaPagoPedimento = msdrLector.GetDateTime(15);
                    cruceNuevo.FechaVencimientoPedimento = msdrLector.GetDateTime(16);
                    cruceNuevo.Asignada = msdrLector.GetString(17);
                    cruceNuevo.Demora = msdrLector.GetString(18);
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
        public List<Cruce> OrdenarPorFechaCarga(delegMensajeExcepcionador dele)
        {

            List<Cruce> listaCruces = new List<Cruce>();
            MySqlDataReader msdrLector = null;
            try
            {
                string strConsulta = "SELECT * FROM crucesjeffbd.tablacruces ORDER BY FechaCarga ASC";
                MySqlCommand mcmComando = new MySqlCommand(strConsulta);
                mcmComando.Connection = ConexionRemota;
                ConexionRemota.Open();
                msdrLector = mcmComando.ExecuteReader();
                while (msdrLector.Read())
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
                    cruceNuevo.Unidad = msdrLector.GetString(13);
                    cruceNuevo.Conductor = msdrLector.GetString(14);
                    cruceNuevo.FechaPagoPedimento = msdrLector.GetDateTime(15);
                    cruceNuevo.FechaVencimientoPedimento = msdrLector.GetDateTime(16);
                    cruceNuevo.Asignada = msdrLector.GetString(17);
                    cruceNuevo.Demora = msdrLector.GetString(18);
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
        public Cruce BuscarCruce(delegMensajeExcepcionador dele, int id)
        {
            MySqlDataReader msdrLector = null;
            string strConsulta = "select * from crucesjeffbd.tablacruces" +
            $"\nwhere id_CodigoCruces like '%{id}%'";
            Cruce cruceNuevo = new Cruce();
            try
            {
                MySqlCommand mcmCommand = new MySqlCommand(strConsulta, ConexionRemota);
                ConexionRemota.Open();
                MySqlDataReader msrLector = mcmCommand.ExecuteReader();
                
                if (msrLector.Read())
                {
                    
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
                    cruceNuevo.Unidad = msdrLector.GetString(13);
                    cruceNuevo.Conductor = msdrLector.GetString(14);
                    cruceNuevo.FechaPagoPedimento = msdrLector.GetDateTime(15);
                    cruceNuevo.FechaVencimientoPedimento = msdrLector.GetDateTime(16);
                    cruceNuevo.Asignada = msdrLector.GetString(17);
                    cruceNuevo.Demora = msdrLector.GetString(18);
                    
                }
            }
            catch (System.Exception e)
            {

                dele(e.Message);
            }
            finally
            {
                ConexionRemota.Close();
            }
            return cruceNuevo;
        }
    }
}
