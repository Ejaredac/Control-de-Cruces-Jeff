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
    public partial class RegistroConductoresPag : Form
    {
        private ConexionBDJeff _cnBD;

        public ConexionBDJeff BD
        {
            get { return _cnBD; }
            set { _cnBD = value; }
        }

        public RegistroConductoresPag()
        {
            InitializeComponent();
        }
        public RegistroConductoresPag(ref ConexionBDJeff conex)
        {
            InitializeComponent();
            BD = conex;
        }
    }
}
