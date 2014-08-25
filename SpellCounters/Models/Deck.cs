using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace SpellCounters.Models
{
  public class Deck
  {
    private List<Card> _cards;

    public Deck()
    {
      _cards = new List<Card>();
    }

    public void Shuffle()
    {
      _cards = _cards.OrderBy(a => Guid.NewGuid()).ToList();
    }

    public bool HasCard(Card card)
    {
      return _cards.Contains(card);
    }

    public int Count { get { return _cards.Count(); } }

    public Card[] Cards { get { return _cards.ToArray(); } }

    public void AddCards(IEnumerable<Card> cards)
    {
      _cards.AddRange(cards);
    }

    public void AddCard(Card card)
    {
      _cards.Add(card);
    }

    public Card RemoveTopCard()
    {
      // get last card
      var last_index = _cards.Count - 1;
      var lastCard = _cards[last_index];
      _cards.RemoveAt(last_index);
      return lastCard;
    }

    public bool RemoveCard(Card card)
    {
     return _cards.Remove(card);
    }

   


  }
}

