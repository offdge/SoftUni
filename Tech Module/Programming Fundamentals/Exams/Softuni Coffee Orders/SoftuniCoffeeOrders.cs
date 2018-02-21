using System;
using System.Linq;

namespace SoftuniCoffeeOrders
{
    class Program
    {
        static void Main()
        {
            var countOfOrders = int.Parse(Console.ReadLine());
            decimal totalPrice = 0;
            
            for (int i = 0; i < countOfOrders; i++)
            {
                var pricePerCapsule = decimal.Parse(Console.ReadLine());
                var orderDate = Console.ReadLine().Split('/').Select(s => int.Parse(s)).ToArray();
                var capsulesCount = int.Parse(Console.ReadLine());
                var year = orderDate[2];
                var month = orderDate[1];
                var daysInMonth = DateTime.DaysInMonth(year, month);
                var price = pricePerCapsule * daysInMonth * capsulesCount ;

                Console.WriteLine("The price for the coffee is: ${0:f2}", price);

                totalPrice += price;
            }
            Console.WriteLine("Total: ${0:f2}", totalPrice);
		}
	}
}