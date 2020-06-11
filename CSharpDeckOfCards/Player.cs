using System;
using System.Collections.Generic;

public class Player
{
    private string name;
    public List<Card> hand;
    private Random rand;
    public Player(string playerName)
    {
        name = playerName;
        hand = new List<Card>();
        rand = new Random();
    }

    public Card Draw(Deck deck, bool discard)
    {
        hand.Add(deck.GetACardFromDeck());
        if (discard)
           return Discard(rand.Next(0, hand.Count));
        else
           return null;
    }

    public Card Discard(int i)
    {
        try
        {
            Card selectedCard = hand[i];
            hand.RemoveAt(i);
            return selectedCard;
        }
        catch
        {
            return null;
        }

    }
}