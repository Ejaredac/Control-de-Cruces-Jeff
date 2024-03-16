using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlGastos
{
    public partial class ContrasenaPag : Form
    {
        public ContrasenaPag()
        {
            InitializeComponent();
        }
        Cont oal = new Cont();
        public ContrasenaPag(ref Cont alo)
        {
            InitializeComponent();
            alo = oal;
            
        }
        int intCantVeces = 0;
        string strContrasena = "132426";
        private void btnContrasenaAceptar_Click(object sender, EventArgs e)
        {
            if (txtContrasena.Text == strContrasena)
            {
                oal.Logrado = true;

                this.Close();
            }
            else if (txtContrasena.Text != strContrasena && intCantVeces >= 3)
            {
                oal.Logrado = false;
                this.Close();
            }
            else
            {
                MessageBox.Show("Intenta nuevamente");
                intCantVeces++;
            }
            
        }
    }
    public class Cont
    {
        private string _strContrasena;

        public string Contrasena
        {
            get { return _strContrasena; }
            set { _strContrasena = value; }
        }
        private bool _blnLogrado;

        public bool Logrado
        {
            get { return _blnLogrado; }
            set { _blnLogrado = value; }
        }

    }
}
