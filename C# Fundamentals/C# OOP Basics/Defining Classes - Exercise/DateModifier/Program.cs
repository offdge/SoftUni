using System;

class Program
{
    static void Main()
    {
        var totalDays   = new DateModifier();
        var firstDate   = Console.ReadLine();
        var secondDate  = Console.ReadLine();
        
        totalDays.TotalDays(firstDate, secondDate);       
    }
}
