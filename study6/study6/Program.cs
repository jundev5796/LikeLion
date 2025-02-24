﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study6
{
    class Program
    {
        static void Main(string[] args)
        {
            // binary to integer (not used a lot)
            //Console.Write("Input binary: ");
            //string binaryInput = Console.ReadLine(); // input as string
            //int decimalValue = Convert.ToInt32(binaryInput, 2); // 2 -> 10

            //// integer to binary
            //string binaryOutput = Convert.ToString(decimalValue, 2); // 10 -> 2

            //Console.WriteLine($"Enter binary: {binaryInput}");
            //Console.WriteLine($"Convert to decimal: {decimalValue}");
            //Console.WriteLine($"Convert back to binary: {binaryInput}");

            // var
            //var name = "Alice";
            //var age = 25;
            //var isStudent = true;

            //Console.WriteLine($"name: {name}, age: {age}, student_check: {isStudent}");

            // default (not used a lot)
            //int defaultInt = default;
            //string defaultString = default;
            //bool defaultBool = default;

            //Console.WriteLine($"int default: {defaultInt}");
            //Console.WriteLine($"string default: {defaultString}");
            //Console.WriteLine($"bool default: {defaultBool}");

            // operator
            //int a = 5, b = 3;
            //int plus = a + b; // add
            //int minus = a - b; // subtract
            //int mult = a * b; // multiply
            //int div = a / b; // divide
            //int rem = a % b; // remainder
            //bool isEqual = (a == b);

            //Console.WriteLine($"Sum: {plus}"); // output: 8
            //Console.WriteLine($"Sum: {minus}"); // output: 2
            //Console.WriteLine($"Sum: {mult}"); // output: 15
            //Console.WriteLine($"Sum: {div}"); // output: 1
            //Console.WriteLine($"Sum: {rem}"); // output: 2
            //Console.WriteLine($"Is a and b equal? {isEqual}"); // output: False

            // checking odd/even
            //int num = 7;
            //int sum = 0;

            //sum = num % 2;
            //Console.WriteLine("Odd or Even: " + sum);

            // relational operator
            //bool isEqual = false;

            //int a = 5;
            //int b = 2;

            //isEqual = (a == b);

            //Console.WriteLine("Same? " + isEqual);

            //// unary operator
            //int number = 5;
            //Console.WriteLine(+number); // positive: 5
            //Console.WriteLine(-number); // negative: -5

            //// !
            //bool flag = true;
            //Console.WriteLine(!flag); // reverse: False

            //// ~ -> -(x + 1)
            //int num = 10;
            //int result = ~num; // -(10 + 1) = -11
            //Console.WriteLine("Original Number: " + num);
            //Console.WriteLine("With ~: " + result);

            // conversion operator
            double pi = 3.14;
            int integerPi = (int)pi; // convert double to int

            Console.WriteLine(integerPi); // output: 3
        }
    }
}
