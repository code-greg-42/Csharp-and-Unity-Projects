using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main()
        {
            string[] words = { "the", "quick", "brown", "fox", "jumped", "over", "the", "lazy", "dog" };
            Console.WriteLine("please type your favorite 4-letter word");
            string favWord = Console.ReadLine();

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i] + favWord;
            }
            for (int j = 0; j < words.Length; j++)
            {
                Console.WriteLine(words[j]);
            }
            Console.WriteLine("Press enter to continue.");
            _ = Console.ReadLine();

            //comment below was infinite loop
            //for (int a = 0; a > -1; a++)
            for (int a = 0; a < 10; a++)
            {
                //if (a % 10000 == 0) {
                Console.WriteLine("wooooohooooooo");
                //}
            }
            Console.WriteLine("Press enter to continue.");
            _ = Console.ReadLine();

            // while loop with < and <= operators
            int targetNum = 42;
            int counter = 0;
            while (counter < targetNum)
            {
                Console.WriteLine(counter);
                counter++;
            }
            Console.WriteLine("Press enter to continue.");
            _ = Console.ReadLine();
            // now counter must pass target
            int targetNum2 = 42;
            int counter2 = 0;
            while (counter2 <= targetNum2)
            {
                Console.WriteLine(counter2);
                counter2++;
            }
            Console.WriteLine("Press enter to continue.");
            _ = Console.ReadLine();

            // step 194 -- lists
            List<string> uniqueWords = new List<string>() { "blizzard", "flood", "avalanche", "earthquake", "tsunami", "hurricane", "tornado", "drought", "landslide" };
            Console.WriteLine("Enter a type of natural disaster. We'll let you know if it's included in the official list.");
            string userChoice = Console.ReadLine().ToLower();
            // easier way using method
            //int choiceIndex = uniqueWords.IndexOf(userChoice);

            // loop for IndexOf
            int choiceIndex = -1;
            for (int i = 0; i < uniqueWords.Count; i++)
            {
                if (uniqueWords[i] == userChoice)
                {
                    choiceIndex = i;
                    break;
                }
            }
            // is the user's input in the list ?
            if (choiceIndex == -1)
            {
                Console.WriteLine("Unfortunately, that choice is not listed on the official natural disasters page.");
            } else
            {
                Console.WriteLine("Your choice of " + userChoice + " is in index " + choiceIndex + " of the list.");
            }
            Console.WriteLine("Press enter to continue.");
            _ = Console.ReadLine();

            // step 195 - lists but without uniqueness. find all indices of an input
            List<string> nonUniqueWords = new List<string>() { "blizzard", "flood", "blizzard", "avalanche", "earthquake", "earthquake", "tsunami", "earthquake", "hurricane", "earthquake", "tornado", "tornado", "drought", "landslide" };
            Console.WriteLine("Enter a type of natural disaster. We'll let you know where it's included in the list of recent disasters.");
            string userChoice2 = Console.ReadLine().ToLower();
            Console.WriteLine("Your choice of " + userChoice2 + " is listed at the following indices:");

            // loop for indices
            List<int> inputIndices = new List<int>();
            for (int i = 0; i < nonUniqueWords.Count; i++)
            {
                if (nonUniqueWords[i] == userChoice2)
                {
                    inputIndices.Add(i);
                    Console.WriteLine(i);
                }
            }
            // is the user's input in the list ?
            if (inputIndices.Count == 0)
            {
                Console.WriteLine("Unfortunately, that choice is not listed on the official natural disasters page.");
            }
            // other way but uses double loop
            //Console.WriteLine("Your choice of " + userChoice2 + " is in the following indices:");
            //for (int j = 0; j < inputIndices.Count; j++)
            //{
            //    Console.WriteLine(inputIndices[j]);
            //}
            Console.WriteLine("Press enter to continue.");
            _ = Console.ReadLine();

            // step 196 - foreach loop
            List<string> randomWords = new List<string>() { "in", "general", "a", "general", "has", "the", "role", "of", "a", "leader" };
            List<string> alreadyUsed = new List<string>();
            foreach (string word in randomWords)
            {
                Console.WriteLine(word);
                if (alreadyUsed.Contains(word) == true)
                {
                    Console.WriteLine("This word has already appeared in the list.");
                } else
                {
                    Console.WriteLine("This is the first occurence of this word.");
                    alreadyUsed.Add(word);
                }
            }
            Console.WriteLine("Press enter to exit the program.");
            _ = Console.ReadLine();
        }
    }
}
