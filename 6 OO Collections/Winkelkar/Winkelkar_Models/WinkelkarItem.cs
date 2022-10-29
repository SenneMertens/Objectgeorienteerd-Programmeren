using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkelkar_Models
{
    public class WinkelkarItem
    {
        private int _aantal;
        private double _prijs;
        private string _omschrijving;

        public int Aantal
        {
            get { return _aantal; }
            set { _aantal = value; }
        }

        public double Prijs
        {
            get { return _prijs; }
            set { _prijs = value; }
        }

        public string Omschrijving
        {
            get { return _omschrijving; }
            set { _omschrijving = value; }
        }

        public WinkelkarItem(int aantal, double prijs, string omschrijving)
        {
            this._aantal = aantal;
            this._prijs = prijs;
            this._omschrijving = omschrijving;
        }

        public WinkelkarItem() : this(0, 0, $"")
        {

        }

        public double TotalePrijs()
        {
            return Aantal * Prijs;
        }

        public string FormattedTotalePrijs()
        {
            return $"{(Aantal * Prijs).ToString("0.00")}";
        }

        public override string ToString()
        {
            return Aantal.ToString().PadLeft(3) + " * " + Omschrijving.PadRight(15) + " : " + FormattedTotalePrijs().PadLeft(6) + Environment.NewLine;
        }
    }
}