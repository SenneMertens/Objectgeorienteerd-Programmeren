using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TV_Models
{
    public class TV
    {
        private int _kanaal;
        private int _volume;

        private int Kanaal
        {
            get { return _kanaal; }
            set
            {
                if (value >= 0 && value <= 30)
                {
                    _kanaal = value;
                }
                else if (value < 0)
                {
                    _kanaal = 0;
                }
                else if (value > 30)
                {
                    _kanaal = 30;
                }
            }
        }

        private int Volume
        {
            get { return _volume; }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    _volume = value;
                }
                else if (value < 0)
                {
                    _volume = 0;
                }
                else if (value > 10)
                {
                    _volume = 10;
                }
            }
        }

        public TV()
        {
            this._kanaal = 0;
            this._volume = 0;
        }

        public void VermeerderKanaal()
        {
            this.Kanaal++;
        }

        public void VerminderKanaal()
        {
            this.Kanaal--;
        }

        public void VermeerderVolume()
        {
            this.Volume++;
        }

        public void VerminderVolume()
        {
            this.Volume--;
        }

        public string ToonGegevens()
        {
            return $"Kanaal: {Kanaal} - Volume: {Volume}";
        }
    }
}