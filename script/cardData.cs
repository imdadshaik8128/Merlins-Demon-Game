using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Card", menuName = "CardGame/Card")]
public class cardData : ScriptableObject
{
    public enum DamageType
    {
        Fire,
        Ice,
        Both
    }
    public string cardTitle;
    public string description;
    public int cost;
    public int damage;
    public DamageType damageType;
    public Sprite cardImage;
    public Sprite frameImage;
    public int numberInDeck;
    public bool isDefenseCard = false;
    public bool isMirrorCard = false;
    public bool isMulti = false;
}
