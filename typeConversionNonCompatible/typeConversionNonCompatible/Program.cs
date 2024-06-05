using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // 123 string fits in to an int so this compiles when we run
            string number = "1234";
            int i = int.Parse(number);
            Console.WriteLine(i);
            
            
            
            
            
            // This wont work as 1234 work as the value 1234 won't fit in to a byte type
            // The error happened during the conversion of the string to a byte
            // string numberTwo = "1234";
            // byte iTwo = Convert.ToByte(numberTwo);
            // Console.WriteLine(iTwo); Commented out as it errors
            
            // So we can build an exception to catch this before run time
            // To create a try catch block just type 'try' and hit enter, Rider does the rest
            // This is what's called another one of those 'code snippet' things
            
            
            
            
            
            
            try
            {
                // This is the same code as before but instead of erroring the application
                // we will simply try to run this code, if it doesn't work then we run
                // the catch Exception code
                string numberThree = "1234";
                byte iThree = Convert.ToByte(numberThree);
                Console.WriteLine(iThree);
            }
            catch (Exception)
            {
                // If we don't handle the exception the exception will be propogated to the .NET run time
                Console.WriteLine("Error!! The number could not be converted to a byte - ");
                // throw will throw an error at runtime and stop the application if we want it to
                // throw;
            }

            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception e)
            {
                // e is the error ?
                Console.WriteLine("Bool error", e);
                throw;
            }
        }
    }
}