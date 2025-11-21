namespace WhileDoTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kolmnurk");

            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;

            while (i <= n)
            {
                Console.WriteLine();
                int j = 1;
                    while (j <= i)
                {
                    Console.WriteLine(j + " ");
                    j++;
                }

                i++;
            }
            Console.ReadKey(); 

        }
    }
}
