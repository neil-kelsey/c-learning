namespace arraysMultiDimentional
{
    class Public
    {
        static void Main(string[] args)
        {
            // Previously I've done new int[] but you can make it shorter with new[]
            var numbers = new[] { 3, 7, 9, 2, 14, 6 };
            
            // length
            Console.WriteLine(numbers.Length);
            
            // indexOf()
            // 9 is the 3rd element in the array - so an index of 2
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9 - where in the array is '9' - " + index);
            
            // Clear()
            // Clear the first two items from the array
            // 0 is the starting array item and 2 is how many items we want to clear
            Array.Clear(numbers, 0, 2);

            // The first two items are not removed - only cleared
            // If this was an array of booleans
            // We would set first 2 to false
            Console.WriteLine("Cleared not removed - ");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            
            // copy()
            // We copy the first three items of the previous array
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            {
                foreach (var number in another)
                {
                    Console.WriteLine("Copied first three - " + number);
                }
            }
            
            // sort()
            Array.Sort(numbers);
            {
                foreach (var number in numbers)
                {
                    Console.WriteLine("Sorted original array - " + number);
                }
            }
            
            // reverse()
            Array.Reverse(numbers);
            {
                foreach (var number in numbers)
                {
                    Console.WriteLine("Reverse original array - " + number);
                }
                {
                    
                }
            }
        }
    }
}