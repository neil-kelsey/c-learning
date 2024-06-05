// See https://aka.ms/new-console-template for more information
using System;

namespace fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var firstName = "Neil";
            var lastName = "Kelsey";
            
            // the lowercase string is a string keyword from C#
            // the uppercase String is from .NET framework - so you'll need to import system namespace at the top of this file
            string newFirstName = "Glen";
            String newLastName = "Miller";
            
            // it's the same with
            // Int32 and int
            
            Console.WriteLine(newFirstName);
            Console.WriteLine(newLastName);

            // {0} is a placeholder which will be replaced with firstName
            string fullName = string.Format("{0} {1}", firstName, lastName);

            Console.WriteLine(firstName + " " + lastName);
            Console.WriteLine(fullName);

            var numbers = new int[3] { 1, 2, 3};
            string list = string.Join(",", numbers);

            Console.WriteLine(numbers[0]);
            Console.WriteLine(list);

            char firstChar = firstName[0];

            Console.WriteLine(firstChar);

            // There are also escape characters
            // Backslash is a special escape character so we need to place a \ in front of it
            // Which ends up as a double \\
            // Look at my Google Keeps notes for more infor on escape characters

            string path = "c:\\projects\\projects1\\folder1";
            Console.WriteLine(path);

            // But you can also do this

            string pathClean = @"c:\projects\projects1\folder1";
            Console.WriteLine(pathClean);
            
            var text = "Hi my name is Neil \nLook how this is a new line\nFile path c:\\folder1\\folder2";
            Console.WriteLine(text);
            
            // We can make the above text var cleaner with a verbatim string as follows
            var textCleaner = @"Hi my name is Glen
Look how this is a new line
File path c:\folder3\folder4";
            Console.WriteLine(textCleaner);

        }
    }
}
