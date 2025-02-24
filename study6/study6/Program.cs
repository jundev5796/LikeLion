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
            // binary to integer
            Console.Write("Input binary: ");
            string binaryInput = Console.ReadLine(); // input as string
            int decimalValue = Convert.ToInt32(binaryInput, 2); // 2 -> 10

            // integer to binary
            string binaryOutput = Convert.ToString(decimalValue, 2); // 10 -> 2

            Console.WriteLine($"Enter binary: {binaryInput}");
            Console.WriteLine($"Convert to decimal: {decimalValue}");
            Console.WriteLine($"Convert back to binary: {binaryInput}");
        }
    }
}
