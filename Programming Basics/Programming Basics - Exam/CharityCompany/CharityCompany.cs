using System;

namespace CharityCompany
{
    class CharityCompany
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var peoples = int.Parse(Console.ReadLine());
            var cakeCount = int.Parse(Console.ReadLine());
            var gofretCount = int.Parse(Console.ReadLine());
            var pancakeCount = int.Parse(Console.ReadLine());

            var cakePrise = 45;
            var gofretPrise = 5.80;
            var pancakePrise = 3.20;

            var sum = (cakeCount * cakePrise + gofretCount * gofretPrise + pancakeCount * pancakePrise) * peoples;
            var sumDays = sum * days;
            var totalSum = sumDays * 0.875;

            Console.WriteLine("{0:f2}", totalSum);
        }
    }
}
