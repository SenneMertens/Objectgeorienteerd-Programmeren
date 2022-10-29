using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zwembad_Models
{
    public class Zwembad
    {
        private double _breedte;
        private double _diepte;
        private double _lengte;
        private double _randafstand;

        public double Breedte
        {
            get { return _breedte; }
            set 
            {
                if (value < 0)
                {
                    value = 0;
                }

                _breedte = value;
            }
        }

        public double Diepte
        {
            get { return _diepte; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                
                _diepte = value;
            }
        }

        public double Lengte
        {
            get { return _lengte; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }

                _lengte = value;
            }
        }

        public double Randafstand
        {
            get { return _randafstand; }
            set
            {
                if (value < 0 || value > Diepte)
                {
                    value = 0;
                }

                _randafstand = value;
            }
        }

        public Zwembad()
        {
            this._breedte = 0;
            this._diepte = 0;
            this._lengte = 0;
            this._randafstand = 0;
        }

        public double LiterWater()
        {
            return Breedte * Lengte * (Diepte - Randafstand) * 1000;
        }

        public string ToonGegevens()
        {
            return $"Breedte: {this._breedte}{Environment.NewLine}Diepte: {this._diepte}{Environment.NewLine}Lengte: {this._lengte}{Environment.NewLine}Randafstand: {this._randafstand}{Environment.NewLine}{Environment.NewLine}Liters Water: {LiterWater()}";
        }
    }
}