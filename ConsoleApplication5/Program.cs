using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            //------initial values------
            int counter = 1;
            bool con = true;
            Console.WriteLine("\nWelcome to the Grand Circus Casino! Roll the dice?(y/n):");
            string beginning = Console.ReadLine();
            if (beginning == "y")
            {
                //------program loop------
                while (con)
                {
                    Console.WriteLine("\nHow many sides for the dice?");
                    int sides = int.Parse(Console.ReadLine());
                    Console.WriteLine(RollBoth(sides, counter));
                    //------Continue?--------
                    Console.WriteLine("\nAnother one? (y/n)");
                    string ans = Console.ReadLine();
                    Console.WriteLine("\n================================");
                    if (ans == "y")
                    {
                        con = true;
                        counter++;
                    }
                    else
                    {
                        con = false;
                        Console.WriteLine("WE MADE IT!!!");
                    }
                }
            }
            else
            { Console.WriteLine("Come back when you aren't scared"); }
        }
        //-------Methods---------
        static string RollBoth(int sides, int counter)
        {
            Random random = new Random();
            int ranNum1 = random.Next(1, sides + 1);
            int ranNum2 = random.Next(1, sides + 1);
            string str = "\nRoll " + counter + ":\n" + ranNum1 + "\n" + ranNum2;
            return str;
        }
    }
}
