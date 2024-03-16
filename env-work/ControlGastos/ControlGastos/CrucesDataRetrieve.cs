using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlGastos
{
    public abstract class CrucesDataRetrieve : IConexion
    {
        public abstract List<Cruce> ObtenerCruces();
        public abstract List<Cruce>  ObtenerCrucesBusqueda(Cruce cruceBusqueda);

        public abstract List<Cruce> ObtenerCrucesBusqueda(string[] busqueda);

        public abstract void InsertarCruce(Cruce cruce);
        public abstract void ActualizarCruce(Cruce cruce);
        public abstract void EliminarCruce(Cruce cruce);

        public abstract void Conectar();


        public abstract void Desconectar();

        public abstract void EstablecerConexion();

        public abstract List<string> ConsultaAutocompletar(DelegMensajeExcepcionador dele, string colm, string busc);

        public abstract string Servidor { get; set; }
        public abstract string Database { get; set; }
        public abstract string Port { get; set; }
        public abstract string Usuario { get; set; }
        public abstract string Contrasena { get; set; }

        private DelegMensajeExcepcionador _delegMensaje;

        public DelegMensajeExcepcionador DelegMensaje
        {
            get { return _delegMensaje; }
            set { _delegMensaje = value; }
        }
        public delegate void DelegMensajeExcepcionador(string me);
    }
}
