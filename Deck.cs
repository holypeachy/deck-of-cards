namespace Deck
{
	class Deck
	{
		public Card[] deck = new Card[52];
		private string[] suits = { "Spades", "Clubs", "Hearts", "Diamonds" };

		public Deck()
		{
			CreateDeck();
			
			ShuffleDeck();
			ShuffleDeck();
		}

		public void CreateDeck()
		{
			int cardCount = 0;
			foreach (string suit in suits)
			{
				for (int value = 1; value <= 13; value++)
				{
					deck[cardCount] = new Card(value, suit);
					cardCount++;
				}
			}
		}

		public void ShuffleDeck() //! Simple shuffle algorithm
		{
			Random rand = new();
			Card tempHolder; // Holds the 'target' card while it's being overwritten to it can be placed somewhere else
			for (int target = 0; target < 52; target++)
			{
				int randomNumber;
				if (target < 50)
				{
					randomNumber = rand.Next(target + 1, 52); // It can pick from card after the target up until 51(index)
				}
				else if (target == 50)
				{
					randomNumber = rand.Next(0, 50);
				}
				else //51
				{
					randomNumber = rand.Next(0, 51); // Picks a card from 0-50(index)
				}
				tempHolder = deck[target]; // Save the target
				deck[target] = deck[randomNumber]; // Place the randomly selected card into target
				deck[randomNumber] = tempHolder; // Finally, place the target in the place of the randomly selected
			}
		}

		public void ShowDeck()
		{
			foreach (Card card in deck)
			{
				card.ShowCard();
			}
		}

		public void ShowRandomCard()
		{
			Random rand = new();
			deck[rand.Next(0, 52)].ShowCard();
		}
	}
}