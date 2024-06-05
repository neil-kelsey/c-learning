namespace Operators
{
 class Program
 {
  static void Main(string[] args)
  {
   var a = 10;
   var b = 3;
   var c = 3;

   // Start of Arithmetric Operators
   Console.WriteLine("Add operator - " + (a + b)); // If we don't have a + b in a bracket it will return a value of 103 - treating them like strings
   Console.WriteLine("Subtract operator - " + (a - b));
   Console.WriteLine("Multiply operator - " + a * b);
   Console.WriteLine("Divide operator - " + a / b); // Because a and b are intigers the result is an intiger 3 and not a float of the real answer 3.333333
   Console.WriteLine("Divide operator as a float - " + (float)a / (float)b); // If we want the 'real' answer, cast both ints to be floats
   Console.WriteLine("Operator precidence - " + (a + b * c)); //  b * c = 9 then add 10 so 19
   Console.WriteLine("Operator precidence - " + ((a + b) * c)); //  a + b = 13 then multiply c so 39
   Console.WriteLine("Remainder operator - " + (a % b)); // 10 can be divided by 3 3 times and you end up with a remainder of 1
   
   // Start of comparison operators
   Console.WriteLine("Equal to - " + (a == b)); // Is a equal to b - return false
   Console.WriteLine("Not equal to - " + (a != b)); // a is not equal to b - return true
   Console.WriteLine("Greater than - " + (a > b)); // Is a greater than b - return true
   Console.WriteLine("Greater than or equal to - " + (a >= b)); // Is a great than or equal to b - return true
   Console.WriteLine("Less than - " + (a < b)); // Is a less than b - false
   Console.WriteLine("Less than or equal to - " + (a <= b)); // Is a less than or equal to b - false
   
   // Start of logical operators
   Console.WriteLine("And operator - " + (a > b && b > c)); // a > b is true, b > c is false - so no the first statement and the second statement are not true to return false
   Console.WriteLine("Or operator - " + (a > b || b > c)); // One of the statements is true so return true
   Console.WriteLine("Not operator - " + (a != b)); // a is not equal to b so return true
  }
 }
}