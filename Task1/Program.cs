using System.Runtime.ConstrainedExecution;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // محمد طارق السعيد 
            Console.WriteLine("Enter Number of small carpenters :");
            int numsmallcarpenters = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Number of small carpenter : {numsmallcarpenters}");

            //-----------------

            Console.WriteLine("Enter Number of small carpenters :");
            int numlargecarpenters = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Number of small carpenter : {numlargecarpenters}");

            Console.WriteLine("price per small carpenter = $25");
            Console.WriteLine("price per large carpenter = $35");

            //-----------------
            var cost = (numsmallcarpenters * 25) + (numlargecarpenters * 35);
            Console.WriteLine($"cost : {cost}");

            //----------------
            double Tax = (cost * 0.06);
            Console.WriteLine($"Tax : {Tax}");

            Console.WriteLine("----------------------");
            double Total = (cost + Tax);
            Console.WriteLine($"Total ectimate = {Total}");
            //------------------
            Console.WriteLine("This ectimate is valid for 30 days");
        }
    }
}