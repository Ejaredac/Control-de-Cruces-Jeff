using System;
namespace Formulario_Cruces_JEFF
{
    public class Cruce
    {
        private int _intCodigoCruce;

        public int CodigoCruce
        {
            get { return _intCodigoCruce; }
            set { _intCodigoCruce = value; }
        }

        private string _strTipoServicio;

        public string TipoServicio
        {
            get { return _strTipoServicio; }
            set
            {
                _strTipoServicio = value;
            }
        }
        private string _strCaja;

        public string Caja
        {
            get { return _strCaja; }
            set { _strCaja = value; }
        }

        private string _strRemision;

        public string Remision
        {
            get { return _strRemision; }
            set { _strRemision = value; }
        }

        private string _strEstatusCobro;

        public string EstatusCobro
        {
            get { return _strEstatusCobro; }
            set { _strEstatusCobro = value; }
        }

        private DateTime _dtmFechaCarga;

        public DateTime FechaCarga
        {
            get { return _dtmFechaCarga; }
            set { _dtmFechaCarga = value; }
        }
        private DateTime _dtmFechaEntrega;

        public DateTime FechaEntrega
        {
            get { return _dtmFechaEntrega; }
            set { _dtmFechaEntrega = value; }
        }

        private string _strLugarCarga;

        public string LugarCarga
        {
            get { return _strLugarCarga; }
            set { _strLugarCarga = value; }
        }

        private string _strLugarDescarga;

        public string LugarDescarga
        {
            get { return _strLugarDescarga; }
            set { _strLugarDescarga = value; }
        }
        private double _dblPrecioPesos;

        public double PrecioPesos
        {
            get { return _dblPrecioPesos; }
            set { _dblPrecioPesos = value; }
        }

        private double _dblPrecioDolares;

        public double PrecioDolares
        {
            get { return _dblPrecioDolares; }
            set { _dblPrecioDolares = value; }
        }
        private string _strIntermediario;

        public string Intermediario
        {
            get { return _strIntermediario; }
            set { _strIntermediario = value; }
        }
        private int _intUnidad;

        public int Unidad
        {
            get { return _intUnidad; }
            set { _intUnidad = value; }
        }
        private string _strConductor;

        public string Conductor
        {
            get { return _strConductor; }
            set { _strConductor = value; }
        }
        private DateTime _dtmFechaPagoPedimento;

        public DateTime FechaPagoPedimento
        {
            get { return _dtmFechaPagoPedimento; }
            set { _dtmFechaPagoPedimento = value; }
        }
        private DateTime _dtmFechaVencimientoPedimento;

        public DateTime FechaVencimientoPedimento
        {
            get { return _dtmFechaVencimientoPedimento; }
            set { _dtmFechaVencimientoPedimento = value; }
        }
        
        private string _strAsignada;

        public string Asignada
        {
            get { return _strAsignada; }
            set { _strAsignada = value; }
        }
        private string _strCliente;

        public string Cliente
        {
            get { return _strCliente; }
            set { _strCliente = value; }
        }

    }
}
