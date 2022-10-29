using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Rekening_Models;

namespace Rekening_DAL
{
    public class FileReader
    {
        public List<Rekening> BestandLezen(string bestandsnaam)
        {
            List<Rekening> lijst = new List<Rekening>();
            List<string> gegevens = new List<string>();

            StreamReader reader = new StreamReader(bestandsnaam);

            while (! reader.EndOfStream)
            {                
                string line = reader.ReadLine();

                gegevens = line.Split(';').ToList();

                if (double.TryParse(gegevens[2], out double saldo))
                {
                    switch (gegevens[0].ToLower())
                    {
                        case "rekening":
                            Rekening rekening = new Rekening(gegevens[1], saldo);
                            lijst.Add(rekening);
                            break;
                        case "zichtrekening":
                            Zichtrekening zichtrekening = new Zichtrekening(gegevens[1], saldo);
                            lijst.Add((zichtrekening));
                            break;
                        case "spaarrekening":
                            Spaarrekening spaarrekening = new Spaarrekening();
                            spaarrekening.IbanNummer = gegevens[1];
                            spaarrekening.Saldo = saldo;
                            if (double.TryParse(gegevens[3], out double rente))
                            {
                                spaarrekening.Percentage = rente;
                            }
                            lijst.Add(spaarrekening);
                            break;
                    }
                }
            }

            reader.Close();

            return lijst;
        }
    }
}