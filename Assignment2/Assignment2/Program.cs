﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Problem #1
            //Console.Write("Korean: ");
            //int scoreKor = int.Parse(Console.ReadLine());
            //Console.Clear();

            //Console.Write("English: ");
            //int scoreEng = int.Parse(Console.ReadLine());
            //Console.Clear();

            //Console.Write("Math: ");
            //int scoreMath = int.Parse(Console.ReadLine());
            //Console.Clear();

            //int sum = scoreKor + scoreEng + scoreMath;
            //float avg = sum / 3;

            //Console.WriteLine("Score \n");

            //Console.WriteLine("Korean: " + scoreKor);
            //Console.WriteLine("English: " + scoreEng);
            //Console.WriteLine("Math: " + scoreMath + "\n");

            //Console.WriteLine("Total: " + sum);
            //Console.WriteLine("Average: " + avg.ToString("F2"));
            //Console.WriteLine("\n");

            /////////////////////////////////////////////////////////////////////

            //// Problem #2
            //int num = 0;

            //Console.Write("Enter an Integer: ");
            //num = int.Parse(Console.ReadLine());

            //Console.WriteLine("Your Input: " + num);
            //Console.WriteLine("Inverted Value: " + ~num);

            /////////////////////////////////////////////////////////////////////

            //// Problem #3
            //Console.Write("Your Money: ");
            //string character = "Lion";
            //int money = int.Parse(Console.ReadLine());
            //string weapon = default;
            //int atk = 0;
            //Console.Write("\n");

            //if (money >= 0 && money <= 100)
            //{
            //    weapon = "무한의 대검";
            //    atk += 1;
            //}
            //else if (money >= 101 && money <= 200)
            //{
            //    weapon = "카타나";
            //    atk += 2;
            //}
            //else if (money >= 201 && money <= 300)
            //{
            //    weapon = "진은검";
            //    atk += 3;
            //}
            //else if (money >= 301 && money <= 400)
            //{
            //    weapon = "집판검";
            //    atk += 4;
            //}
            //else if (money >= 401 && money <= 500)
            //{
            //    weapon = "엑스칼리버";
            //    atk += 5;
            //}
            //else if (money >= 501 && money <= 600)
            //{
            //    weapon = "유령검";
            //    atk += 6;
            //}
            //else if (money > 600)
            //{
            //    weapon = "전설의 검";
            //    atk += 7;
            //}
            //else
            //{
            //    Console.WriteLine("No more choices!");
            //}

            //string final_weapon = weapon + " " + "+" + atk;

            //Console.WriteLine($"Character: {character}");
            //Console.WriteLine($"Weapon: {final_weapon}");

            // Problem #4
            int a, b, c;
            int max_value = 0;

            Console.Write("1st Number: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("2nd Number: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("3rd Number: ");
            c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                max_value = a;
            }
            else if (b > a && b > c)
            {
                max_value = b;
            }
            else if (c > a && c > b)
            {
                max_value = c;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

            Console.WriteLine($"Max Value: " + max_value);
            Console.Write("\n");

            // Problem #5
            string grade = default;
            Console.Write("What is your score? ");
            int score = int.Parse(Console.ReadLine());

            if (score >= 90)
            {
                grade = "A";
            }
            else if (score >= 80 && score <= 89)
            {
                grade = "B";
            }
            else if (score >= 70 && score <= 79)
            {
                grade = "C";
            }
            else if (score >= 60 && score <= 69)
            {
                grade = "B";
            }
            else if (score < 60)
            {
                grade = "F";
            }

            Console.WriteLine($"Grade: " + grade);
        }
    }
}
