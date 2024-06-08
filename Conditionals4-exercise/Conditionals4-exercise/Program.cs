namespace Conditionals4Exercise
{
    public class Program
    {
        /// <summary>
        /// Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters 
        /// a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in 
        /// applications where values entered into input boxes need to be validated.)
        /// </summary>
        public static void Exercise1()
        {
            Console.Write("Enter a number between 1 to 10: ");
            var input = Console.ReadLine();
            Console.WriteLine(string.Format("You entered: {0}", input));
            var number = Convert.ToInt32(input);
            
            // if number is of type int display Valid
            // else display invalid
            if (number > 0 && number < 11)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        /// <summary>
        /// Write a program which takes two numbers from the console and displays the maximum of the two.
        /// </summary>
        public static void Exercise2()
        {
            Console.WriteLine("Please enter a number");
            var firstInput = Console.ReadLine();
            var firstNumber = Convert.ToInt32(firstInput);
            Console.WriteLine("Please enter another number");
            var secondInput = Console.ReadLine();
            var secondNumber = Convert.ToInt32(secondInput);
            Console.WriteLine(string.Format("The numbers you entered were {0} and {1}", firstNumber, secondNumber));

            var biggestNumber = firstNumber > secondNumber ? firstNumber : secondNumber;
            Console.WriteLine(string.Format("The biggest number is {0}", biggestNumber));
        }

        /// <summary>
        /// Write a program and ask the user to enter the width and height of an image. Then tell if the image 
        /// is landscape or portrait.
        /// </summary>
        public static void Exercise3()
        {
            Console.WriteLine("What is the width of the image?");
            var widthInput = Console.ReadLine();
            var width = Convert.ToInt32(widthInput);
            Console.WriteLine("What is the height of the image?");
            var heightInput = Console.ReadLine();
            var height = Convert.ToInt32(heightInput);
            Console.WriteLine(string.Format("The width of the image is {0} and the height of the image is {1}", width, height));
            
            // if width is larger than height then the image is landscape, else image is portrait
            var isImageLandscape = width > height ? true : false;
            if(isImageLandscape)
            {
                Console.WriteLine("Image is landscape");
            }
            else
            {
                Console.WriteLine("Image is portrait");
            }
        }
        
        /// <summary>
        /// Same as before but use enums
        /// </summary>

        public enum ImageFormat
        {
            Portrait,
            Landscape
        }
        public static void Exercise4()
        {
            Console.WriteLine("What is the width of the image?");
            var width = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("What is the height of the image?");
            var height = Convert.ToInt32(Console.ReadLine());

            var imageFormat = width > height ? ImageFormat.Landscape : ImageFormat.Portrait;
            Console.WriteLine("The image format is " + imageFormat);
        }

        /// <summary>
        /// Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, 
        /// etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, 
        /// the program asks for the speed of a car. If the user enters a value less than the speed limit, program should 
        /// display Ok on the console. If the value is above the speed limit, the program should calculate the number of 
        /// demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on 
        /// the console. If the number of demerit points is above 12, the program should display License Suspended.
        /// </summary>
        public static void Exercise5()
        {
            // Set the speed limit
            Console.WriteLine("Please set the speed limit");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The speed limit is set to {0}", speedLimit);
            
            // What is the speed of the car?
            Console.WriteLine("What is the speed of the car?");
            var carSpeed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The speed of the car is {0}", carSpeed);
            
            // Are you speeding?
            var isCarSpeeding = carSpeed > speedLimit ? true : false;

            // If you're speeding then they receive 1 demerit point for every 5km/hr over the speed limit
            if (isCarSpeeding)
            {
                var howMuchOver = carSpeed - speedLimit;
                Console.WriteLine("You were {0}km/h over the speed limit", howMuchOver);

                var howManyPoints = howMuchOver / 5;
                
                // If the number of demerit points is above 12 display License Suspended
                var moreThan12 = howManyPoints >= 12 ? true : false;
                if (moreThan12)
                {
                    Console.WriteLine("You receive {0} demerit points - License Suspended!", howManyPoints);
                }
                else
                {
                    Console.WriteLine("You receive {0} demerit points", howManyPoints);
                }
                
            }
            else
            {
                Console.WriteLine("You weren't speeding - well done");
            }
        }
        
        static void Main(string[] args)
        {
            Exercise5();
        }
    }
}