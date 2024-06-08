namespace Iterations

{
    class Program
    {
        public static void EvenNumbersGoingUp()
        {
            for (var i = 1; i <= 10; i++)
            {
                // If i is devisible by 2
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void EvenNumbersGoingDown()
        {
            for (var i = 10; i >= 1; i--)
            {
                // If i is devisible by 2
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void ForLoop()
        {
            var name = "Glen Miller";
            for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
        }

        public static void ForEachLoop()
        {
            var name = "Glen Miller";
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }
        }

        public static void Array()
        {
            var numbers = new int[] { 1, 2, 3, 4 };
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        
        public static void EvenNumbersGoingUpDoWhile()
        {
            var i = 0;
            while (i <= 10)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }

        public static void DisplayName()
        {
            while (true)
            {
                Console.WriteLine("Write your name");
                var input = Console.ReadLine();
                
                if (!string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Name is " + input);
                    // Continue goes back to the start of the loop - we don't get to the break
                    continue;
                }

                // If the user just hits enter then input value is null - so now we break out of the loop
                break;
            }
        }
        
        static void Main(string[] args)
        {
            // EvenNumbersGoingUp();
            // EvenNumbersGoingDown();
            // ForLoop();
            // ForEachLoop();
            // Array();
            // EvenNumbersGoingUpDoWhile();
            DisplayName();
        }
    }
}

