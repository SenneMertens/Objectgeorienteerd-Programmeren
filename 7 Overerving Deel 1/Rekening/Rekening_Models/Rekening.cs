using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekening_Models
{
    public class Rekening
    {
        private string _ibanNummer;
        private double _minimum;
        private double _saldo;

        public string IbanNummer
        {
            get { return _ibanNummer; }
            set { _ibanNummer = value; }
        }

        public double Minimum
        {
            get { return _minimum; }
            set { _minimum = value; }
        }

        public double Saldo
        {
            get { return _saldo; }
            set
            {
                if (value < Minimum)
                {
                    value = Minimum;
                }

                _saldo = value;
            }
        }

        public string Landcode
        {
            get { return IbanNummer.Substring(0, 2); }
        }

        public Rekening(string ibanNummer, double saldo)
        {
            this.IbanNummer = ibanNummer;
            this.Saldo = saldo;
            this.Minimum = 0;
        }

        public void Afhalen(double bedrag)
        {
            Saldo -= Math.Abs(bedrag);
        }

        public void Storten(double bedrag)
        {
            Saldo += Math.Abs(bedrag);
        }

        public virtual string ToonGegevens()
        {
            return $"Iban-nummer: {IbanNummer} - Saldo: {Saldo.ToString("0.##")}";
        }
    }

    public class Zichtrekening : Rekening
    {
        public Zichtrekening(string rekeningnummer, double saldo) : base(rekeningnummer, saldo)
        {
            this.Minimum = -100;
        }
    }

    public class Spaarrekening : Rekening
    {
        private double _percentage;

        public double Percentage
        {
            get { return _percentage; }
            set { _percentage = value; }
        }

        public Spaarrekening() : base($"", 0)
        {
            Percentage = 0;
        }

        public void SchrijfRenteBij(double rente)
        {
            Saldo += Saldo * (Percentage / 100);
        }

        public override string ToonGegevens()
        {
            return base.ToonGegevens() + $" - Percentage: {Percentage.ToString("0.##")}";
        }
    }
}