using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Junior : IEmployee
{
    public Junior(string firstName, string lastName, string department)
    {
        FirstName = firstName;
        LastName = lastName;
        Department = department;
        Salary = 900;
    }

    public string FirstName { get; private set; }

    public string LastName { get; private set; }

    public string Department { get; private set; }

    public decimal Salary { get; } 

    public void GetSalary()
    {
        Console.WriteLine(Salary);
    }
    public override string ToString()
    {
        return $"{FirstName} {LastName} is {Department} engineer.";
    }
}
