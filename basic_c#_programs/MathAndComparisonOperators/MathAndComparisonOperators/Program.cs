﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Five minus Ten = " + difference.ToString());
            //Console.ReadLine();

            //bool trueOrFalse = 12 > 5;
            //Console.WriteLine(trueOrFalse);
            //Console.ReadLine();

            int roomTemperature = 70;
            int currentTemperature = 70;

            bool isWarm = currentTemperature != roomTemperature;
            Console.WriteLine(isWarm);
            Console.ReadLine();
        }
    }
}
