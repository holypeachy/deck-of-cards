namespace Deck
{
	class Card
	{
		private int value;
		private string suit;

		public Card(int value, string suit)
		{
			this.value = value;
			this.suit = suit;
		}

		public void ShowCard()
		{
			Console.WriteLine(value + " of " + suit);
		}
	}
}
