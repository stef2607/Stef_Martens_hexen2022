using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public GameObject Cards;
    public List<GameObject> allCards = new List<GameObject>();
    public GameObject cardPrefab;
    void Start()
    {
        // kaarten instantiaten

        for (int i = 0; i < 12; i++)
        {
            var addCard = Instantiate(cardPrefab, Cards.transform.position, Quaternion.identity);
            addCard.GetComponent<Card>().cardtype = (CardType)Random.Range(0, 3);
            addCard.GetComponent<Dragger>().cardManager = this;
            addCard.transform.SetParent(Cards.transform);
            allCards.Add(addCard);
        }

        // eerste 5 op scherm, de rest disabelen
        orderCards();
    }

    void Update()
    {

    }

    public void orderCards(GameObject removeCard = null)
    {
        // kaarten ordenen
        int ofset = -300;
        int i = 0;
        foreach (var item in allCards)
        {
            if (allCards.Count == 4 && i != 0)
                ofset += 50;
            if (allCards.Count == 3 && i != 0)
                ofset += 150;
            if (allCards.Count == 2 && i != 0)
                ofset += 450;
            if (i <= 4)
            {
                item.transform.position = Cards.transform.position + new Vector3(ofset, 0, 0);
                item.SetActive(true);
            }

            else
                item.SetActive(false);

            ofset += 150;
            i++;

            if (allCards.Count == 1)
            {
                item.transform.position = Cards.transform.position;
            }

        }
    }
}
