using CMP1903_A1_2324;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ASSESMENT_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThreeOrMore threeOrMore1 = new ThreeOrMore();
            SevensOut sevensOut1 = new SevensOut();
            ThreeOrMore threeOrMore2 = new ThreeOrMore();
            SevensOut sevensOut2 = new SevensOut();
            Testing testing = new Testing();
            Console.WriteLine("1: SinglePlayer Three Or More game \n2: SinglePlayer Sevens Out game \n3: Three or More game against the computer \n4: sevens out game against the computer \n5: 2 player three or more game \n6: 2 player sevens out game \n7: testing\n press any other key to close ");
            string temp = Console.ReadLine();
            int value1;
            int value2;
            string User1;
            string User2;
            switch (temp)// this is a lot of code but is quite repetitive, it is simply all the possible options listed above implemented
            {
                case "1":// a switch case has been used as it is more compact than if statements
                    Console.WriteLine("Enter your username");
                    threeOrMore1.ThreeOrMoreMain(Console.ReadLine());
                    break;
                case "2":
                    Console.WriteLine("Enter your username");
                    sevensOut1.SevensOutMain(Console.ReadLine());
                    break;
                case "3":
                    Console.WriteLine("Enter your username");
                    User1 = Console.ReadLine();
                    value1 = threeOrMore1.ThreeOrMoreMain(User1);
                    value2 = threeOrMore1.ThreeOrMoreMain("Computer Player");
                    if (value1 > value2)
                        Console.WriteLine(User1 + " won");
                    if (value1 < value2)
                        Console.WriteLine("Computer Player won");
                    if (value1 == value2)
                    {
                        Console.WriteLine("draw");
                    }
                    break;
                case "4":
                    Console.WriteLine("Enter your username");
                    User1 = Console.ReadLine();
                    value1 = sevensOut1.SevensOutMain(User1);
                    value2 = sevensOut2.SevensOutMain("Computer Player");
                    if (value1 > value2)
                        Console.WriteLine(User1 + " won");
                    if (value1 < value2)
                        Console.WriteLine("Computer Player won");
                    if (value1 == value2)
                    {
                        Console.WriteLine("draw");
                    }
                    break;
                case "5":
                    Console.WriteLine("Enter Player 1's username");
                    User1 = Console.ReadLine();
                    value1 = threeOrMore1.ThreeOrMoreMain(User1);
                    Console.WriteLine("Enter Player 2's username");
                    User2 = Console.ReadLine();
                    value2 = threeOrMore2.ThreeOrMoreMain(User2);
                    if (value1 > value2)
                        Console.WriteLine(User1 + " won");
                    if (value1 < value2)
                        Console.WriteLine(User2 + "won");
                    if (value1 == value2)
                    {
                        Console.WriteLine("draw");
                    }
                    break;
                case "6":
                    Console.WriteLine("Enter Player 1's username");
                    User1 = Console.ReadLine();
                    value1 = sevensOut1.SevensOutMain(User1);
                    Console.WriteLine("Enter Player 2's username");
                    User2 = Console.ReadLine();
                    value2 = sevensOut2.SevensOutMain(User2);
                    if (value1 > value2)
                        Console.WriteLine(User1 + " won");
                    if (value1 < value2)
                        Console.WriteLine(User2 + "won");
                    if (value1 == value2)
                    {
                        Console.WriteLine("draw");
                    }
                    break;
                case "7":
                    testing.Test();
                    break;
            }
        }
    }
}
