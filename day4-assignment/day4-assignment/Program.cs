﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Problem #1

            //// Choose a job
            //// 1. Warrior
            //// 2. Mage
            //// 3. Thief

            //Console.WriteLine("Choose a Job (1. Warrior 2. Mage 3. Thief: ");
            //int job = int.Parse(Console.ReadLine());
            //switch (job)
            //{
            //    case 1:
            //        Console.WriteLine("Warrior");
            //        Console.WriteLine("ATK: 100");
            //        Console.WriteLine("DEF: 90");
            //        break;
            //    case 2:
            //        Console.WriteLine("Mager");
            //        Console.WriteLine("ATK: 110");
            //        Console.WriteLine("DEF: 80");
            //        break;
            //    case 3:
            //        Console.WriteLine("Thief");
            //        Console.WriteLine("ATK: 115");
            //        Console.WriteLine("DEF: 70");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Day");
            //        break;
            //}

            //// Problem #2
            //for (int i = 0; i <= 9; i++)
            //{
            //    Console.WriteLine($"Number: {i}");
            //}

            // Problem #3
            int sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }

            Console.WriteLine($"Total: {sum}");
        }
    }
}
