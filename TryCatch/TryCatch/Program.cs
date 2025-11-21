namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Try Catch Switch");

            try
            {



                int nr = int.Parse(Console.ReadLine());

                switch (nr)
                {
                    case 1:
                        Console.WriteLine("Sisestasid numbri 1");
                        break;

                    case 2:
                        Console.WriteLine("Sisestasid numbri 2");
                        break;

                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Palun sisesta number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Sisestatud number on liiga suur või väike!");
            }
        }
    }
}
