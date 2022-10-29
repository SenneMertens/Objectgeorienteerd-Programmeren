using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klant_Models
{
    public class Klant
    {
        private string _adres;
        private string _gemeente;
        private int _klantnummer;
        private string _naam;
        private string _postcode;

        public string Adres
        {
            get { return _adres; }
            set { _adres = value; }
        }

        public string Gemeente
        {
            get { return _gemeente; }
            set { _gemeente = value; }
        }

        public int Klantnummer
        {
            get { return _klantnummer; }
            set { _klantnummer = value; }
        }

        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        public string Postcode
        {
            get { return _postcode; }
            set { _postcode = value; }
        }

        public Klant(int klantnummer, string naam, string adres, string gemeente, string postcode)
        {
            Naam = naam;
            Klantnummer = klantnummer;
            Adres = adres;
            Gemeente = gemeente;
            Postcode = postcode;
        }

        public override bool Equals(object obj)
        {
            if (obj is Klant klant)
            {
                if (this.Klantnummer == klant.Klantnummer)
                {
                    return true;
                }
            }

            return false;
        }

        public override string ToString()
        {
            return $"{this.Naam}{Environment.NewLine}{this.Adres}{Environment.NewLine}{this.Gemeente} {this.Postcode}";
        }
    }
}