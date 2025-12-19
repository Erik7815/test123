namespace ArrayString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Euroopa üks pealinnadest on ";
            Console.WriteLine("Tuple");
            //näide 1
            var cities = Tuple.Create("Tallinn", "Pariis", "Rooma", "London", "Helsingi");
            //tuple all on viis erinevat väärtust ja sellepärast saab anud juhul viis item-it sisestada
            Console.WriteLine(sentence + cities.Item5);
            Console.WriteLine("----------------------------------");

            //näide 2
            string[] city = { "Tallinn", "Pariis", "Rooma", "london", "Helsingi" };
            for (int i = 0; i < city.Length; i++)
            {
                Console.WriteLine(sentence + city[i]);
            }
            Console.WriteLine("----------------------------------");

            //näide 3
            Console.WriteLine(sentence + city[2]);

            //näide 4
            Random number = new Random();
            int randomnumber = number.Next(0, 4);
            Console.WriteLine(sentence + city[randomnumber]);


        }
    }
}
