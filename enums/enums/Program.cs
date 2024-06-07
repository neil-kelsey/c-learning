// See https://aka.ms/new-console-template for more information
using System;

namespace fundamentals
{
    // If we dont assign a value to the members of the following enum
    // Then the first item is set to 0, the next 1 and so on
    // Best practice is to set a value
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var shippingMethod = ShippingMethod.Express;
            // The following shows the item, if you want the int you can do the following
            Console.WriteLine(shippingMethod);
            // So we need to case that value to an int
            Console.WriteLine((int)shippingMethod);
            
            // Imagine we get the number from somewhere else we can use casting like this
            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            

            // Convert result to a string
            // Console.WriteLine converts things to a string anyway
            // So we dont really need it here
            // But in other instances you might
            Console.WriteLine(methodId.ToString());
            
            Console.WriteLine("String to enum");
            
            // How about converting string to an enum
            var methodName = "Express";
            Console.WriteLine(methodName);
            
            // This is parsing - taking a string and changing it to a different type, parsing
            // (ShippingMethod) before the Enum is the casting
            var shippingMethodTwo = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);
        }
    }
}
