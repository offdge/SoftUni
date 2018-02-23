using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        var totalDays = new DateModifier();

        var firstDate = Console.ReadLine();
        var secondDate = Console.ReadLine();
        
        totalDays.TotalDays(firstDate, secondDate);       
    }
}
