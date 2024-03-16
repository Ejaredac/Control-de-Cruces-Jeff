using System;
using System.ComponentModel;
namespace ControlGastos
{
    public class Gasto : INotifyPropertyChanged
    {
        private int _intIdGasto;

        public int IdGasto
        {
            get { return _intIdGasto; }
            set { 
                if (value != _intIdGasto)
                {
                    _intIdGasto = value;
                    OnPropertyChanged("IdGasto");
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


        private double _dblImpuestos;
        public double Impuestos
        {
            get { return _dblImpuestos; }
            set
            {
                if (value != _dblImpuestos)
                {
                    _dblImpuestos = value;
                    OnPropertyChanged("Impuestos");
                }
            }
        }

        private string _strTipoGasto;
        public string TipoGasto
        {
            get { return _strTipoGasto; }
            set
            {
                if (value != _strTipoGasto)
                {
                    _strTipoGasto = value;
                    OnPropertyChanged("TipoGasto");
                }
            }
        }

        private double _dblCantidad;
        public double Cantidad
        {
            get { return _dblCantidad; }
            set
            {
                if (value != _dblCantidad)
                {
                    _dblCantidad = value;
                    OnPropertyChanged("Cantidad");
                }
            }
        }

        private string _strNumeroFactura;
        public string NumeroFactura
        {
            get { return _strNumeroFactura; }
            set
            {
                if (value != _strNumeroFactura)
                {
                    _strNumeroFactura = value;
                    OnPropertyChanged("NumeroFactura");
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

        private string _strGarantia;
        public string Garantia
        {
            get { return _strGarantia; }
            set
            {
                if (value != _strGarantia)
                {
                    _strGarantia = value;
                    OnPropertyChanged("Garantia");
                }
            }
        }

        private DateTime _dtmFechaCompra;
        public DateTime FechaCompra
        {
            get { return _dtmFechaCompra; }
            set
            {
                if (value != _dtmFechaCompra)
                {
                    _dtmFechaCompra = value;
                    OnPropertyChanged("FechaCompra");
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
