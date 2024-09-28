using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SalesEmployee : IEmployee
{
    public SalesEmployee(string firstName, string lastName, string department, decimal profits)
    {
        FirstName = firstName;
        LastName = lastName;
        Department = department;
        Salary = 1000;
        Profits = profits;
    }

    public string FirstName { get; private set; }

    public string LastName { get; private set; }

    public string Department { get; private set; }

    public decimal Salary { get; }
    public decimal Profits { get; private set; }
    public void GetSalary()
    {
        decimal sum = Salary + 0.1m * Profits;    
        Console.WriteLine(sum);
    }
    public override string ToString()
    {
        return $"{FirstName} {LastName} from {Department} has {Profits} profits.";
    }
}
