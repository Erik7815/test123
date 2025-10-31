namespace SwitchMethodCall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string car = Console.ReadLine();

            switch (car)
            {
                case "Coupe":
                    CarCoupe();
                    break;


                case "Truck":
                    truck();
                    break;

                default:
                    Console.WriteLine("ERROR");
                    break;

            }
        }

        static void CarCoupe()
        {
            Console.WriteLine("This is a coupe car.");
        }

        static void truck()
        {
            Console.WriteLine("This is a truck");
        }

        

    }
}
