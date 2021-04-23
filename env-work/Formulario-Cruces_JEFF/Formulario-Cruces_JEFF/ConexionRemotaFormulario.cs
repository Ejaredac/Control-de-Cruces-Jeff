using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_Cruces_JEFF
{
    public partial class ConexionRemotaFormulario : Form
    {
        private ConexionBDJeff cbdjConexionFromularioEntrada = new ConexionBDJeff();

        public ConexionBDJeff ConexionFormularioEntrada 
        {
            get { return cbdjConexionFromularioEntrada; }
            set { cbdjConexionFromularioEntrada = value; }
        }
        private ConexionBDJeff cbdjConexionRetornadora = new ConexionBDJeff();

        public ConexionBDJeff ConexionRetornadora
        {
            get { return cbdjConexionRetornadora; }
            set { cbdjConexionRetornadora = value; }
        }

        public ConexionRemotaFormulario()
        {
            InitializeComponent();
        }
        public ConexionRemotaFormulario(ref ConexionBDJeff conexion)
        {
            InitializeComponent();
            conexion = ConexionFormularioEntrada;
        }

        ~ConexionRemotaFormulario()
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ConexionFormularioEntrada.Servidor = txtServidorRuta.Text;
            ConexionFormularioEntrada.Database = txtBDA.Text;
            ConexionFormularioEntrada.Port = txtPuerto.Text;
            ConexionFormularioEntrada.Contrasena = txtContraseña.Text;
            ConexionFormularioEntrada.Usuario = txtUsuario.Text;
            ConexionRetornadora = ConexionFormularioEntrada;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ConexionRetornadora = ConexionFormularioEntrada;
            this.Close();
        }
    }
}
