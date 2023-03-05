using System;
using System.Collections.Generic;

namespace IterationProject
{
    class Program
    {
        static void Main()
        {
            //int[] testScores = { 98, 99, 85, 70, 83, 34, 91, 90, 94 };

            //for (int i = 0; i < testScores.Length; i++ )
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //}
            //Console.ReadLine();

            //string[] names = { "Greg", "Phyllis", "Adam", "Daniel", "Rick" };

            //for (int j = 0; j < names.Length; j++)
            //{
            //    if (names[j].Length == 4)
            //    {
            //        Console.WriteLine(names[j]);
            //    }
            //}
            //_ = Console.ReadLine();

            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(81);
            //testScores.Add(72);
            //testScores.Add(70);

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("passing test score: " + score);
            //    }
            //}

            //List<string> names = new List<string>() { "Greg", "Phyllis", "Adam", "Daniel" };

            //foreach (string name in names)
            //{
            //    if (name == "Greg")
            //    {
            //        Console.WriteLine(name);
            //    }
            //}
            //Console.ReadLine();

            List<int> testScores = new List<int>() {  98, 99, 12, 74, 23, 99 };
            List<int> passingScores = new List<int>();

            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }
            Console.WriteLine(passingScores.Count);
            _ = Console.ReadLine();
        }
    }
}
