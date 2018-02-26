using System;
using System.Collections.Generic;
using System.Text;


class Employee
{

    private string name;
    private decimal salary;
    private string position;
    private string department;
    private string email;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public decimal Salary
    {
        get { return salary; }
        set { salary = value; }
    }
    public string Position
    {
        get { return position; }
        set { position = value; }
    }
    public string Department
    {
        get { return department; }
        set { department = value; }
    }
    public string Email
    {
        get { return email; }
        set { email = value; }
    }
    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public Employee(string name, decimal salary, string position, string department, string email = "n/a", int age = -1)
    {
        this.name = name;
        this.salary = salary;
        this.position = position;
        this.department = department;
        this.email = email;
        this.age = age;
    }

}

