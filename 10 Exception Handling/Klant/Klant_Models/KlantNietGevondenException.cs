using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klant_Models
{
    public class KlantNietGevondenException : Exception
    {
        public KlantNietGevondenException(int klantnummer) : base($"De klantnummer {klantnummer} bestaat niet.")
        {

        }
    }
}