namespace ListsExercises
{
    class Program
    {
        // Write a program and continuously ask the user to enter different names,
        // until the user presses Enter (without supplying a name).
        // Depending on the number of names provided, display a message based on the above pattern.
        public static void SocialNames()
        {
            Console.WriteLine("No one likes your post");
            // Create empty names list
            var namesArray = new List<string>();
            
            while (true)
            {
                Console.WriteLine("Enter your name");
                var likedName = Console.ReadLine();

                if (string.IsNullOrEmpty(likedName))
                {
                    break;
                }
                
                namesArray.Add(likedName);
                
                if(namesArray.Count == 1)
                {
                    Console.WriteLine(namesArray[0] + " likes your post");
                }
                else if(namesArray.Count == 2)
                {
                    Console.WriteLine(string.Format("{0} and {1} like your post", namesArray[0], namesArray[1]));
                }
                else if (namesArray.Count >= 3)
                {
                    var everyoneElse = namesArray.Count - 2;
                    Console.WriteLine(string.Format("{0}, {1} and {2} others like your post", namesArray[0], namesArray[1], everyoneElse));
                }
            }
        }

        /// <summary>
        /// Ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. 
        /// Display the reversed name on the console.
        /// </summary>

        public static void ReverseName()
        {
            // Enter a name
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine(name);

            Console.WriteLine(name[0]);

            // find the length of that name
            // create an empty array that long
            var nameArray = new char[name.Length];

            Console.WriteLine("The name has " + nameArray.Length + " characters");
            
            // iterate over each item and add the letter to the array
            for (var i = 0; i <+ nameArray.Length;  i++)
            {
                Console.WriteLine(name[i]);
                nameArray[i] = name[i];
            }

            // reverse the array
            Array.Reverse(nameArray);
            
            var reversedName = new string(nameArray);
            Console.WriteLine("Name reversed is - " + reversedName);
        }
        
        // Write a program and ask the user to enter 5 numbers.
        // If a number has been previously entered, display an error message and ask the user to re-try.
        // Once the user successfully enters 5 unique numbers, sort them and display the result on the console.


        public static void UniqueNumbers()
        {

            // Create empty list
            var numbersArray = new List<int>();

            while (true)
            {
                if (numbersArray.Count == 5)
                {
                    Console.WriteLine("You've now entered 5 unique numbers");
                    numbersArray.Sort();
                    var sortedArrayString = string.Join(",", numbersArray);
                    Console.WriteLine("Here are your numbers sorted smallest to highest - " + sortedArrayString);
                    break;
                }
                Console.WriteLine("Please enter 5 unique numbers");
                // Take users input, convert string to int
                var userNumber = int.Parse(Console.ReadLine());
                
                // If the users input is already in the list display error
                if (numbersArray.Contains(userNumber))
                {
                    Console.WriteLine(userNumber + " is not a unique number, try again");
                }
                else
                {
                    numbersArray.Add(userNumber);
                    Console.WriteLine("You entered " + userNumber);
                }
            }
        }
        
        // Skipping these two due to time constraints
        
        //4- Write a program and ask the user to continuously enter a number or type "Quit" to exit.
        //The list of numbers may include duplicates. Display the unique numbers that the user has entered.
        
        // 5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
        // If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise,
        // display the 3 smallest numbers in the list.
        
        static void Main(string[] args)
        {
            // SocialNames();
            // ReverseName();
            UniqueNumbers();
        }
    }
}