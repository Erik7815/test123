namespace Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //teha ristkülik tärnidest 
            //peab arvvutama pindala ja ümbermõõdu

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            int umbermoot = 2 * (a + b);
            int pindala = a * b;
            Console.WriteLine("ümbermõõt: " + (umbermoot));
            Console.WriteLine("pindala: " + (pindala));


        }
    }
}
