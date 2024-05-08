using CMP1903_A1_2324;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_ASSESMENT_2
{
    internal class ThreeOrMore : GameClass
    {

            private int total;
            public int Total
            {
                get { return Total; }
                set { Total = 0; }
            }
            private bool win;
            public bool Win
            {
                get { return Win; }
                set { Win = false; }
            }
            private int globalcount;
            public int Globalcount
            {
                get { return Globalcount; }
                set { Globalcount = value; }
            }
            private bool turnover;
            public bool TurnOver
            {
                get { return TurnOver; }
                set { TurnOver = value; }
            }
            private string username;
            public string Username
            {
                get { return Username; }
                set { Username = value; }
            }
            private int turn;
            public int Turn
            {
                get { return Turn; }
                set { Turn = value; }
            }

            public int ThreeOrMoreMain(string User)// the main function that controls the logic of the game
        {
            if (User == "")// defaults to the name "player" if nothing is typed for the username
            {
                User = "player";
            }
            username = User;
            Console.WriteLine(username + "'s turn");
            total = 0;
            turn = 0;
            win = false;
            while (!win)// whilst the player hasnt won keep going
            {

                globalcount = 0;
                turnover = false;
                ThreeOrMoreLoop();
                Console.WriteLine("your score is " + total);
            }
            Console.WriteLine(username + " reached 20 in " + turn + " turns");
            return turn;
        }
        public void ThreeOrMoreLoop()// the main loop of the games logic
        {
            turn += 1;//increments turn by 1
            Console.WriteLine("Press enter to roll");
            if (Console.ReadKey().Key == ConsoleKey.Enter)// instantiates 5 die and rolls all of them
            {
 
                var Values = new List<int>();
                Values.Add(die1.Roll());
                Thread.Sleep(1);
                Values.Add(die2.Roll());
                Thread.Sleep(1);
                Values.Add(die3.Roll());
                Thread.Sleep(1);
                Values.Add(die4.Roll());
                Thread.Sleep(1);
                Values.Add(die5.Roll());
                LINQCheck(Values);
            }
            else
            {
                Console.WriteLine("invalid input");
                ThreeOrMoreLoop();
            }
        }
        public void LINQCheck(List<int> Values, int Kind = 0)// checks through the values rolled
        {
            globalcount = 0;
            int temp = 0;
            int count = 0;
            for (int i = 1; i < 7; i++)
            {
                var MostCommon = Values.Where(n => n == i);// takes all values of a given number
                count = MostCommon.Count();// count how many there of that number
                if (count >= globalcount)
                {
                    if (i == Kind)// Kind is used to add on values already rolled if a 2 is rolled and the player chooses to only roll remaining die
                    {
                        count += 2;
                    }
                    temp = i;
                    globalcount = count;
                }

            }
            Console.WriteLine(globalcount + " of a kind of " + temp);
            ThreeOrMoreChoice(temp);
        }
        private void ThreeOrMoreChoice(int temp)
        {

            if (globalcount == 2 && turnover == false)
            {
                Console.WriteLine("press enter to reroll remaining, press any other key to reroll all");
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {

                    var Values = new List<int>();
                    Values.Add(die1.Roll());
                    Thread.Sleep(1);
                    Values.Add(die2.Roll());
                    Thread.Sleep(1);
                    Values.Add(die3.Roll());
                    turnover = true;
                    LINQCheck(Values, temp);// if a 2 is rolled it passes on the kind as a value called temp
                }
                else
                {
                    turnover = true;
                    ThreeOrMoreLoop();
                }
            }
            else if (globalcount == 3)
            {
                total += 3;
            }
            else if (globalcount == 4)
            {
                total += 6;
            }
            else if (globalcount == 5)
            {
                total += 12;
            }
            WinCheck();
        }
        private void WinCheck()
        {
            if (total >= 20)
            {
                win = true;
            }
        }
    }
}
