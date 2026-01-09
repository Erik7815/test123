namespace DigitalClock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Digital clock";
            Console.CursorVisible = false;
            //while (true)
            {
                //Console.Clear();
                //Console.WriteLine("Digital clock");
               //Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
                //Thread.Sleep(1000);
            }

            //tsükkel
            //while (true)
            {
                ////tühjendab konsooliakna
                //Console.Clear();
                
                ////ajaga muutuja
                ////string time = DateTime.Now.ToString("HH:mm:ss");

                ////ekraani laius
                ////int x = (Console.WindowWidth - time.Length) / 2;
                ////ekraani pikkus
                ////int y = Console.WindowHeight / 2;

                ////kella näitamise koht
                ////Console.SetCursorPosition(x, y);
                ////näitab aega
                ////Console.Write(time);

                ////ootab
                //Thread.Sleep(1000);

            }
            //for loopiga teha digitaalne kell
            for ( ; ; ) 
            {
                string time = DateTime.Now.ToString("HH:mm:ss");
                Console.Clear();
                Console.Write(time);
                Thread.Sleep(1000);
                
            }
            
        }

    }
}
