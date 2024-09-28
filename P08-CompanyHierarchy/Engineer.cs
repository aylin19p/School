using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Engineer : IEmployee
{
    public Engineer(string firstName, string lastName, string department, int yearsService)
    {
        FirstName = firstName;
        LastName = lastName;
        Department = department;
        Salary = 1300;
        YearsService = yearsService;
    }

    public string FirstName { get; private set; }

    public string LastName { get; private set; }

    public string Department { get; private set; }

    public decimal Salary { get;  }
    public int YearsService { get; private set; }

    public void GetSalary()
    {
        decimal sum = Salary + YearsService * 90;
        Console.WriteLine(sum);
    }
    public override string ToString()
    {
        return $"{FirstName} {LastName} from {Department} has {YearsService} years of service.";
    }
}