using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teller_Models
{
    public class Teller
    {
        private int _waarde;

        public int Waarde
        {
            get { return _waarde; }
            private set { _waarde = value; }
        }

        public Teller()
        {
            this._waarde = 0;
        }

        public void Verhoog()
        {
            this._waarde++;
        }

        public void Verlaag()
        {
            this._waarde--;
        }

        public void Resetten()
        {
            this._waarde = 0;
        }

        public string ToonGegevens()
        {
            return $"Waarde van de teller is {Waarde}";
        }
    }
}