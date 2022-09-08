using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class gamecontroller : MonoBehaviour
{
    static public gamecontroller instance = null;

    public Deck playerDeck = new Deck();
    public Deck enemyDeck = new Deck();

    public Hand playerHand = new Hand();
    public Hand enemyHand = new Hand();

    public List<cardData> cards = new List<cardData>();

    public Sprite[] healthNumbers = new Sprite[10];
    public Sprite[] damageNumbers = new Sprite[10];

    public GameObject cardPrefab = null;
    public Canvas canvas = null;

    private void Awake()
    {
        instance = this;

        playerDeck.Create();
        enemyDeck.Create();

        StartCoroutine (Dealhands());
    }

    public void Quit()
    {
        SceneManager.LoadScene(0);
    }

    public void Skipturn()
    {
        Debug.Log("Skip turn");
    }

    internal IEnumerator Dealhands()
    {
        yield return new WaitForSeconds(1);
        for (int t=0; t<3; t++)
        {
            playerDeck.Dealcard(playerHand);
            enemyDeck.Dealcard(enemyHand);

            yield return new WaitForSeconds(1);
        }
    }
}
