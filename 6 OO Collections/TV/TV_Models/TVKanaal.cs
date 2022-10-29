using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TV_Models
{
    public class TVKanaal
    {
        private int _nummer;
        private string _omschrijving;

        public int Nummer
        {
            get { return _nummer; }
            set { _nummer = value; }
        }

        public string Omschrijving
        {
            get { return _omschrijving; }
            set { _omschrijving = value; }
        }

        public TVKanaal(int nummer, string omschrijving)
        {
            this._nummer = nummer;
            this._omschrijving = omschrijving;
        }

        public TVKanaal() : this(0, $"")
        {

        }

        public override string ToString()
        {
            return $"{Nummer} - {Omschrijving}";
        }
    }
}