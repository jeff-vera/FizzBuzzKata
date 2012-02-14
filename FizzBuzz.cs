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

		public string GetTextForNumber(int p)
		{
			bool divisibleByThree = IsDivisibleByThree(p);
			bool divisibleByFive = IsDivisibleByFive(p);

			if (divisibleByThree && divisibleByFive)
			{
				return "FIZZBUZZ";
			} 
			else if (divisibleByThree)
			{
				return "FIZZ";
			}
			else if (divisibleByFive)
			{
				return "BUZZ";
			}
			else
			{
				return p.ToString();
			}
		}

		public bool IsDivisibleByFive(int p)
		{
			return (p % 5) == 0;
		}

		public void DoTheWholeThing(int p)
		{
			for (int i = 1; i <= p; ++i)
			{
				Console.WriteLine(GetTextForNumber(i));
			}
		}
	}
}
