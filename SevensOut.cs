﻿using CMP1903_A1_2324;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_ASSESMENT_2
{
    internal class SevensOut
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
            set { Win = true; }
        }
        public void SevensOutMain() 
        {
            win = true;
            SevensOutLoop();
            Console.WriteLine("Do you want to keep rolling");
            while (win)
            {
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    SevensOutLoop();
                }
            }
        }
        public void SevensOutLoop()
        {
            Die die1 = new Die();
            int temp1 = die1.Roll();
            Thread.Sleep(1);
            Die die2 = new Die();
            int temp2 = die1.Roll();
            if ((temp1 + temp2) == 7)
            {
                Console.WriteLine("You rolled a 7 game over");
                win = false;
            }
            else if (temp1 == temp2)
            {
                Console.WriteLine("You rolled a double, double points!");
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
