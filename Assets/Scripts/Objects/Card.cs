using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Suit
{
    Spade = 'S',
    Diamond = 'D',
    Club = 'C',
    Heart = 'H'
}

public class Card : MonoBehaviour
{
    private int rank;
    private Suit suit;

    public Card(int rank, Suit suit)
    {
        this.suit = suit;
        this.rank = rank;
    }

    public string GetRank()
    {
        switch (rank)
        {
            case 1:
                return "A";
            case 11:
                return "J";
            case 12:
                return "Q";
            case 13: 
                return "K";
            default:
                return rank.ToString();
        }
    }

    public Suit GetSuit()
    {
        return suit;
    }

    public string GetCardName()
    {
        return GetRank() + suit + ".jpg";
    }
}
