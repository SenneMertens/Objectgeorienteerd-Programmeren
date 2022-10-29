using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dieren_Models
{
    public class Dier
    {
        private string _naam;

        protected string Naam
        {
            get { return _naam; }
        }

        public virtual string Gegevens
        {
            get { return $"Mijn naam is {Naam} en ik ben een {this.GetType()}."; }
        }

        protected Dier(string naam)
        {
            this._naam = naam;
        }

        public virtual string Eten()
        {
            return $"";
        }

        public virtual string Praten(string zin)
        {
            return $"";
        }

        public virtual string Strelen()
        {
            return $"";
        }
    }

    public class Mens : Dier
    {
        public override string Gegevens
        {
            get { return base.Gegevens + $" Hahaha!"; }
        }

        public Mens(string naam) : base(naam)
        {

        }

        public override string Eten()
        {
            return $"Lekker!";
        }

        public override string Praten(string zin)
        {
            switch (zin.ToLower())
            {
                case "goedemorgen":
                    return $"Ook een goede morgen.";
                case "goedenmiddag":
                    return $"Ook een goede middag.";
                case "goedenavond":
                    return $"Ook een goede avond.";
                default:
                    return $"Die zin ken ik niet";
            }
        }

        public override string Strelen()
        {
            return $"Blijf van mijn lijf!";
        }
    }

    public class Kat : Dier
    {
        private int _teller;

        private int Teller
        {
            get { return _teller; }
            set { _teller = value; }
        }
        public override string Gegevens
        {
            get { return base.Gegevens + $" Miauw!"; }
        }

        public Kat(string naam) : base(naam)
        {

        }

        public override string Praten(string zin)
        {
            Teller++;

            if (Teller == 3)
            {
                Teller = 0;

                return $"Miauw miauw";
            }
            else
            {
                return $"";
            }
        }

        public override string Strelen()
        {
            return $"Rrrrr";
        }
    }

    public class Papegaai : Dier
    {
        public override string Gegevens
        {
            get { return base.Gegevens + $" Krr krr!"; }
        }

        public Papegaai(string naam) : base(naam)
        {

        }

        public override string Praten(string zin)
        {
            Random random = new Random();
            
            if (random.Next(1, 6) == 5)
            {
                return $"Koko kopke krabben!";
            }
            else
            {
                return zin;
            }
        }

        public override string Strelen()
        {
            return $"Koko";
        }
    }
}