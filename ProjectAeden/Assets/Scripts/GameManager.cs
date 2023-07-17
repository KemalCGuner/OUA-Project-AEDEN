using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour



{
    //Enerji
    public static int energy;
    public int minEnergy;
    public int maxEnergy;

    //Game Objects
    public GameObject cardGameObject;
    public CardController mainCardController;
    public SpriteRenderer cardSpriteRenderer;
    public ResourceManager resourceManager;
    //Tweaking Variables
    public float fMovingSpeed;
    public float fSideMargin;
    public float fSideTrigger;
    float alphaText;
    public Color textColor;
    public Color actionBackgroundColor;
    public int divideValue;
    int rollDice;
    Vector3 pos;
    public float ftransparency = 0.7f;
    //UI
    public TMP_Text display;
    public TMP_Text actionQuote;
    public TMP_Text characterDialogue;
    public SpriteRenderer actionBackground;
    //Card Variables
    private string leftQuote;
    private string rightQuote;
    public Card currentCard;
    public Card testCard;

    
  
    void Start()
    {
        LoadCard(testCard);
    }

    void UpdateDialogue()
    {
        actionQuote.color = textColor;
        actionBackground.color = actionBackgroundColor;
        if(cardGameObject.transform.position.x > 0)
        {
            actionQuote.text = leftQuote;
        }
        else
        {
            actionQuote.text = rightQuote;
        }
    }

    
    void Update()
    {
        //Dialogue text Handling
        textColor.a = Mathf.Min((Mathf.Abs(cardGameObject.transform.position.x) - fSideMargin) / divideValue, 1);
        actionBackgroundColor.a = Mathf.Min((Mathf.Abs(cardGameObject.transform.position.x) - fSideMargin) / divideValue, ftransparency);

        if (cardGameObject.transform.position.x > fSideTrigger)
        {
            if (Input.GetMouseButtonUp(0))
            {
                currentCard.Right();
                NewCard();
            }
        }
        else if (cardGameObject.transform.position.x > fSideMargin)
        {

        }
        else if (cardGameObject.transform.position.x > -fSideMargin)
        {
            textColor.a = 0;
        }
        else if (cardGameObject.transform.position.x > -fSideTrigger)
        {

        }
        else
        {
            UpdateDialogue();
            if (Input.GetMouseButtonUp(0))
            {
                currentCard.Left();
                NewCard();
            }
        }

        UpdateDialogue();

        //Movement
        if(Input.GetMouseButton(0) && mainCardController.isMouseOver)
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            cardGameObject.transform.position = pos;
        }
        else
        {
            cardGameObject.transform.position = Vector2.MoveTowards(cardGameObject.transform.position, new Vector2(0, 1), fMovingSpeed);
        }

        display.text = "" + textColor.a;
        
    }



    public void LoadCard(Card card)
    {
        cardSpriteRenderer.sprite = resourceManager.sprites[(int)card.sprites];
        leftQuote = card.leftQuote;
        rightQuote = card.rightQuote;
        currentCard = card;
        characterDialogue.text = card.dialogue;
    }

    public void NewCard()
    {
        int rollDice = Random.Range(0, resourceManager.cards.Length);
        LoadCard(resourceManager.cards[rollDice]);
    }
}
