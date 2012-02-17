using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace FizzBuzzKata
{
	[TestFixture]
	public class FizzBuzzTests
	{
		[Test]
		public void ThreeIsDivisibleByThreeTest()
		{
			FizzBuzz fb = new FizzBuzz();

			bool isDivisibleByThree = fb.IsDivisibleByThree(3);

			Assert.That(isDivisibleByThree, Is.True);
		}

		[Test]
		public void FiveIsDivisibleByFiveTest()
		{
			FizzBuzz fb = new FizzBuzz();

			bool isDivisibleByFive = fb.IsDivisibleByFive(5);

			Assert.That(isDivisibleByFive, Is.True);	
		}

		[Test]
		public void DivisibleByThreeReturnsFizzTest()
		{
			FizzBuzz fb = new FizzBuzz();

			string returnText = fb.GetTextForNumber(3);

			Assert.That(returnText, Is.EqualTo("Fizz"));
		}

		[Test]
		public void DivisibleByFiveReturnsBuzzTest()
		{
			FizzBuzz fb = new FizzBuzz();

			string returnText = fb.GetTextForNumber(5);

			Assert.That(returnText, Is.EqualTo("Buzz"));
		}

		[Test]
		public void DivisibleByThreeAndFiveReturnsFizzBuzzTest()
		{
			FizzBuzz fb = new FizzBuzz();

			string returnText = fb.GetTextForNumber(15);

			Assert.That(returnText, Is.EqualTo("FizzBuzz"));
		}

		[Test]
		public void DivisibleBYNeitherThreeNorFiveReturnsItselfTest()
		{
			FizzBuzz fb = new FizzBuzz();

			string returnText = fb.GetTextForNumber(4);

			Assert.That(returnText, Is.EqualTo("4"));
		}

		[Test]
		public void CanDoTheWholeThingTest()
		{
			FizzBuzz fb = new FizzBuzz();

			string returnText = fb.DoTheWholeThing(15);

			Assert.That(
				returnText, 
				Is.EqualTo("1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz "));
		}
	}
}
