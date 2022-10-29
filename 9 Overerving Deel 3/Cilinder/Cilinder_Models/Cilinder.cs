using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cilinder_Models
{
    public class Punt
    {
        private double _x;
        private double _y;

        public double X
        {
            get { return _x; }
            set { _x = value; }
        }

        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public Punt(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Punt() : this(0, 0)
        {

        }

        public virtual string Omschrijving
        {
            get { return $"Klasse: {this.GetType().Name} - Coördinaten: ({X}, {Y})"; }
        }

        public override string ToString()
        {
            return $"{this.Omschrijving}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Punt punt)
            {
                if (this.X == punt.X && this.Y == punt.Y && this.GetType() == punt.GetType())
                {
                    return true;
                }
            }

            return false;
        }
    }

    public class Cirkel : Punt
    {
        private double _r;

        public double R
        {
            get { return _r; }
            set { _r = value; }
        }

        public override string Omschrijving
        {
            get { return base.Omschrijving + $" - Straal: {R}"; }
        }

        public Cirkel(double r, double x, double y) : base(x, y)
        {
            R = r;
        }

        public Cirkel() : this(0, 0, 0)
        {

        }

        public double Omtrek()
        {
            return 2 * Math.PI * R;
        }

        public virtual double Oppervlakte()
        {
            return Math.PI * Math.Pow(R, 2);
        }

        public override string ToString()
        {
            return $"{this.Omschrijving}{Environment.NewLine}Oppervlakte: {this.Oppervlakte().ToString("0.##")}{Environment.NewLine}Omtrek: {this.Omtrek().ToString("0.##")}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Cirkel cirkel)
            {
                if (this.X == cirkel.X && this.Y == cirkel.Y && this.R == cirkel.R && this.GetType() == cirkel.GetType())
                {
                    return true;
                }
            }

            return false;
        }
    }

    public class Cilinder : Cirkel
    {
        private double _h;

        public double H
        {
            get { return _h; }
            set { _h = value; }
        }

        public override string Omschrijving
        {
            get { return base.Omschrijving + $" - Hoogte: {H}"; }
        }

        public Cilinder(double h, double r, double x, double y) : base(r, x, y)
        {
            H = h;
        }

        public Cilinder() : this(0, 0, 0, 0)
        {

        }

        public override double Oppervlakte()
        {
            return base.Oppervlakte() * 2 + base.Omtrek() * H;
        }

        public double Volume()
        {
            return base.Oppervlakte() * H;
        }

        public override string ToString()
        {
            return this.Omschrijving + $"{Environment.NewLine}Oppervlakte: {this.Oppervlakte().ToString("0.##")}{Environment.NewLine}Volume: {this.Volume().ToString("0.##")}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Cilinder cilinder)
            {
                if (this.X == cilinder.X && this.Y == cilinder.Y && this.R == cilinder.R && this.H == cilinder.H && this.GetType() == cilinder.GetType())
                {
                    return true;
                }
            }

            return false;
        }
    }
}