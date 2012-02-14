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
		public void CanInstantiateTest()
		{
			FizzBuzz fb = new FizzBuzz();

			Assert.That(fb, Is.Not.Null);			
		}

		[Test]
		public void ThreeIsDivisibleByThreeTest()
		{
			FizzBuzz fb = new FizzBuzz();

			bool isDivisibleByThree = fb.IsDivisibleByThree(3);

			Assert.That(isDivisibleByThree, Is.True);
		}

		[Test]
		public void ReturnFizzIfDivisibleByThreeTest()
		{
			FizzBuzz fb = new FizzBuzz();

			string textForNumber = fb.GetTextForNumber(3);

			Assert.That(textForNumber, Is.EqualTo("FIZZ"));
		}

		[Test]
		public void FiveIsDivisibleByFiveTest()
		{
			FizzBuzz fb = new FizzBuzz();

			bool isDivisibleByFive = fb.IsDivisibleByFive(5);

			Assert.That(isDivisibleByFive, Is.True);
		}

		[Test]
		public void ReturnBuzzIfDivisibleByFiveTest()
		{
			FizzBuzz fb = new FizzBuzz();

			string textForNumber = fb.GetTextForNumber(5);

			Assert.That(textForNumber, Is.EqualTo("BUZZ"));
		}

		[Test]
		public void ReturnFizzBuzzIfDivisibleByThreeAndFiveTest()
		{
			FizzBuzz fb = new FizzBuzz();

			string textForNumber = fb.GetTextForNumber(15);

			Assert.That(textForNumber, Is.EqualTo("FIZZBUZZ"));
		}

		[Test]
		public void CanRunTheWholeThingTest()
		{
			FizzBuzz fb = new FizzBuzz();

			fb.DoTheWholeThing(200);
		}
	}
}
