namespace RefactoringToPolymorphism
{
	public class Bottles
	{
		public string Verse(int startingBottleCount)
		{
			return CreateFirstLine(startingBottleCount) +
				CreateSecondLine(startingBottleCount) +
				CreateThirdLine(startingBottleCount);
		}

		private string CreateFirstLine(int startingBottleCount)
		{
			string pluralisation = "";
			if (startingBottleCount > 1)
			{
				pluralisation = "s";
			}

			return string.Format(
				"{0} bottle{1} of beer on the wall, {0} bottle{1} of beer.\r\n",
				startingBottleCount,
				pluralisation);
		}

		private string CreateSecondLine(int startingBottleCount)
		{
			var word = startingBottleCount == 1 ? "it" : "one";

			return string.Format("Take {0} down and pass it around, ", word);
		}

		private string CreateThirdLine(int startingBottleCount)
		{
			string pluralisation = "s";
			if (startingBottleCount == 2)
			{
				pluralisation = "";
			}

			return string.Format(
				"{0} bottle{1} of beer on the wall.",
				startingBottleCount == 1 ? "no more" : (startingBottleCount - 1).ToString(),
				pluralisation);
		}
	}
}