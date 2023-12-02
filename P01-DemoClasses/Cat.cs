using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cat
{
	private string name;

	public string Name
	{
		get { return name; }
		set 
		{
			if (string.IsNullOrWhiteSpace(value)) 
			{
				throw new ArgumentNullException("Invalid name");
			}
			name = value; 
		}
	}
    public int Age { get; set; }
    public string Breed { get; set; }
}
