namespace Ruut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta ruudu suurus");
            //teha for loopiga ruut

            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < x; i++) 
            {
                for (int j = 0; j < x; j++) 
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            Console.WriteLine("ümbermõõt: " + x * 4);
            Console.WriteLine("pindala: " + x * x);

            
        }
    }
}
