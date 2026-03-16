using Class.Models;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new(1, "alma", 3, 2.5);
            order1.GetInfo();
            double diff;
            order1.ChangePrice(5, out diff);
            Console.WriteLine(diff);

        }
    }
}
