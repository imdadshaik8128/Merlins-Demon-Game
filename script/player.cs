using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class player : MonoBehaviour
{
    public Image playerImage = null;
    public Image glowImage = null;
    public Image healthImage = null;
    public Image mirrorImage = null;

    public int health = 5;
    public int mana = 1;
    public bool isPlayer;
    public bool isFire;

    public GameObject[] manaBalls = new GameObject[5];
    private Animator animator = null;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    internal void PlayHitAnim()
    {
        if (animator != null)
        {
            animator.SetTrigger("Hit");
        }
    }
}
