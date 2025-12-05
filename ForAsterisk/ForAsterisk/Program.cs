namespace ForAsterisk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Asterisk");

            int nr = Convert.ToInt32(Console.ReadLine());

            //tuleb kasutada for loopi
            //sisedan ridade arvu ja tuleb vastav arv konsooli
            //peab näitama tärne 

            for (int a = 0; a < nr; a++)
            {
                Console.WriteLine("*");
            }
        }
    }
}
