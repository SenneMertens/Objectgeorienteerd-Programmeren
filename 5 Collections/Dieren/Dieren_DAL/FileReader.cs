using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dieren_DAL
{
    public class FileReader
    {
        public List<string> BestandLezen(string bestandsnaam)
        {
            List<string> lijst = new List<string>();

            StreamReader reader = new StreamReader(bestandsnaam);

            while (! reader.EndOfStream)
            {
                    lijst.Add(reader.ReadLine());
            }

            reader.Close();

            return lijst;
        }
    }
}