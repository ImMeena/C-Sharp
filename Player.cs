using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackCardGame
{
    class Player
    {
        #region Fields
        //Fields

        private string name;
        private List<Card> cardInPlayerHand;
        private bool isBlackJack;
        private bool checkBust;
        private bool isTurn;
        public int winnerCount = 0;
        #endregion
        //Creating an empty list of players
        public List<Player> players = new List<Player>();

        #region Constructor
        public Player(string name)
        {
            this.Name = name;
            CheckBust = false;
            IsTurn = true;
            CardInPlayerHand = new List<Card>(6);
        }
        #endregion

        #region Allmethods
        public int CheckPlayerHand()
        {
            int value = 0;
            foreach (Card cards in CardInPlayerHand)
            {
                value += cards.NumeralValue;
            }
            return value;
        }

        //Print Players hand card value and count
        public void ShowPlayerHand()
        {
            Console.WriteLine($"\n\t{this.Name}'s Hand value is: {this.CheckPlayerHand()} ({this.CardInPlayerHand.Count} cards)");
        }

        public void ShowPlayerCards()
        {
            Console.WriteLine($"\n\t{this.Name}'s Hand has:");
            foreach (Card card in this.CardInPlayerHand)
            {
                card.GetCardsValue();
            }
            ShowPlayerHand();
        }

        public void AddWinnersCount(Player currentPlayer)
        {
            this.winnerCount++;
        }
        // To draw another card
        public void DrawAnotherCard(DeckOfCards deck)
        {
            Console.Write($"\n\t{this.Name} chose another card. ");
            Card card = deck.GetCard(this);
            card.GetCardsValue();
        }
        // Method to exit from turn
        public void ExitTurn()
        {
            Console.WriteLine($"\n\t{this.Name} chose 'No' to draw another card. ");
            this.ShowPlayerCards();
            this.IsTurn = false;
        }
        // Method to clear all the cards in the Player's Hand
        public void ClearHand()
        {
            this.CardInPlayerHand = new List<Card>(6);
            this.IsBlackJack = false;
            this.CheckBust = false;
        }
        #endregion

        #region GetterSetter
        // getter setter

        public string Name { get => name; set => name = value; }
        internal List<Card> CardInPlayerHand { get => cardInPlayerHand; set => cardInPlayerHand = value; }
        public bool IsBlackJack { get => isBlackJack; set => isBlackJack = value; }
        public bool CheckBust { get => checkBust; set => checkBust = value; }
        public bool IsTurn { get => isTurn; set => isTurn = value; }

        #endregion
    }
}
