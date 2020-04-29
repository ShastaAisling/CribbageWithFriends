using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    private List<Card> cards;

    public Deck()
    {
        cards = new List<Card>();
        Shuffle();
    }

    public void Shuffle()
    {
        cards.Clear();

        for (int i = 1; i <= 13; i++)
        {
            cards.Add(new Card(i, Suit.Club));
            cards.Add(new Card(i, Suit.Diamond));
            cards.Add(new Card(i, Suit.Heart));
            cards.Add(new Card(i, Suit.Spade));
        }
    }

    public Card Deal()
    {
        Card dealtCard = cards[Random.Range(0, cards.Count)];
        cards.Remove(dealtCard);
        return dealtCard;
    }
}
