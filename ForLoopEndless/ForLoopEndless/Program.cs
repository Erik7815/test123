namespace ForLoopEndless
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ushort i = 0;

            //kui 10 rida konsoolis sis lõpetab ära

            for (; ; )
            {
                Console.WriteLine("i väärtus on " + i);
                i++;

                if (i > 10)
                    break;
            }
        }
    }
}
