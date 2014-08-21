using System;
using System.Collections.Generic;
using System.Linq;

namespace SpellCounters.Models
{
    public class Deck
    {
        public Deck ()
        {
            Cards = new List<Card> ();
        }

        public void Shuffle() {
            Cards = Cards.OrderBy(a => Guid.NewGuid());
        }
    
        public int Count { get; set; }

        public List<Card> Cards { get; set; }
    }
}

