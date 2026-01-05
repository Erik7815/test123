namespace AnimalLength
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string[] loom = { "koer", "kass", "jänes", "sipelgas", "lendorav" };

            int longername = loom[0].Length;
            string longernamestring = loom[0];

            for (int i = 0; i < loom.Length; i++)
            {
                if (longername < loom[i].Length)
                {
                    longername = loom[i].Length;
                    longernamestring = loom[i];
                }
                int animalength = animallength(loom[i]);
                Console.WriteLine(loom[i] + " = ");
                Console.WriteLine(animalength);
                Console.WriteLine();
            }

            Console.WriteLine("pikim nimi oli {0} ja mille nime pikkus oli: {1}", longernamestring, longername);
        }
        static int animallength(string loom)
        {
            return loom.Length;
        }
    }
}
