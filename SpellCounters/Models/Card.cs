using System;

namespace SpellCounters.Models
{
  public abstract class Card
  {

    public CardColor Color { get; set; }
    public CardCost Cost { get; set; }
    public bool IsTapped { get; set; }

    public virtual bool IsBasicLand { get { return false; } }

  }

  public class BasicLand : Card
  {
    public override bool IsBasicLand { get { return true; } }

    public override string ToString()
    {
      return string.Format("<BasicLand {0}>", Color);
    }
  }

  public class Creature : Card
  {

    public int Power { get; set; }
    public int Defense { get; set; }
    public CardType Type { get; set; }
    public CardSubType SubType { get; set; }
  }
}

