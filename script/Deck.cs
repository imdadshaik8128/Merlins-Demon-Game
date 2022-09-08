using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Deck
{
    public List<cardData> cardDatas = new List<cardData>();
    public void Create()
    {
        List<cardData> cardDataInOrder = new List<cardData>();
        foreach (cardData cardData in gamecontroller.instance.cards)
        {
            for (int i = 0; i < cardData.numberInDeck; i++)
            {
                cardDataInOrder.Add(cardData);
            }
        }

        while (cardDataInOrder.Count > 0)
        {
            int randomIndex = Random.Range(0, cardDataInOrder.Count);
            cardDatas.Add(cardDataInOrder[randomIndex]);
            cardDataInOrder.RemoveAt(randomIndex);

        }
    }
    private cardData RandomCard()
    {
        cardData result = null;
        if (cardDatas.Count == 0)
            Create();
        result = cardDatas[0];
        cardDatas.RemoveAt(0);

        return result;
    }
    private card CreateNewCard(Vector3 position, string animName)
    {
        GameObject newCard = GameObject.Instantiate(gamecontroller.instance.cardPrefab, gamecontroller.instance.canvas.gameObject.transform);
        newCard.transform.position = position;
        card card = newCard.GetComponent<card>();
        if (card)
        {
            card.cardData = RandomCard();
            card.Initialise();
            Animator animator = newCard.GetComponentInChildren<Animator>();
            if (animator)
            {
                animator.CrossFade(animName, 0);
            }
            else
            {
                Debug.LogError("no animator found");

            }
            return card;
        }
        else
        {
            Debug.LogError("no card component found");
            return null;
        }
    }
    internal void Dealcard(Hand hand)
    {
        for (int h = 0; h < 3; h++)
        {
            if (hand.cards[h] == null)
            {
                hand.cards[h] = CreateNewCard(hand.positions[h].position, hand.animNames[h]);
                return;
            }
        }
    }

}
