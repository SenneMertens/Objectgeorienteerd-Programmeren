using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Klant_Models;

namespace Klant_DAL
{
    public class FileOperations
    {
        public List<Klant> BestandInlezen(string bestandsnaam)
        {
            List<Klant> lijst = new List<Klant>();

            try
            {
                StreamReader reader = new StreamReader(bestandsnaam);

                List<string> gegevens = new List<string>();

                while (! reader.EndOfStream)
                {
                    string lijn = reader.ReadLine();

                    gegevens = lijn.Split(';').ToList();

                    if (int.TryParse(gegevens[0], out int klantnummer))
                    {
                        Klant klant = new Klant(klantnummer, gegevens[1], gegevens[2], gegevens[3], gegevens[4]);

                        if (! lijst.Contains(klant))
                        {
                            lijst.Add(klant);
                        }
                    }
                }

                reader.Close();

                return lijst;
            }
            catch (Exception ex)
            {
                FoutLoggen(ex);
                return null;
            }
        }

        public void FoutLoggen(Exception fout)
        {
            StreamWriter writer = new StreamWriter("foutenbestand.txt", true);

            writer.WriteLine(fout.GetType().Name);
            writer.WriteLine(fout.Message);
            writer.WriteLine(fout.StackTrace);

            writer.Close();
        }

        public Klant ZoekKlantViaNummer(int klantnummer)
        {
            List<Klant> lijst = BestandInlezen("klanten.txt");

            foreach (Klant klant in lijst)
            {
                if (klant.Klantnummer == klantnummer)
                {
                    return klant;
                }
            }

            throw new KlantNietGevondenException(klantnummer);
        }
    }
}