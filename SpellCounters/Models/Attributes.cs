using System;
using System.Collections.Generic;
using System.Linq;

namespace SpellCounters.Models
{
    public enum CardColor : int {

        Colorless = 0,
        White =1, 
        Blue = 2,
        Red = 3,
        Green = 4,
        Black = 5,
        Any = 6,

    }

    public class CardCost {

        public static readonly CardCost OneRed = new CardCost(CardColor.Red, 1);

        public CardCost() {
            Cost = new List<CardColor> ();
        }

        public CardCost(CardColor color, int count) : this() {
            Cost = new List<CardColor> ();
            Cost.AddRange (Enumerable.Repeat (color, count));
        }

        public List<CardColor> Cost { get; set; }

    }

    public enum CardType : int {

        Creature = 1,

    }

        
    public enum CardSubType : int {

        Human = 1,

    }


}

