using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Book
{
	private int page;

	public int Page
	{
		get { return page; }
		set 
		{
			if (value<=0)
			{
				throw new ArgumentException("Invalid number");
			}
			page = value;
		}
	}
    public string Name { get; set; }
	public string Color { get; set; }
}


