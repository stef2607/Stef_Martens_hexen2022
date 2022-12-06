using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{

    public CardType cardtype;
    public Sprite[] images;

    void Start()
    {
        switch (cardtype)
        {
            case CardType.Diagonal:
                gameObject.GetComponent<Image>().sprite = images[0];
                break;
            case CardType.Push:
                gameObject.GetComponent<Image>().sprite = images[1];
                break;
            case CardType.Slash:
                gameObject.GetComponent<Image>().sprite = images[2];
                break;
            case CardType.Teleport:
                gameObject.GetComponent<Image>().sprite = images[3];
                break;
        }
    }
}
