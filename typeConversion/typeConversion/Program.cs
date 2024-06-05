using System;

namespace variables

{
    class Program
    {
        static void Main(string[] args)
        {
            // A byte type can only store from 0 - 255
            // So if our int value is over this value you will have data loss in this conversion
            // If the int value is say 256 this will start the range again from 0 and console will return 0
            int i = 255;
            byte b = (byte)i;
            Console.WriteLine(b);
        }
    }
}