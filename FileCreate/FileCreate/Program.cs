namespace FileCreate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kirjutab faili läbi konsooli");

            string filepath = "C:/Users/opilane/Desktop/WriteToFile.txt";
            string input = Console.ReadLine();

            File.WriteAllText(filepath, input);
        }
    }
}
