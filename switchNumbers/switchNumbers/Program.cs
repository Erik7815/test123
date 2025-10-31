namespace switchNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int nr = Convert.ToInt32(Console.ReadLine());
            switch (nr)
            {
                case 10:
                    Console.WriteLine("sisestasid numbri 10");
                    break;

                case 20:
                    Console.WriteLine("sisestasid numbri 20");
                    break;

                case 30:
                    Console.WriteLine("Sisestasid numbri 30");
                    break;

                default:
                    Console.WriteLine("ERROR");
                    break;
            }

        }
    }
}
