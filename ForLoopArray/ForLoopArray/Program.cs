using System.ComponentModel.DataAnnotations;

namespace ForLoopArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //vaja teha string array H, e, l, l, o
            //kasuta for loopi

            string[] hello = { "H", "e", "l", "l", "o" };

            for (int i = 0; i < hello.Length; i++)
            {
                Console.WriteLine(hello[i]);
            }

            //kasuta nüüd foreach-i
            foreach (string i  in hello)
            {
                Console.WriteLine(i);
            }
        }
    }
}
