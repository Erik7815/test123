using System.Drawing;

namespace VigadeParandus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vajuta numbrit");
            Console.WriteLine("1. tagurpidi püramiid");
            Console.WriteLine("2. ristkülik");
            Console.WriteLine("3. püramiid");
            string input = Console.ReadLine();
            Console.Clear();

            switch (input)
            {
                case "1":
                    //meetodi välja kutsumine
                    upsidedownpyramid();
                    break;
                case "2":
                    rectangle();
                    break;
                case "3":
                    pyramid();
                    break;
                default:
                    Console.WriteLine("sellist valikut ei ole ");
                    break;
            }
        }
        static void upsidedownpyramid()
        {
            int i, j, n;
            Console.WriteLine("sisesta kõrgus");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = n - 1;i >= 1; i--)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
        static void rectangle()
        {
            Console.WriteLine("sisesta pikkus");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("sisesta laius");
            int width = int.Parse(Console.ReadLine());

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            int area = row * width;
            int around = 2 * (row + width);
            Console.WriteLine("ümbermõõt on " + around);
            Console.WriteLine("pindala on " + area);
        }
        static void pyramid()
        {
            Console.WriteLine("sisesta kõrgus: ");
            int i, j, n;
            n = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(" ");
                }
                for (i = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
