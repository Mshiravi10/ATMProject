using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMProject.UI
{
	public class Utility
	{
		public static long StringToLong(string str)
		{
			if (long.TryParse(str, out long result))
			{
				return result;
			}
			else
			{
				throw new ArgumentException("Invalid input. The input string must be a valid long number.");
			}
		}
	}
}
