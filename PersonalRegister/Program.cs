using System;

namespace PersonalRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            Personal register = new Personal();
            register.AddInfo("Johan", 100);
            register.AddInfo("Dan", 90);
            register.AddInfo("Mill", 20);

            register.SkrivUt();


        }
    }
}
