using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1,2,3,4 };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5,6,7 });
            // foreach (var number in numbers)
            // {
            //     Console.WriteLine(number);
            // }
            //
            // // Interesting there are two '1' in the array - index of will tell us the index of the first item
            // // Which is the first item in the array so returns 0
            // Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            //
            // // Or find the last index of 1 - which returns a 4
            // Console.WriteLine("Last index of 1: " + numbers.LastIndexOf(1));
            //
            // // How many numbers in the list
            // Console.WriteLine("Count: " + numbers.Count);
            //
            // // Removes the first instance of 1
            // numbers.Remove(1);
            // foreach (var number in numbers)
            // {
            //     Console.WriteLine(number);
            // }
            //
            // Removes all instances of 1
            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            
            // clears all items in list
            numbers.Clear();
            Console.WriteLine("Items in list - " + numbers.Count);
            
        }
    }
}

