﻿using NUnit.Framework;

namespace RefactoringToPolymorphism
{
	[TestFixture]
	public class BottlesTest
	{
		private Bottles _bottles;

		[SetUp]
		public void SetUp()
		{
			_bottles = new Bottles();
		}

		[Test]
		public void should_sing_verse_starting_with_99_bottles()
		{
			const string expected = @"99 bottles of beer on the wall, 99 bottles of beer.
Take one down and pass it around, 98 bottles of beer on the wall.";
			Assert.That(_bottles.Verse(99), Is.EqualTo(expected));
		}

		[Test]
		public void should_sing_verse_starting_with_89_bottles()
		{
			const string expected = @"89 bottles of beer on the wall, 89 bottles of beer.
Take one down and pass it around, 88 bottles of beer on the wall.";
			Assert.That(_bottles.Verse(89), Is.EqualTo(expected));
		}

		[Test]
		public void should_sing_verse_with_singular_remaining_bottles_on_the_wall()
		{
			const string expected = @"2 bottles of beer on the wall, 2 bottles of beer.
Take one down and pass it around, 1 bottle of beer on the wall.";
			Assert.That(_bottles.Verse(2), Is.EqualTo(expected));
		}

		[Test]
		public void verse_1()
		{
			const string expected = @"1 bottle of beer on the wall, 1 bottle of beer.
Take it down and pass it around, no more bottles of beer on the wall.";
			Assert.That(_bottles.Verse(1), Is.EqualTo(expected));
		}

		[Test, Ignore]
		public void verse_0()
		{
			const string expected = @"No more bottles of beer on the wall, no more bottles of beer.
Go to the store and buy some more, 99 bottles of beer on the wall.";
			Assert.That(expected, Is.EqualTo(_bottles.Verse(0)));
		}

		[Test, Ignore]
		public void a_couple_of_verses()
		{
//			const string expected = @"99 bottles of beer on the wall, 99 bottles of beer.
//Take one down and pass it around, 98 bottles of beer on the wall.
//
//98 bottles of beer on the wall, 98 bottles of beer.
//Take one down and pass it around, 97 bottles of beer on the wall.";
			//Assert.That(expected, Is.EqualT o(_bottles.Verse(99, 98)));
		}

		[Test, Ignore]
		public void a_few_verses()
		{
//			const string expected = @"2 bottles of beer on the wall, 2 bottles of beer.
//Take one down and pass it around, 1 bottle of beer on the wall.
//
//1 bottle of beer on the wall, 1 bottle of beer.
//Take it down and pass it around, no more bottles of beer on the wall.
//
//No more bottles of beer on the wall, no more bottles of beer.
//Go to the store and buy some more, 99 bottles of beer on the wall.";
			//Assert.That(expected, Is.EqualTo(_bottles.Verse(2, 0)));
		}
	}
}
