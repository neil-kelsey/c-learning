namespace Conditionals;

class Program
{
    static void Main(string[] args)
    {
        bool isGoldCustomer = true;

        // If the user is a gold customer
        // then set the floats value
        // float price;
        // if (isGoldCustomer)
        // {
        //     price = 19.95f;
        // }
        // else
        // {
        //     price = 29.95f;
        // }

        // The above can also be written like this
        float price = (isGoldCustomer) ? 19.95f : 29.95f;
        Console.WriteLine(price);
    }
}