namespace SwitchRandomNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("genereerib numbreid ühestkuni kuueni");

            // kõik kuus nubrit tuleb ära käsitleda switchiga
            int cube = new Random().Next(1, 7);


            switch (cube)
            {
                case 1:
                    Console.WriteLine("number 1");
                    break;
                case 2:
                    Console.WriteLine("number 2");
                    break;
                case 3:
                    Console.WriteLine("number 3");
                    break;
                case 4:
                    Console.WriteLine("number 4");
                    break;
                case 5:
                    Console.WriteLine("number 5");
                    break;
                case 6:
                    Console.WriteLine("number 6");
                    break;

                    default:
                    Console.WriteLine("ERROR")
                        break;
                


            }
        }
    }
}
