using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursist_Models
{
    public class Cursist
    {
        private string _voornaam;
        private string _familienaam;

        public string Voornaam
        {
            get { return _voornaam; }
            set { _voornaam = value; }
        }

        public string Familienaam
        {
            get { return _familienaam; }
            set { _familienaam = value; }
        }

        public string Naam
        {
            get { return $"{Voornaam} {Familienaam}"; }
        }

        public Cursist(string voornaam, string familienaam)
        {
            this._voornaam = voornaam;
            this._familienaam = familienaam;
        }

        public Cursist() : this($"", $"")
        {

        }
    }
}