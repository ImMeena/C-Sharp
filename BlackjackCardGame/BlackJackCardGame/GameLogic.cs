using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackCardGame
{
    class GameLogic
    {
        #region Fields
        //Fields
        private DeckOfCards deckOfCard;
        public List<Player> players = new List<Player>();
        public bool againPlay = false;
        #endregion

        #region AllMethods
        public void Play()
        {
            againPlay = true;
            Console.Write($"\n\tEnter first player name: ");
            Player player1 = new Player(Console.ReadLine());
            Console.Write($"\n\tEnter second player name: ");
            Player player2 = new Player(Console.ReadLine());

            deckOfCard = new DeckOfCards();

            while (againPlay)
            {
                player1.ClearHand();
                player2.ClearHand();
                if (deckOfCard.RemainingCard() < 15)
                {
                    deckOfCard = new DeckOfCards();
                    deckOfCard.PrintRemainingCard();
                }
                // Deal two card to player1
                deckOfCard.GetCard(player1);
                deckOfCard.GetCard(player1);
                // show player1 cards
                player1.ShowPlayerCards();

                //Deal two card to player2
                deckOfCard.GetCard(player2);
                deckOfCard.GetCard(player2);
                // show player2 cards
                player2.ShowPlayerCards();

                // Check black jack right after getting first 2 cards 
                if (CheckBlackJack(player1, player2) == false)
                {
                    PlayAgain(player1);
                    PlayAgain(player2);
                    GameWinner(player1, player2);
                }
                Console.WriteLine("\n\t\t................This Round Is Over!!!!!!!!!.................\n");
                string playAgain = "";
                do
                {
                    Console.Write("\n\tDo you want to play again ? Yes or No: ");
                    playAgain = Console.ReadLine().ToUpper();
                    switch (playAgain)
                    {
                        case "YES":
                            againPlay = true;
                            break;

                        case "NO":
                            againPlay = false;
                            break;

                        default:
                            Console.WriteLine("\n\tInvalid command.");
                            break;
                    }
                } while (!(playAgain == "YES") && !(playAgain == "NO"));
            }
            PrintEndGame(player1, player2);
        }
        private void PlayAgain(Player currentPlayer, bool isPlayerBusted = false)
        {
            string input = "";
            currentPlayer.IsTurn = true;

            Console.WriteLine($"\n\t{currentPlayer.Name}'s turn. ");

            while (currentPlayer.IsTurn)
            {
                // Prompt player1 to enter DrawAnotherCard or ExitTurn.
                Console.Write($"\n\t{currentPlayer.Name} Do You Want To Draw Another Card (Yes) or (No): ");
                input = Console.ReadLine();

                switch (input.ToUpper())
                {
                    case "YES":
                        currentPlayer.DrawAnotherCard(deckOfCard);
                        currentPlayer.ShowPlayerHand();
                        break;

                    case "NO":
                        //if (currentPlayer.CanPlayerStand(isPlayerBusted))
                        currentPlayer.ExitTurn();
                        break;

                    default:
                        Console.WriteLine("\n\tInvalid command.");
                        break;
                }
                CheckPlayerCard(currentPlayer);
            }
            Console.WriteLine($"\n\t{currentPlayer.Name}'s turn is over.");
        }

        private void CheckPlayerCard(Player currentPlayer)
        {
            // If current player1 is busted, isturn is over.
            if (currentPlayer.CheckPlayerHand() > 21)
            {
                Console.WriteLine($"\n\t\t.....................\tOops \"{currentPlayer.Name} \"is Busted................!");

                currentPlayer.CheckBust = true;
                currentPlayer.IsTurn = false;

            }
            // If current player1 total card in cardInPlayerHand is 6, isturn is over.
            else if (currentPlayer.CardInPlayerHand.Count >= 7)
            {
                Console.WriteLine($"\n\t{currentPlayer.Name} got 6 cards already.");

                currentPlayer.IsTurn = false;
            }
        }


        private bool CheckBlackJack(Player player1, Player player2)
        {
            if (player1.IsBlackJack)
            {
                Console.WriteLine($"\n\t{player1.Name} got natural BlackJack.  \n             " +
                    $"--------------------Wohoooooo {player1.Name} won!-----------------------");
                player1.ShowPlayerCards();
                player1.AddWinnersCount(player1);
                return true;

            }
            else if (player2.IsBlackJack)
            {
                Console.WriteLine($"\n\t{player2.Name} got natural BlackJack.  \n                  " +
                    $"\t\t\t --------------------Wohoooooo {player2.Name} won!-----------------------");
                player2.ShowPlayerCards();
                player2.AddWinnersCount(player2);
                return true;
            }
            return false;
        }

        private void GameWinner(Player player1, Player player2)
        {
            if (!player1.CheckBust && !player2.CheckBust)
            {
                if (player1.CheckPlayerHand() > player2.CheckPlayerHand())
                {
                    Console.WriteLine($"\n\t\t\tWohooo..........{player1.Name} is the winner.............");
                    player1.AddWinnersCount(player1);
                }
                else if (player2.CheckPlayerHand() > player1.CheckPlayerHand())
                {
                    Console.WriteLine($"\n\t\t\tWohooo..........{player2.Name} is the winner.............");
                    player2.AddWinnersCount(player2);
                }
                else
                {
                    Console.WriteLine("\n\t\t\tOops...................Tied....................");
                }
            }

            else if (player1.CheckBust && !player2.CheckBust)
            {
                Console.WriteLine($"\n\t\t\tWohooo..........{player2.Name} is the winner.............");
                player2.AddWinnersCount(player2);

            }
            else if (!player1.CheckBust && player2.CheckBust)
            {
                Console.WriteLine($"\n\t\t\tWohooo..........{player1.Name} is the winner.............");
                player1.AddWinnersCount(player1);
            }
        }

        private void PrintEndGame(Player player1, Player player2)
        {
            Console.WriteLine($"\n\t\t {player1.Name} won {player1.winnerCount} times.");
            Console.WriteLine($"\n\t\t {player2.Name} won {player2.winnerCount} times.");
            if (player1.winnerCount > player2.winnerCount)
            {
                Console.WriteLine($"\n\t\t\t Wohooo..........{player1.Name} is the real winner.............");
            }
            else if (player1.winnerCount < player2.winnerCount)
            {
                Console.WriteLine($"\n\t\t\t Wohooo..........{player2.Name} is the real winner.............");
            }
            else
            {
                Console.WriteLine($"\n\t\t\t Wohooo..........{player1.Name} and {player2.Name} won the equal round.............\n" +
                    $"You both are the winner....");
            }
            Console.WriteLine("\n\t\t\t\t .........Game over.......\n\t\t Thank you for playing \"Black Jack Card Game\"................");
        }
        #endregion
    }
}
