using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackCardGame
{
    #region Enum
    public enum Suit
    {
        Spade, Heart, Diamond, Club
    }
    public enum RankValue
    {
        Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten,
        J = 10, Q = 10, K = 10, A
    }
    #endregion
    class Card
    {
        #region Fields
        //Fields
        private Suit suit;
        private RankValue rank;
        private string rankName;
        private int numeralValue;
        private char symbol;

        #endregion

        #region Constructor
        //Constructor
        public Card(Suit suit, RankValue rankvalue)
        {
            Suit = suit;
            rank = rankvalue;

            switch (Suit)
            {
                case Suit.Spade:
                    Symbol = '♠';
                    break;
                case Suit.Heart:
                    Symbol = '♥';
                    break;
                case Suit.Diamond:
                    Symbol = '♦';
                    break;
                case Suit.Club:
                    Symbol = '♣';
                    break;
            }
            switch (rank)
            {
                case RankValue.A:
                    numeralValue = 11;
                    RankName = "A";
                    break;

                default:
                    numeralValue = (int)rank;
                    RankName = numeralValue.ToString();
                    break;
            }
        }
        #endregion

        #region Method
        public void GetCardsValue()
        {
            Console.WriteLine($"\t{this.Symbol}{this.RankName}");
        }
        #endregion

        #region GetterSetter
        //Getter setter
        public Suit Suit { get => suit; set => suit = value; }
        public RankValue Rank { get => rank; set => rank = value; }
        public string RankName { get => rankName; set => rankName = value; }
        public char Symbol { get => symbol; set => symbol = value; }
        public int NumeralValue { get => numeralValue; set => numeralValue = value; }
        #endregion
    }
}
