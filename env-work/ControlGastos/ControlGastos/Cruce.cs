using System;
using System.ComponentModel;
namespace ControlGastos
{
    public class Cruce : INotifyPropertyChanged
    {
        private int _intCodigoCruce;

        public int CodigoCruce
        {
            get { return _intCodigoCruce; }
            set
            {
                if (value != _intCodigoCruce)
                {
                    _intCodigoCruce = value;
                    OnPropertyChanged("CodigoCruce");
                }
            }
        }

        private string _strTipoServicio;

        public string TipoServicio
        {
            get { return _strTipoServicio; }
            set
            {
                if (value != _strTipoServicio)
                {
                    _strTipoServicio = value;
                    OnPropertyChanged("TipoServicio");
                }
            }
        }
        private string _strCaja;

        public string Caja
        {
            get { return _strCaja; }
            set
            {
                if (value != _strCaja)
                {
                    _strCaja = value;
                    OnPropertyChanged("Caja");
                }
            }
        }

        private string _strRemision;

        public string Remision
        {
            get { return _strRemision; }
            set
            {
                if (value != _strRemision)
                {
                    _strRemision = value;
                    OnPropertyChanged("Remision");
                }
            }
        }

        private string _strEstatusCobro;

        public string EstatusCobro
        {
            get { return _strEstatusCobro; }
            set
            {
                if (value != _strEstatusCobro)
                {
                    _strEstatusCobro = value;
                    OnPropertyChanged("EstatusCobro");
                }
            }
        }

        private DateTime _dtmFechaCarga;

        public DateTime FechaCarga
        {
            get { return _dtmFechaCarga; }
            set
            {

                if (value != _dtmFechaCarga)
                {
                    _dtmFechaCarga = value;
                    OnPropertyChanged("FechaCarga");
                }
            }
        }
        private DateTime _dtmFechaEntrega;

        public DateTime FechaEntrega
        {
            get { return _dtmFechaEntrega; }
            set
            {
                if (value != _dtmFechaEntrega)
                {
                    _dtmFechaEntrega = value;
                    OnPropertyChanged("FechaEntrega");
                }
            }
        }

        private string _strLugarCarga;

        public string LugarCarga
        {
            get { return _strLugarCarga; }
            set
            {
                if (value != _strLugarCarga)
                {
                    _strLugarCarga = value;
                    OnPropertyChanged("LugarCarga");
                }
            }
        }

        private string _strLugarDescarga;

        public string LugarDescarga
        {
            get { return _strLugarDescarga; }
            set
            {
                if (value != _strLugarDescarga)
                {
                    _strLugarDescarga = value;
                    OnPropertyChanged("LugarDescarga");
                }
            }
        }
        private double _dblPrecioPesos;

        public double PrecioPesos
        {
            get { return _dblPrecioPesos; }
            set
            {
                if (value != _dblPrecioPesos)
                {
                    _dblPrecioPesos = value;
                    OnPropertyChanged("PrecioPesos");
                }
            }
        }

        private double _dblPrecioDolares;

        public double PrecioDolares
        {
            get { return _dblPrecioDolares; }
            set
            {
                if (value != _dblPrecioDolares)
                {
                    _dblPrecioDolares = value;
                    OnPropertyChanged("PrecioDolares");
                }
            }
        }
        private string _strIntermediario;

        public string Intermediario
        {
            get { return _strIntermediario; }
            set
            {
                if (value != _strIntermediario)
                {
                    _strIntermediario = value;
                    OnPropertyChanged("Intermediario");
                }
            }
        }
        private string _strUnidad;

        public string Unidad
        {
            get { return _strUnidad; }
            set
            {

                if (value != _strUnidad)
                {
                    _strUnidad = value;
                    OnPropertyChanged("Unidad");
                }
            }
        }
        private string _strConductor;

        public string Conductor
        {
            get { return _strConductor; }
            set
            {
                if (value != _strConductor)
                {
                    _strConductor = value;
                    OnPropertyChanged("Conductor");
                }
            }
        }
        private DateTime _dtmFechaPagoPedimento;

        public DateTime FechaPagoPedimento
        {
            get { return _dtmFechaPagoPedimento; }
            set
            {
                if (value != _dtmFechaPagoPedimento)
                {
                    _dtmFechaPagoPedimento = value;
                    OnPropertyChanged("FechaPagoPedimento");
                }

            }
        }
        private DateTime _dtmFechaVencimientoPedimento;

        public DateTime FechaVencimientoPedimento
        {
            get { return _dtmFechaVencimientoPedimento; }
            set
            {
                if (value != _dtmFechaVencimientoPedimento)
                {
                    _dtmFechaVencimientoPedimento = value;
                    OnPropertyChanged("FechaVencimientoPedimento");
                }
            }
        }

        private string _strAsignada;

        public string Asignada
        {
            get { return _strAsignada; }
            set
            {
                if (value != _strAsignada)
                {
                    _strAsignada = value;
                    OnPropertyChanged("Asignada");
                }

            }
        }
        private string _strCliente;

        public string Cliente
        {
            get { return _strCliente; }
            set
            {
                if (value != _strCliente)
                {
                    _strCliente = value;
                    OnPropertyChanged("Cliente");
                }
            }
        }
        private string _strDemora;

        public string Demora
        {
            get { return _strDemora; }
            set
            {

                if (value != _strDemora)
                {
                    _strDemora = value;
                    OnPropertyChanged("Demora");
                }

            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }

}
