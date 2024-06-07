// See https://aka.ms/new-console-template for more information

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            // value types - there value is copied
            var a = 10;
            var b = a; // At this point b = 10 we have copied the value
            b++;
            Console.WriteLine(string.Format("a: {0}, b:{1}", a, b));
            
            // array is a reference type
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1; // but here the first value in the array will be 0 as this is a reference type
            array2[0] = 0; // this means that in memory we are referencing the same thing, the same array - so changing one will change both
            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0])); // both array1 and array2 [0] have the same altered value
        }
    }
}