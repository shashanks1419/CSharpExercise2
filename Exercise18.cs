﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise2
{
    class ques18
    {
        public static void Main2()
        {
            int i, j, rows, k = 1;

            
            Console.Write("Input number of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("{0} ", k++);
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
