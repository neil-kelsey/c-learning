namespace ControlFlowExercises
{
    class Program
    {
        // Exercise 01 Summary
        // Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.
        public static void Divisible()
        {
            int counter = 0;
            int numberToDivideTo = 100;
            int numberToDivideBy = 3;
            
            for (var i = 1; i <= numberToDivideTo; i++)
            {
                if (i % numberToDivideBy == 0)
                {
                    Console.WriteLine(i);
                    counter++;
                }
            }
            Console.WriteLine("The amount of numbers are " + counter);
        }
        
        // Exercise 2 summary
        // Write a program and continuously ask the user to enter a number or "ok" to exit.
        // Calculate the sum of all the previously entered numbers and display it on the console.
        public static void SumUsersNumbers()
        {
            var accumulatingNumber = 0;

            while (true)
            {
                Console.WriteLine(string.Format("Give a number to add to our starting number of {0} or type 'ok' to exit", accumulatingNumber));
                var numberToAddInput = Console.ReadLine();
                if (numberToAddInput == "ok")
                {
                    break;
                }
                else
                {
                    var numberToAdd = int.Parse(numberToAddInput);
                    var newNumber = accumulatingNumber + numberToAdd;
                    Console.WriteLine(string.Format("{0} plus {1} equals {2}", accumulatingNumber, numberToAdd, newNumber));
                    accumulatingNumber = newNumber;
                }
            }
        }
        
        // Exercise 3 summary
        // Write a program and ask the user to enter a number.
        // Compute the factorial of the number and print it on the console.
        // For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

        public static void Factorial()
        {
            Console.Write("Enter a number: ");
            var number = Convert.ToInt32(Console.ReadLine());

            // I think this does it in reverse
            // 1x2x3x4x5 which still gives the same value
            // And while the statement is true the loop takes the fractoral value and times it
            // by the new value of i until the statement isn't true
            
            var factorial = 1;
            for (var i = 1; i <= number; i++)
                factorial *= i;

            Console.WriteLine("{0}! = {1}", number, factorial);
        }

        /// <summary>
        /// Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
        /// If the user guesses the number, display “You won". Otherwise, display “You lost".
        /// </summary>

        public static void GuessNumber()
        {
            var numberOfGuesses = 4;
            var randomNumber = new System.Random().Next(1,10);
            
            // Useful for debuging
            // Console.WriteLine("The random number is " + randomNumber);
            for (var i = 1; i <= numberOfGuesses; i++)
            {
                Console.WriteLine("Guess the random number");
                var guess = int.Parse(Console.ReadLine());
                if (guess == randomNumber)
                {
                    Console.WriteLine("You guessed it right! Well done");
                    break;
                }
                else
                {
                    if (i == numberOfGuesses)
                    {
                        Console.WriteLine("Wrong! Better luck next time");
                    }
                    else
                    {
                        Console.WriteLine(string.Format("Wrong! That was guess number {0}, try again", i) );
                    }
                    
                }
            }
        }

        /// <summary>
        /// Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the 
        /// numbers and display it on the result. For example, if the user enters “5, 3, 8, 1, 4", the program should 
        /// display 8 on the console.
        /// </summary>

        public static void FindMaxNumber()
        {
            Console.Write("Enter commoa separated numbers: ");
            var input = Console.ReadLine();

            var numbers = input.Split(',');
            
            // Assume the first number is the max 
            var max = Convert.ToInt32(numbers[0]);

            foreach (var stringNumber in numbers)
            {
                var number = int.Parse(stringNumber);
                if (number > max)
                {
                    // if the number is bigger than the max
                    // replace the max
                    max = number;
                }
            }
            Console.WriteLine("Max is " + max);
        }
        
        static void Main(string[] args)
        {
            // Divisible();
            // SumUsersNumbers();
            // Factorial();
            // GuessNumber();
            FindMaxNumber();
        }
    }
}

