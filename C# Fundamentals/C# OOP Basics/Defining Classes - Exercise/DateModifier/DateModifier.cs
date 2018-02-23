using System;
using System.Globalization;

public class DateModifier
{
    private DateTime firstDate;
    private DateTime secondDate;

    public DateTime FirstDate
    {
        get { return firstDate; }
        set { firstDate = value; }
    }
    public DateTime SecondDate
    {
        get { return secondDate; }
        set { secondDate = value; }
    }
    public void TotalDays(string firstDate, string secondDate)
    {
        this.firstDate  = DateTime.ParseExact(firstDate,  "yyyy MM dd", CultureInfo.InvariantCulture);
        this.secondDate = DateTime.ParseExact(secondDate, "yyyy MM dd", CultureInfo.InvariantCulture);

        Console.WriteLine(Math.Abs((this.FirstDate - this.SecondDate).TotalDays));
    }
}     