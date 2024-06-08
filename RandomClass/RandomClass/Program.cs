using System;

namespace RandomNameSpace
{
    class Program
    {
        public static void RandomForLoop()
        {
            var random = new System.Random();
            for (var i = 0; i < 10; i++)
            {
                // We run this loop 10 times
                // Each time we generate a random number
                // If we did the following it gives us totally random numbers
                // Console.WriteLine(random.Next());
                // Or we can give the .Next a range - give me numbers between 1 and 10
                Console.WriteLine(random.Next(1, 10));
            }
        }

        public static void NumbersToStrings()
        {
            // Next if you example I want to just console log an a
            Console.WriteLine("a");
                
            // But I then want to cast that to an integer, this will give me the ascii number for a lowercase a - 97
            Console.WriteLine((int)'a');
            
            var random = new System.Random();
            for (var i = 0; i < 10; i++)
            {
                // The range 97 - 122 is alphabet a-z
                // And we then cast the number to a character
                // We then change WriteLine to write as we want to print all the letters on the same line
                Console.Write((char)random.Next(97, 122));
            }
        }
        
        public static void NumbersToStringsRefined()
        {
            var random = new System.Random();
            // If we want to change the password length making the password length
            // a variable makes the code more robust and future proof
            var passwordLength = 10;
            // create new character array - call it buffer, set memory of new object which is a character array of 10
            var buffer = new char[passwordLength];
            
            for (var i = 0; i < passwordLength; i++)
            {
                // So this gets a, then adds a random number to it between 0 and 26 - which will be a - z
                // which is all cast back to a char so it still gives us
                // a random character
                buffer[i] = (char)('a' + random.Next(0, 26));
            }

            var password = new string(buffer);
            Console.WriteLine(password);
            
        }
        
        static void Main(string[] args)
        {
            // RandomForLoop();
            // NumbersToStrings();
            NumbersToStringsRefined();
        }
    }
}

