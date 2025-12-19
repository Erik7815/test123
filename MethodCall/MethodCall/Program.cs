namespace MethodCall
{
    internal class Program
    {
        //kutsuda meeod välja
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Sayhello();
            SayGoodbye();
            
        }
        static void Sayhello()
        {
            Console.WriteLine("Hello");
        }
        static void SayGoodbye()
        {
            Console.WriteLine("Goodbye");
        }
    }
}
