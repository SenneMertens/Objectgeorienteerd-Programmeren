using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Models
{
    public class Student
    {
        private string _naam;
        private int _puntenInformatica;
        private int _puntenWiskunde;

        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        public int PuntenInformatica
        {
            get { return _puntenInformatica; }
            set 
            {
                if (value < 0 || value > 20)
                {
                    value = 0;
                }

                _puntenInformatica = value;
            }
        }

        public int PuntenWiskunde
        {
            get { return _puntenWiskunde; }
            set 
            {
                if (value < 0 || value > 20)
                {
                    value = 0;
                }

                _puntenWiskunde = value;
            }
        }

        public Student()
        {
            this._naam = $"";
            this._puntenInformatica = 0;
            this._puntenWiskunde = 0;
        }

        public string ToonGegevens()
        {
            return $"{Naam.ToUpper()} heeft {PuntenInformatica} voor informatica en {PuntenWiskunde} voor wiskunde behaald.";
        }
    }
}