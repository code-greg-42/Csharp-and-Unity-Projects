using System;

namespace PackageExpress
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped. Have a good day.");
                _ = Console.ReadLine();
            } else
            {
                Console.WriteLine("Please enter the package width:");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                int length = Convert.ToInt32(Console.ReadLine());
                if ((width + height + length) > 50)
                {
                    Console.WriteLine("Package to big to be shipped via Package Express.");
                    _ = Console.ReadLine();
                } else
                {
                    int hwl = width * height * length;
                    float prod = hwl * weight / 100f;
                    string quote = prod.ToString("c2");
                    Console.WriteLine("Your estimated shipping cost is: " + quote);
                    _ = Console.ReadLine();
                }
            }

        }
    }
}
