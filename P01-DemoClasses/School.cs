using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class School
{
    private string address;

    public string Name { get; set; }
	
	public string Address
	{
		get { return address; }
		set 
		{
			if (value.Length <= 0)
			{
				throw new ArgumentException("Invalid address");
			}
			address = value; 
		}
	}

}
