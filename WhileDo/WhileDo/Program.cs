namespace WhileDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While Do");

            int number = 1;

            do
            {
                Console.WriteLine(number);
                //suurendab numbrei ühe võrra e number + 1
                number++;
                //kui number on väiksem või võrdne 5-ga siis jätkab tsüklit
            } while (number <= 5);
        }
    }
}
