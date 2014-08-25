using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace SpellCounters.Models
{
    public abstract class DeckMaker
    {
        public DeckMaker ()
        {
        }

        public abstract Deck MakeDeck();
    }

    public class SimpleRedDeck : DeckMaker {
     
        public override Deck MakeDeck ()
        {
           
            var deck = new Deck ();

            var redLand = new BasicLand () {
                Cost = CardCost.OneRed,
                Color = CardColor.Red
            };

            var redCreature = new Creature () {
                Color = CardColor.Red,
                Cost = CardCost.OneRed,
            };

            deck.AddCards (
                Enumerable.Repeat (redLand, 60));

            //deck.AddCards(
            //    Enumerable.Repeat (redCreature, 60-24));
             

            return deck;
        }

    }
}

