using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour
{
    
    public Card card;
    BoxCollider2D thisCard;
    public bool isMouseOver;

    public void Start()
    {
        thisCard = gameObject.GetComponent<BoxCollider2D>();
    }

    private void OnMouseOver()
    {
        isMouseOver = true;
    }

    private void OnMouseExit()
    {
        isMouseOver = false;

    }


}




public enum CardSprite
{
    CREW1,
    CREW2,
    CREW3,
    CREW4,
    CREW5,
    CREW6,
    CREW7,
    CREW8,
    CREW9,
    CREW10,
    CREW11,
}
