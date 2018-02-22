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

    //public FirstDate(string firstDate)
    //{
    //    this.firstDate =  DateTime.ParseExact(firstDate, "yyyy MM dd", CultureInfo.InvariantCulture);
    //    Console.WriteLine(firstDate);
    //
    //}
}

