namespace MaaKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Meil on münt mille diameeter on 25.75 mm
            //arvuta välja maa ümbermõõt ja mitu münti 
            //mahub järjestikkus ümber maa 
            //arvutades tohib ainult kasutada mündi diameetrit ja maa raadiust

            double maaraadius = 637100000;
            double maaümber = 2 * Math.PI * maaraadius;
            Console.WriteLine("Maa ümbermõõt on " + maaümber );

            double mündidiameeter = 2.575;
            Console.WriteLine("Maa ümber mahub " + maaümber  / (mündidiameeter) + " münti");

        }
    }
}
