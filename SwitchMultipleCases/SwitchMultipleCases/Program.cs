namespace SwitchMultipleCases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string type;

            type = Console.ReadLine();

            switch (type)
            {
                case "Intro to C#":
                case "Variables":
                case "Data Types":
                    Console.WriteLine("Basic");
                    break;

                case "OOP":
                case "Classes":
                case "Objects":
                    Console.WriteLine("Intermediate");
                    break;

                case "Asynchronous Programming":
                case "LINQ":
                case "delegates":
                    Console.WriteLine("Advanced");
                    break;

            }

        }
    }
}
