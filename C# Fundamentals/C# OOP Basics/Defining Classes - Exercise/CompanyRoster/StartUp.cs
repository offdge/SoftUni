using System;
using System.Linq;
using System.Collections.Generic;

class StartUp
{
    static void Main()
    {
        var employees = new Dictionary<string, List<Employee>>();
        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();
            var name = input[0];
            var salary = double.Parse(input[1]);
            var position = input[2];
            var department = input[3];
            var email = "n/a";
            var age = -1;

            if (input.Length == 5)
            {
                email = input[4];
            }
            if (input.Length == 6)
            {
                email = input[4];
                age = int.Parse(input[5]);
            }

            var employee = new Employee(name,  salary,  position,  department,  email, age);
           
            if (!employees.ContainsKey(department))
            {
                employees.Add(department, new List<Employee>());
            }
            employees[department].Add(employee);
        }

        var highestSalaryDepartment = "";
        double highestSalary = 0;

        foreach (var employee in employees)
        {
            var salaryCheck = from member in employee.Value.Select(x => x.Salary) select member;

            if (salaryCheck.Average() > highestSalary)
            {
                highestSalary = salaryCheck.Average();
                highestSalaryDepartment = employee.Key;
            }
        }
        foreach (var employee in employees.Where(x => x.Key == highestSalaryDepartment))
        {
            Console.WriteLine("Highest Average Salary: {0}", employee.Key);
        
            foreach (var person in employee.Value.OrderByDescending(x => x.Salary))
            {
                Console.WriteLine("{0} {1:f2} {2} {3}", person.Name, person.Salary, person.Email, person.Age);
            }
        }
    }
}