using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackCardGame
{
    class DeckOfCards
    {

        // Field
        private List<Card> deckOfCards;

        #region Constructor
        //Constructor
        public DeckOfCards()
        {
            deckOfCards = new List<Card>(52);
            ShowDeckOfCard();
            Shuffling();
        }
        #endregion

        #region ShowDeckOfCard
        private void ShowDeckOfCard()
        {
            var getSuitsValue = Enum.GetValues(typeof(Suit)).Cast<Suit>().ToArray();
            var getFaceValue = Enum.GetValues(typeof(RankValue)).Cast<RankValue>().ToArray();

            foreach (var suit in getSuitsValue)
            {
                foreach (var face in getFaceValue)
                {
                    deckOfCards.Add(new Card(suit, face));
                }
            }
        }
        #endregion
        // method for shuffle all the cards in deckOfCard
        #region Methods
        private void Shuffling()
        {
            Random rnd = new Random();
            deckOfCards = deckOfCards.OrderBy(item => rnd.Next()).ToList();
        }
        public Card GetCard(Player player)
        {
            Card card;
            card = deckOfCards[0];

            if (player.CheckPlayerHand() + card.NumeralValue == 21 && player.CardInPlayerHand.Count == 1)
            {
                player.IsBlackJack = true;
            }
            else if (player.CheckPlayerHand() + card.NumeralValue > 21 && card.Rank == RankValue.A)
            {
                card.NumeralValue = 1;
            }
            player.CardInPlayerHand.Add(card);
            deckOfCards.Remove(card);
            return card;
        }
        public int RemainingCard()
        {
            return deckOfCards.Count;
        }
        public void PrintRemainingCard()
        {
            Console.WriteLine($"Total cards left in the deckOfCard: {deckOfCards.Count}");
        }
        #endregion

    }
}
