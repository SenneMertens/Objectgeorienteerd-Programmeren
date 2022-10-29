using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Cursist_Models;

namespace Cursist_DAL
{
    public class FileReader
    {
        public List<Cursist> LeesBestand(string bestandsnaam)
        {
            List<Cursist> lijst = new List<Cursist>();

            StreamReader reader = new StreamReader(bestandsnaam);

            while (! reader.EndOfStream)
            {
                string lijn = reader.ReadLine();

                List<string> gegevens = lijn.Split(';').ToList();

                Cursist cursist = new Cursist(gegevens[0], gegevens[1]);

                lijst.Add(cursist);
            }

            reader.Close();

            return lijst;
        }
    }
}