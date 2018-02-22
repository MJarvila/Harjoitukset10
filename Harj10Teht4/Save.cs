using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Harj10Teht4
{
    class Save
    {
        private string integersfile = @"C:\Users\Akallath\Desktop\Koululaput\Olio-ohjelmointi\Harjoitukset10\Harj10Teht4/integers.txt";
        private string doublesFile = @"C:\Users\Akallath\Desktop\Koululaput\Olio-ohjelmointi\Harjoitukset10\Harj10Teht4/doubles.txt";
        private string text;

        public void IntegersToFile(List<int> ints)
        {
            using (StreamWriter sw = new StreamWriter(integersfile))
            {
                foreach (int integer in ints)
                {
                    sw.WriteLine(integer);
                }
                sw.Close();
            }
        }
        public void DoublesToFile(List<double> doubles)
        {
            using (StreamWriter sw = new StreamWriter(doublesFile))
            {
                foreach (Double doub in doubles)
                {
                    sw.WriteLine(doub);
                }
                sw.Close();
            }
        }

        public void ReadValues()
        {
            if (File.Exists(integersfile))
            {
                text = File.ReadAllText(integersfile);
                Console.WriteLine("There's {0} integers in the integer-file {1}", text, integersfile);
            }
            else
            {
                Console.WriteLine("{0} not found, couldn't read integers");
            }
            if (File.Exists(doublesFile))
            {
                text = File.ReadAllText(doublesFile);
                Console.WriteLine("There's {0} doubles in the double-file {1}", text, doublesFile);
            }
            else
            {
                Console.WriteLine("{0} not found, couldn't read doubles");
            }
        }
    }
}
