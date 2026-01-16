using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace FindWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta otsitav sõna");
            Console.WriteLine("kasuta formaati:  s--a. Kus kriips tähistab tundmatut tähte");

            string choice = Console.ReadLine();

            Wordfinder(choice);

        }
        private static void Wordfinder(string choice)
        {
            Regex regularexp = new Regex(@"\b" + choice.Replace("-", "\\w"),
                RegexOptions.Compiled | RegexOptions.IgnoreCase);

            try
            {
                using (StreamReader sr = new StreamReader("C:/Users/opilane/Desktop/lemmad.txt", Encoding.Default))
                {
                    int linenumber = 0;

                    while (sr.EndOfStream == false)
                    {
                        string line = sr.ReadLine();

                        if (line.Length == choice.Length)
                        {
                            MatchCollection matchcollection = regularexp.Matches(line);

                            if (matchcollection.Count > 0)
                            {
                                linenumber++;
                                Console.WriteLine(linenumber + " " + line);
                            }
                        }
                    }
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ei ole olemas sellise pikkusega sõna");
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
