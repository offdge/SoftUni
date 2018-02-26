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
            var salary = decimal.Parse(input[1]);
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

        //foreach (var employee in employees.OrderByDescending(x => x.Salary).Where(x => x.Department == highestSalaryDepartment))
        //{
        //    Console.WriteLine("{0} {1:f2} {2} {3}", employee.Name, employee.Salary, employee.Email, employee.Age);
        //}

        //foreach (var employee in employees.OrderByDescending(x => x.Value.OrderByDescending(y => y.Salary)))
        foreach (var employee in employees)
            {
            Console.WriteLine(employee.Key);

            foreach (var mem in employee.Value)
            {
                Console.WriteLine("{0} {1:f2} {2} {3}", mem.Name, mem.Salary, mem.Email, mem.Age);
            }
        }

        //var testSalary = employees.Average(x => x.Salary);
    }

    //public void Addemployee(string department, Employee employee, Dictionary<string, List<Employee>> employees)
    //{
    //    if (!employees.ContainsKey(department))
    //    {
    //        employees.Add(department, new List<Employee>());
    //    }
    //
    //    employees[department].Add(employee);
    //    
    //}
}


