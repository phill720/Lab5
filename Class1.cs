using System;

namespace RngMethods
{
    public class Rolls
    {
        //-------Methods---------
        public static string RollBoth(int sides, int counter)
        {
            Random random = new Random();
            int ranNum1 = random.Next(1, sides + 1);
            int ranNum2 = random.Next(1, sides + 1);
            //----craps, box cars, snake eyes----
            if (ranNum1 == 1 && ranNum2 == 1)
            { Console.WriteLine("Snake Eyes!\nCraps!"); }
            if (ranNum1 + ranNum2 == 3 || ranNum1 + ranNum2 == 12)
            { Console.WriteLine("Craps!"); }
            else if (ranNum1 == 6 && ranNum2 == 6)
            { Console.WriteLine("BOX CARS!"); }
            else if (ranNum1 + ranNum2 == 7 || ranNum1 + ranNum2 == 11)
            { Console.WriteLine("Natural!"); }
            //-------return string-------
            string str = "Roll " + counter + ":\n" + ranNum1 + "\n" + ranNum2;
            return str;
        }
    }
}
