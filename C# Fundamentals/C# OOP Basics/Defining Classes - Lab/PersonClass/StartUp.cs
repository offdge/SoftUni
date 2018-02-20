using System;

public class StartUp
{
    static void Main(string[] args)
    {
        var acc = new Person();

        acc.Name = "Pesho";
        acc.Age = 15;

        Console.WriteLine($"Name {acc.Name}, age {acc.Age}");
    }
}