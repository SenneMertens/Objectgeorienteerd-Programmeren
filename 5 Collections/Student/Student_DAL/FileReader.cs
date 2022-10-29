using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Student_DAL
{
    public class FileReader
    {
        public List<string> LeesString(string bestandsnaam)
        {
            List<string> lijst = new List<string>();

            StreamReader reader = new StreamReader(bestandsnaam);

            while (!reader.EndOfStream)
            {
                string lijn = reader.ReadLine();

                lijst.Add(lijn);
            }

            reader.Close();

            return lijst;
        }

        public List<int> LeesInt(string bestandsnaam)
        {
            List<int> lijst = new List<int>();

            StreamReader reader = new StreamReader(bestandsnaam);

            while (! reader.EndOfStream)
            {
                string lijn = reader.ReadLine();

                if (int.TryParse(lijn, out int getal))
                {
                    lijst.Add(getal);
                }
            }

            reader.Close();

            return lijst;
        }
    }
}