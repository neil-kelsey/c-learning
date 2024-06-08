namespace Conditionals3
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's autumn");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's summer");
                    break;
                // You can do multiple cases like this
                // case Season.Autumn:
                // case Season.Summer:
                //     Console.WriteLine("We have a promotion");
                //     break;
                default:
                    Console.WriteLine("It's something else");
                    break;
            }
        }
    }
}