namespace ComputerCalcLogic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kui palju on 3 + 8 / (4 - 2) * 4 = ?");

            double calculation = 3 + 8 / (4 - 2) * 4;
            float calculation2 = 3 + 8 / 4 - 2 * 4;
            double calculation3 = (3 + 8) / (4 - 2) * 4;
            double calculation4 = (3.0 + 8.0) / (4.0 - 2 - 0) * 4.0;

            Console.WriteLine("Vastus: " + calculation);
            Console.WriteLine("3 + 8 / (4 - 2) * 4 = " + calculation2);
            Console.WriteLine("(3 + 8) / (4 - 2) * 4 = " + calculation3);
            Console.WriteLine("(3 + 8) / (4 - 2) * 4 = " + calculation4);


        }
    }
}
