using System;

namespace variables

{
    class Program
    {
        static void Main(string[] args)
        {
            const float Pi = 3.14f;
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            Console.WriteLine(Pi);
        }
    }
}