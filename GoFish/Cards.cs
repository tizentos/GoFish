using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFish
{
    partial class Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }
        public string Name { get { return Value.ToString() + " of " + Suit.ToString(); } }
        public Card(Suits suit, Values value)
        {
            this.Suit = suit;
            this.Value = value;
        }
        public static string Plural(Values value)
        {
            if (value == Values.Six)
                return "Sixes";
            else
                return value.ToString() + "s";
        }
    }
         enum Suits
        {
            Spades,
            Clubs,
            Diamonds,
            Hearts
        }
         enum Values
        {
            Ace = 1,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King
        }
        class CardComparer_bySuit : IComparer<Card>
        {
            public int Compare(Card x, Card y)
            {
                if (x.Suit > y.Suit)
                    return 1;
                if (x.Suit < y.Suit)
                    return -1;
                if (x.Value > y.Value)
                    return 1;
                if (x.Value < y.Value)
                    return -1;
                return 0;
            }
        }
        class CardComparer_byValue : IComparer<Card>
        {
            public int Compare(Card x, Card y)
            {
                if (x.Value > y.Value)
                    return 1;
                if (x.Value < y.Value)
                    return -1;
                else
                    return 0;
            }
        }
}
