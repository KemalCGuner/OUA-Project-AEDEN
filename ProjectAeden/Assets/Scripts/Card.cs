using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]

public class Card: ScriptableObject
{
    //Temel Kart Degerleri
    public int cardID;
    public string cardName;
    public CardSprite sprites;
    public string dialogue;
    public string leftQuote;
    public string rightQuote;
    //Kart Degerleri
    public int energy;


    public void Left()
    {
        Debug.Log(cardName + "Swiped Left");
    }

    public void Right()
    {
        Debug.Log(cardName + "Swiped Right");
    }
}
