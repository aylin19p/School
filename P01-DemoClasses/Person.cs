using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Person
{
	private int age;

	public int Age
	{
		get { return age; }
		set 
		{
			if (value <= 0) 
			{
				throw new ArgumentException("Invalid age");
			}
			age = value; 
		}
	}
    public string Name { get; set; }
    public double Weigh { get; set; }
}

