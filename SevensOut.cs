using CMP1903_A1_2324;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_ASSESMENT_2
{
    internal class SevensOut: GameClass
    {
        private string username;// current players username
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private int turn;// turncount to count the number of goes that have occured
        public int Turn
        {
            get { return turn; }
            set { turn = value; }
        }
        private bool win;
        public bool Win
        {
            get { return win; }
            set { win = value; }
        }
        private int total;// turncount to count the number of goes that have occured
        public int Total
        {
            get { return total; }
            set { total = value; }
        }
        public int SevensOutMain(string User) // the main function that controls most of the game logic
        {
            if (User == "")
            {
                User = "player";
            }
            turn = 0;
            username = User;
            Console.WriteLine(username + "'s turn");
            win = false;
            SevensOutLoop();
            Console.WriteLine("Do you want to keep rolling");
            while (!win)// while loop keeps rolling until win is true because a 7 was rolled
            {
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    SevensOutLoop();
                }
            }
            Console.WriteLine(username + " Lasted " + turn + " rounds");
            return total;
        }
        public void SevensOutLoop(int val1 = 0,int val2 = 0, bool Test = false)
        {
            turn += 1;
            Die die1 = new Die();
            int temp1 = die1.Roll();
            Thread.Sleep(1);
            Die die2 = new Die();
            int temp2 = die1.Roll();
            if (Test)
            {
                temp1 = val1;
                temp2 = val2;
            }
            if ((temp1 + temp2) == 7)
            {
                Console.WriteLine("You rolled a 7 game over");// if a 7 is rolled set win to true to end the game
                win = true;
            }
            else if (temp1 == temp2)
            {
                Console.WriteLine("You rolled a double, double points!");// rewards double points
                temp1 *= 2;
                temp2 *= 2;
                total += temp1 + temp2;
            }
            else
            {
                
                total += temp1 + temp2;
            }

            Console.WriteLine("Current total is " + total);
        }
    }
}
