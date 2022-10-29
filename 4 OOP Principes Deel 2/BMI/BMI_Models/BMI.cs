using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Models
{
    public class BMI
    {
        private string _naam;
        private double _lengte;
        private double _gewicht;

        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        public double Lengte
        {
            get { return _lengte; }
            set { _lengte = value; }
        }

        public double Gewicht
        {
            get { return _gewicht; }
            set { _gewicht = value; }
        }

        public BMI()
        {
            Naam = $"";
            Gewicht = 0;
            Lengte = 0;
        }

        public BMI(string naam, double gewicht, double lengte)
        {
            Naam = naam;
            Lengte = lengte;
            Gewicht = gewicht;
        }

        public double BerekenBMI()
        {
            return Gewicht / Math.Pow(Lengte, 2);
        }

        public string ToonGegevens()
        {
            return $"{Naam} is {Lengte.ToString("0.00")} meter groot en weegt {Gewicht.ToString("0.00")} kilogram.";
        }
    }
}