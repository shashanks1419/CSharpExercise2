﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise2
{
    class EvenOROdd
    {
        public static void Main2()
        {
            int num1, rem1;
            Console.Write("Test data : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            rem1 = num1 % 2;
            if (rem1 == 0)
            {
                Console.WriteLine("Expected output:");
                Console.WriteLine("{0} is an even integer.\n", num1);
            }
            else
            {
                Console.WriteLine("Expected output:");
                Console.WriteLine("{0} is an odd integer.\n", num1);
            }
            Console.ReadKey();
        }

    }
}
