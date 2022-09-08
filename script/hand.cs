using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Hand
{
    public card[] cards = new card[3];
    public Transform[] positions = new Transform[3];
    public string[] animNames = new string[3];
    public bool isPlayers;
}
