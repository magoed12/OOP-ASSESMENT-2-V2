using OOP_ASSESMENT_2;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing// testing class declared
    {
        public void Test()// testing method called Test called in the main program
        {
            Game game = new Game();// creates a Game object simply called game
            var values = game.RunGame();// as the RunGame returns as a a tuple, this lines saves the tuple to a local variable
            Console.WriteLine(values.Item4);// prints the sum of the numbers
            Debug.Assert(values.Item4 < 19 && values.Item4 > 2, "The sum is incorrect");// error handling using debug.assert, checks the sum and the die are possible given that it is generating random numbers between 1-6
            Debug.Assert(values.Item1 < 7 && values.Item1 > 0, "A die roll is invalid");
            Debug.Assert(values.Item2 < 7 && values.Item2 > 0, "A die roll is invalid");
            Debug.Assert(values.Item3 < 7 && values.Item3 > 0, "A die roll is invalid");
            Console.WriteLine("Testing is complete");
            ThreeOrMore threeOrMore1 = new ThreeOrMore();
            SevensOut sevensOut1 = new SevensOut();
            var Values = new List<int>();
            Console.WriteLine("enter what numbers you want to check (5) between 1 and 6 including 1 and 6 (other numbers are allowed as inputs to test)");// enter numbers that will be inputed into the games check system
            for (int i = 0; i < 5; i++) 
            {
                try
                {
                    string temp = Console.ReadLine();
                    Values.Add(Convert.ToInt32(temp));
                }
                catch (FormatException)
                {
                    Console.WriteLine("invalid input");// if a letter is inputed it says "invalid input" and requests a new input
                    i -= 1;
                }
            }
            threeOrMore1.LINQCheck(Values);
            Console.WriteLine("three or more complete");
            sevensOut1.SevensOutLoop();
            Console.WriteLine("sevens out complete");
        }
    }
}
