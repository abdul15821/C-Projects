using System;

public class Card
{
    public string [] stringVal = {"A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"};
    public char suit;
    public int val;
    public Card(char suitType, int cardVal)
    {
        val = cardVal;
        suit = suitType;
    }

    internal string CardImage()
    {
        return suit + stringVal[val];
    }
}