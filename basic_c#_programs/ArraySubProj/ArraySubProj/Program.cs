using System;
using System.Collections.Generic;

namespace ArraySubProj
{
    class Program
    {
        static void Main()
        {
            // 1.
            string[] animals = { "Lion", "Tiger", "Bear", "Wolf", "Hamster" };
            Console.WriteLine("Pick a # 0-4");
            byte selectedNum = Convert.ToByte(Console.ReadLine());
            if (selectedNum >= 0 && selectedNum <= 4)
            {
                Console.WriteLine("You have chosen the " + animals[selectedNum]);
                Console.WriteLine("Press enter to continue.");
                _ = Console.ReadLine();

                // 2.
                int[] nums = { 42, 7, 9, 3, 45, 63, 42 };
                Console.WriteLine("Pick a # 0-6");
                byte selectedNum2 = Convert.ToByte(Console.ReadLine());
                if (selectedNum2 >= 0 && selectedNum2 <= 6)
                {
                    Console.WriteLine("This " + animals[selectedNum] + " will start with " + nums[selectedNum2] + " lives. Nice!");
                    Console.WriteLine("Press enter to continue.");
                    _ = Console.ReadLine();
                    // 3.
                    List<string> names = new List<string>
                    {
                        "George",
                        "Joe",
                        "Casper",
                        "Rudolph",
                        "Mickey",
                        "James",
                        "Esther"
                    };

                    Console.WriteLine("Pick a # 0-6");
                    byte selectedNum3 = Convert.ToByte(Console.ReadLine());
                    if (selectedNum3 >= 0 && selectedNum3 <= 6)
                    {
                        Console.WriteLine("Your " + animals[selectedNum] + " is now named " + names[selectedNum3] + ". Cute!");
                        Console.WriteLine(names[selectedNum3] + " the " + animals[selectedNum] + " has gone out and won you the game. Congrats!");
                        Console.WriteLine("Press enter to exit.");
                        _ = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("You have chosen a number outside of 0-6. You have failed, on the finish line no less. Better luck next time.");
                        Console.WriteLine("Press enter to exit.");
                        _ = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("You have chosen a number outside of 0-6. You have failed this game.");
                    Console.WriteLine("Press enter to exit.");
                    _ = Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("You have chosen a number outside of 0-4. You have failed this game.");
                Console.WriteLine("Press enter to exit.");
                _ = Console.ReadLine();
            }
        }
    }
}
