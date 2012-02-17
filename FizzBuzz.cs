using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzKata
{
	public class FizzBuzz
	{
		public bool IsDivisibleByThree(int p)
		{
			return (p % 3) == 0;
		}

		public bool IsDivisibleByFive(int p)
		{
			return (p % 5) == 0;
		}

		public string GetTextForNumber(int p)
		{
			if (IsDivisibleByFive(p) && IsDivisibleByThree(p))
			{
				return "FizzBuzz";
			}
			else if (IsDivisibleByThree(p))
			{
				return "Fizz";
			}
			else if (IsDivisibleByFive(p))
			{
				return "Buzz";
			}
			else
			{
				return p.ToString();
			}
		}

		public string DoTheWholeThing(int p)
		{
			StringBuilder sb = new StringBuilder();
			for (int i = 1; i <= p; ++i)
			{
				sb.AppendFormat("{0} ", GetTextForNumber(i));
			}

			return sb.ToString();
		}
	}
}
