using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PlayYourCardsRightWinForms
{
    /// <summary>
    /// ENUM of CardSuite
    /// Hearts = 0, Diamonds = 1, Clubs = 2, Spades = 3
    /// </summary>
    public enum CardSuit
    {
        Hearts, 
        Diamonds, 
        Clubs,
        Spades
    }

    /// <summary>
    /// Playing Card Class holding a single card of a Rank and Suit
    /// </summary>
    internal class PlayingCard
    {
        public int Rank;
        public CardSuit Suit;
        public string propertystring;

        /// <summary>
        /// Constructor to create the card.
        /// </summary>
        /// <param name="rank">Number of card from 2 - 14</param>
        /// <param name="suit">Card suit as an enum.</param>
        public PlayingCard (int rank, CardSuit suit)
        {
            Rank = rank;
            Suit = suit;
            propertystring = PropertyStringCreator();
        }

        /// <summary>
        /// Override the ToString() so it prints the correct format of cards.
        /// </summary>
        /// <returns>current card as string.</returns>
        public override string ToString()
        {
            string rankstring = "";

            switch (Rank)
            {
                case 11:
                    rankstring = "Jack";
                    break;
                case 12:
                    rankstring = "Queen";
                    break;
                case 13:
                    rankstring = "King";
                    break;
                case 14:
                    rankstring = "Ace";
                    break;
                default:
                    rankstring = Rank.ToString();
                    break;
            }
            
            return $"{rankstring} of {Suit}";
        }

        private string PropertyStringCreator()
        {
            //get the string
            string propertystring = ToString().ToLower();
            propertystring = propertystring.Replace (' ', '_');  //replace spaces with underscores.
            if (Rank < 11)
            {
                //if it starts a number, the property must begin with an underscore.
                propertystring = "_" + propertystring;
            }

            return propertystring;
        }
    }
}
