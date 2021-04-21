using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Cruces_JEFF
{
    public partial class PantallaInicioConexionFrame : Form
    {
        public PantallaInicioConexionFrame()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            string strServidor = txtServidor.Text;
            string strPuerto = txtPuerto.Text;
            string strUsuario = txtUsuario.Text;
            string strPassword = txtPassword.Text;
            string strBaseDatos = txtBasedeDatos.Text;

            string strCadenaConexion = "Database=" + strBaseDatos + "; Data Source=" + strServidor + "; Port=" + strPuerto + "; User Id= " + strUsuario + "; Password=" + strPassword;
            MySqlConnection mscConexionBD = new MySqlConnection(strCadenaConexion);
            MySqlDataReader msdrLector = null;
            string strDatos = "";
            try
            {
                string strConsulta = "SHOW DATABASES";
                MySqlCommand mcmComando = new MySqlCommand(strConsulta);
                mcmComando.Connection = mscConexionBD;
                mscConexionBD.Open();
                msdrLector = mcmComando.ExecuteReader();
                while (msdrLector.Read())
                {
                    strDatos += msdrLector.GetString(0) + "\n";
                }
                MessageBox.Show(strDatos);
            }
            catch (MySqlException mEx)
            {
                MessageBox.Show("Error: " + mEx.Message);
            }
            finally
            {
                mscConexionBD.Close();
            }
        }
    }
}
