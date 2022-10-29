using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ministers_DAL
{
    public class FileReader
    {
        public List<string> BestandLezen(string bestandsnaam)
        {
            List<string> lijst = new List<string>();

            StreamReader reader = new StreamReader(bestandsnaam);

            while (! reader.EndOfStream)
            {
                string lijn = reader.ReadLine();

                lijst.Add(lijn);
            }

            reader.Close();

            return lijst;
        }
    }
}