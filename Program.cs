namespace Deck
{
	class Program
	{
		static void Main()
		{
			Deck deck = new();
			Console.WriteLine("\nShow Deck:\n");
			deck.ShowDeck();
			Console.WriteLine("\n\nPicks 2 random cards from the deck:");
			deck.ShowRandomCard();
			deck.ShowRandomCard();
			Console.ReadKey();
		}
	}
}
