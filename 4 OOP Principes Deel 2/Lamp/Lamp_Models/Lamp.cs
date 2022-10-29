using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Lamp_Models
{
    public class Lamp
    {
        private byte _blauw;
        private byte _groen;
        private byte _rood;
        private Random _random;

        public byte Blauw
        {
            get { return _blauw; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                if (value > 255)
                {
                    value = 255;
                }

                _blauw = value;
            }
        }

        public byte Groen
        {
            get { return _groen; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                if (value > 255)
                {
                    value = 255;
                }

                _groen = value;
            }
        }

        public byte Rood
        {
            get { return _rood; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                if (value > 255)
                {
                    value = 255;
                }

                _rood = value;
            }
        }

        private Random Random
        {
            get { return _random; }
            set { _random = value; }
        }

        public Lamp()
        {
            Blauw = 0;
            Groen = 0;
            Rood = 0;
            Random = new Random();
        }

        public Lamp(byte blauw, byte groen, byte rood)
        {
            Blauw = blauw;
            Groen = groen;
            Rood = rood;
            Random = new Random();
        }

        public void MeerBlauw()
        {
            Blauw += 10;
        }

        public void MeerGroen()
        {
            Groen += 10;
        }

        public void MeerRood()
        {
            Rood += 10;
        }

        public void MinderBlauw()
        {
            Blauw -= 10;
        }

        public void MinderGroen()
        {
            Groen -= 10;
        }

        public void MinderRood()
        {
            Rood -= 10;
        }

        public void RandomKleur()
        {
            Blauw = (byte)Random.Next(0, 256);
            Groen = (byte)Random.Next(0, 256);
            Rood = (byte)Random.Next(0, 256);
        }

        public string ToonRGBWaardes()
        {
            return $"Rood: {Rood} - Groen: {Groen} - Blauw: {Blauw}";
        }

        public SolidColorBrush LampKleur()
        {
            return new SolidColorBrush(Color.FromRgb(Rood, Groen, Blauw));
        }
    }
}