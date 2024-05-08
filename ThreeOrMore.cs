using CMP1903_A1_2324;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_ASSESMENT_2
{
    internal class ThreeOrMore
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
        public bool Globalcount
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

        public void ThreeOrMoreMain()
        {
            win = false;
            while (win == false)
            {

                globalcount = 0;
                turnover = false;
                ThreeOrMoreLoop();
                Console.WriteLine("your score is " + total);
            }
            Console.WriteLine("Win");
        }
        public void ThreeOrMoreLoop()
        {
            Die die1 = new Die();
            Die die2 = new Die();
            Die die3 = new Die();
            Die die4 = new Die();
            Die die5 = new Die();
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
        public void LINQCheck(List<int> Values, int Kind = 0)
        {
            globalcount = 0;
            int temp = 0;
            int count = 0;
            for (int i = 1; i < 7; i++)
            {
                var MostCommon = Values.Where(n => n == i);
                count = MostCommon.Count();
                if (count >= globalcount)
                {
                    if (i == Kind)
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
        public void ThreeOrMoreChoice(int temp)
        {
            if (globalcount < 2)
            {

            }
            else if (globalcount == 2 && turnover == false)
            {
                Console.WriteLine("press enter to reroll remaining, press any other key to reroll all");
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Die die1 = new Die();
                    Die die2 = new Die();
                    Die die3 = new Die();
                    var Values = new List<int>();
                    Values.Add(die1.Roll());
                    Thread.Sleep(1);
                    Values.Add(die2.Roll());
                    Thread.Sleep(1);
                    Values.Add(die3.Roll());
                    turnover = true;
                    LINQCheck(Values, temp);
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
        public void WinCheck()
        {
            if (total >= 20)
            {
                win = true;
            }
        }
    }
}
