using System;
using System.Collections.Generic;
using ShedWebService.Domain.Entity;
using ShedWebService.Domain.Enums;
using ShedWebService.Domain.Extenders;

namespace ShedWebService.Utility
{
    public class CardUtilities
    {
        public static List<Card> CreateShuffledDeck()
        {
            List<Card> cards = new List<Card>();

            foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
            {
                foreach (CardValue value in Enum.GetValues(typeof(CardValue)))
                {
                    cards.Add(new Card(suit, value));
                }
            }
            cards.Shuffle();
            return cards;
        }
    }
}
