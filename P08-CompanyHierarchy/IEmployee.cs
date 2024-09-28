using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IEmployee
{
    public string FirstName { get; }
    public string LastName { get; }
    public string Department { get; }
    public decimal Salary { get; }
    public void GetSalary();
}