using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vierkant_Models
{
    public class Vierkant
    {
        private int _zijde;

        public int Zijde
        {
            get { return _zijde; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                if (value > 25)
                {
                    value = 25;
                }

                _zijde = value;
            }
        }

        public Vierkant()
        {
            Zijde = 0;
        }

        public Vierkant(int zijde)
        {
            Zijde = zijde;
        }

        public double Diagonaal()
        {
            return Math.Sqrt(2 * Math.Pow(Zijde, 2));
        }

        public int Omtrek()
        {
            return 4 * Zijde;
        }

        public int Oppervlakte()
        {
            return Zijde * Zijde;
        }

        public string Teken()
        {
            string resultaat = string.Empty;

            for (int i = 1; i <= Zijde; i++)
            {
                for (int j = 1; j <= Zijde; j++)
                {
                    resultaat += $"* ";
                }

                resultaat += $"{Environment.NewLine}";
            }

            return resultaat;
        }
    }
}