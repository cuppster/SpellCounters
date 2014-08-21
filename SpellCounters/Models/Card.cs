using System;

namespace SpellCounters.Models
{
    public abstract class Card
    {
//        public Card (CardColor color) {
//
//        }


        public CardColor Color { get; set; }
        public CardCost Cost { get; set; }

    }

    public class BasicLand : Card {

    }

    public class Creature : Card {

        public int Power { get; set; }
        public int Defense { get; set; }
        public CardType Type { get; set; }
        public CardSubType SubType { get; set; }
    }
}

