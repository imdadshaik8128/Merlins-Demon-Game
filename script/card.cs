using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class card : MonoBehaviour
{
    public cardData cardData = null;

    public Text titleText = null;
    public Text descriptionText = null;
    public Image damageImage = null;
    public Image costImage = null;
    public Image cardImage = null;
    public Image FrameImage = null;
    public Image burnImage = null;

    public void Initialise()
    {
        if (cardData == null)
        {
            Debug.LogError("Card has a CardData!");
            return;
        }

        titleText.text = cardData.cardTitle;
        descriptionText.text = cardData.description;
        cardImage.sprite = cardData.cardImage;
        FrameImage.sprite = cardData.frameImage;
        costImage.sprite = gamecontroller.instance.healthNumbers[cardData.cost];
        damageImage.sprite = gamecontroller.instance.damageNumbers[cardData.damage];
    }
}
