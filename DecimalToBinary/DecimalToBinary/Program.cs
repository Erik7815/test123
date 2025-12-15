namespace DecimalToBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decimal to binary");

            Console.WriteLine("sisesta number");
            int num = Convert.ToInt32(Console.ReadLine());
            string binarynumber = "";

            while (num > 0)
            {
                int reminder = num % 2;
                binarynumber = reminder + binarynumber;
                num /= 2;
            }
            Console.WriteLine(binarynumber);
        }
    }
}
