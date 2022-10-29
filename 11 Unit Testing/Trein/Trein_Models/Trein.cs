using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trein_Models
{
    public class Trein
    {
        public bool _deurOpen;
        public int _passagiers;
        public int _snelheid;

        private bool DeurOpen
        {
            get { return _deurOpen; }
            set { _deurOpen = value; }
        }

        private int Passagiers
        {
            get { return _passagiers; }
            set 
            {
                if (value < 0)
                {
                    value = 0;
                }

                _passagiers = value;
            }
        }

        private int Snelheid
        {
            get { return _snelheid; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                else if (value > 120)
                {
                    value = 120;
                }

                _snelheid = value;
            }
        }

        public Trein()
        {
            DeurOpen = true;
            Snelheid = 0;
            Passagiers = 0;
        }

        public bool Afstappen(int passagiers)
        {
            if (DeurOpen == false)
            {
                return false;
            }
            else
            {
                Passagiers -= passagiers;
                return true;
            }
        }

        public bool Opstappen(int passagiers)
        {
            if (DeurOpen == false)
            {
                return false;
            }
            else
            {
                Passagiers += passagiers;
                return true;
            }
        }

        public void SluitDeur()
        {
            DeurOpen = false;
        }

        private int WijzigSnelheid(int snelheidsWijziging)
        {
            return Snelheid += snelheidsWijziging;
        }

        public void Stoppen()
        {
            WijzigSnelheid(-120);
            DeurOpen = true;
        }

        public bool Versnellen(int snelheidsWijziging)
        {
            if (DeurOpen = false)
            {
                return false;
            }
            else
            {
                WijzigSnelheid(snelheidsWijziging);

                return true;
            }
        }

        public void Remmen(int snelheidsWijziging)
        {
            WijzigSnelheid(-snelheidsWijziging);
        }

        public string StandDeuren()
        {
            if (DeurOpen == true)
            {
                return $"Open";
            }
            else
            {
                return $"Gesloten";
            }
        }

        public string StandVanZaken()
        {
            return $"Snelheid: {Snelheid:0.00}{Environment.NewLine}Passagiers: {Passagiers}{Environment.NewLine}Deuren: {StandDeuren()}";
        }
    }
}