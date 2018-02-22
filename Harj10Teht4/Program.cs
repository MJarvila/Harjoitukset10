using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj10Teht4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = new List<int>();
            List<Double> doubles = new List<double>();
            string number = " ";
            int inte;
            double doub;


            while (number.Length > 0)
            {
                number = Console.ReadLine();
                if (int.TryParse(number, out inte) == true)
                {
                    inte = int.Parse(number);
                    integers.Add(inte);
                }
                else if (double.TryParse(number, out doub) == true)
                {
                    doub = double.Parse(number);
                    doubles.Add(doub);
                }
                else
                {
                    Console.WriteLine("You need to input a number.");
                    break;
                }
            }

            Save NumberSaver = new Save();
            NumberSaver.IntegersToFile(integers);
            NumberSaver.DoublesToFile(doubles);
            NumberSaver.ReadValues();
        }
    }
}
