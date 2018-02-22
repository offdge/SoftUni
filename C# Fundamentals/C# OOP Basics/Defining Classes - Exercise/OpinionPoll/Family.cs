using System;
using System.Linq;
using System.Collections.Generic;

public class Family
{
    private List<Person> people;

    public Family()
    {
        this.people = new List<Person>();
    }
    public List<Person> People
    {
        get { return people; }
        set { people = value; }
    }
    public void AddMember(Person member)
    {
        this.people.Add(member);
    }
    public Person GetOldestMember()
    {
        return this.people.OrderBy(x => x.Age).Last();
    }
    public void MoreThan30()
    {
        foreach (var item in people.OrderBy(x => x.Name).Where(x => x.Age > 30))
        {
            Console.WriteLine($"{item.Name} - {item.Age}");
        }
    }
}