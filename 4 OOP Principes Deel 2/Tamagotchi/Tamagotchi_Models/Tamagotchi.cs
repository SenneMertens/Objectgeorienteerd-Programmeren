using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi_Models
{
    public class Tamagotchi
    {
        private int _goedGevoel;
        private int _honger;
        private DateTime _laatsteMaaltijd;
        private string _naam;

        private int GoedGevoel
        {
            get { return _goedGevoel; }
            set
            {
                if (value < -10)
                {
                    value = -10;
                }
                else if (value > 10)
                {
                    value = 10;
                }

                _goedGevoel = value;
            }
        }

        private int Honger
        {
            get { return _honger; }
            set
            {
                if (value < -5)
                {
                    value = -5;
                }
                else if (value > 20)
                {
                    value = 20;
                }

                _goedGevoel = value;
            }
        }

        private DateTime LaatsteMaaltijd
        {
            get { return _laatsteMaaltijd; }
            set { _laatsteMaaltijd = value; }
        }

        public Tamagotchi(string naam)
        {
            this._naam = naam;
            GoedGevoel = 0;
            Honger = 0;
        }

        public Tamagotchi(string naam, int honger, int goedGevoel)
        {
            _naam = naam;
            Honger = honger;
            GoedGevoel = goedGevoel;
        }

        public void Eten(int eenheden)
        {
            if (eenheden > 3)
            {
                eenheden = 3;
            }

            Honger += eenheden;

            LaatsteMaaltijd = DateTime.Now;
        }

        public void LiefKozen()
        {
            GoedGevoel += 1;
        }

        public void Straffen(int eenheden)
        {
            GoedGevoel -= eenheden;
        }

        public string Gevoel()
        {
            if (GoedGevoel > 0)
            {
                GoedGevoel--;
            }

            DateTime nu = DateTime.Now;
            TimeSpan tijd = nu.Subtract(LaatsteMaaltijd);
            int seconden = tijd.Hours * 3600 + tijd.Minutes * 60 + tijd.Seconds;
            int hongerEenheden = seconden / 30;

            return $"Gevoel: {GoedGevoel} - Honger: {Honger}";
        }
    }
}