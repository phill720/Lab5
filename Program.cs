using System;
using RngMethods;

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
                    Console.Write("\nHow many sides for the dice?\t");
                    int sides = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine(Rolls.RollBoth(sides, counter));
                    //------Continue?-------
                    Console.WriteLine("\nAnother one? (y/n)");
                    string ans = Console.ReadLine().ToLower();
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
                //-----end while loop-----
            }
            else
            { Console.WriteLine( "Come back when you aren't scared" ); }
        }
    }
}