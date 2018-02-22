using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Harj10Teht1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string file = @"C:\Users\Akallath\Desktop\Koululaput\Olio-ohjelmointi\Harjoitukset10\Harj10Teht1\names.txt";
                string text = " ";

                using (StreamWriter sw = new StreamWriter(file))
                {
                    while (text.Length > 0)
                    {
                        Console.WriteLine("Syötä nimi. Tyhjä lopettaa.");

                        text = Console.ReadLine();
                        sw.WriteLine(text);

                    }
                    sw.Close();
                }

                if (File.Exists(file))
                {
                    text = File.ReadAllText(file);
                    Console.WriteLine("{0} sisältää seuraavat nimet: {1}", file, text);
                }
                else
                {
                    Console.WriteLine("{0} filua ei saatavills.", file);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

        }
    }
}