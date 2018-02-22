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
}


