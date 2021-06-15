using System;

namespace PersonalRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            Personal register = new Personal();
            start:
            Console.WriteLine("Vill du läga till Namn och Lön (Addinfo), skriva ut registret (SkrivUt) eller stopa programmet (Stop)?");

            string input = Console.ReadLine();
            if (input =="AddInfo" || input == "Addinfo" || input == "addinfo")
            {
                Console.WriteLine("Ange namnet och lönen (Namn, Lön)");
                string info = Console.ReadLine();
                register.AddInfo(info);
                goto start;
            }
            else if (input == "SkrivUt" || input == "Skrivut" || input == "skrivut")
            {
                register.SkrivUt();
                goto start;
            }
            else if(input == "Stop" || input == "stop")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Error, felaktigt input");
                goto start;
            }

        }
    }
}
