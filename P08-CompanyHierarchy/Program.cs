using System.Linq.Expressions;
    public class Program
    {
        static void Main()
        {
            string[] args = Console.ReadLine().Split(" ");
            string fName = args[0];
            List<IEmployee> employees = new();
            while (true)
            {
            if (fName == "End")
            {
                break;
            }
                string lName = args[1];
                string department = args[2];
                IEmployee employee = null;
                switch (department)
                {
                    case nameof(Engineer):
                        int yearsService = int.Parse(args[3]);
                        employee = new Engineer(fName,lName, department,yearsService);
                        break;
                    case nameof(Junior):
                        employee = new Junior(fName,lName,department);
                        break;
                    case "Sales":
                        decimal profits = decimal.Parse(args[3]);
                        employee = new SalesEmployee(fName, lName, department, profits);
                        break;
                }
                employees.Add(employee);
            }
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
                Console.WriteLine($"Receives a salary {employee.GetSalary}.");
            }
        }
    }
