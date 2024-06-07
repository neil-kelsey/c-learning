// See https://aka.ms/new-console-template for more information

namespace CSharpFundamentals
{
    public class Person
    {
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // set a number
            var number = 1;
            // pass that number to the Increment function
            Increment(number);
            // The value is still 1 - this is because the 'number' var in Increment is a different place in memory and only in the scope of that function
            // And the 'number' var we're displaying here is the var that's in this function so is unaffected by the Increment method
            Console.WriteLine(number);
            
            // If we use reference this way it works
            var person = new Person() { Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age);
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}