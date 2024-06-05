using CSharpFundamentals.Math;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var neil = new Person();
            neil.FirstName = "Neil";
            neil.LastName = "Kelsey";
            neil.Introduce();
    
            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}