using System.Threading.Channels;

namespace KujundiKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //ruudus sees asub ring. ringi raadius on 3 ühikut.
            //Leia ja väljesta ekraanile ruudu pindala ja ümbermõõt 

            int radius = 3;
            int diameter = radius * 2;
            double squareArea = diameter * diameter;
            double perimeter = 4 * diameter;


            Console.WriteLine("Ruudu pindala on " + squareArea);
            Console.WriteLine("ruudu ümbermõõt on " + perimeter);

            Console.WriteLine("ringi ümbermõõt on " + Math.PI * 2 * (radius));
            Console.WriteLine("ringi pindala on " + Math.PI * (radius * radius ));



        }
    }
}
