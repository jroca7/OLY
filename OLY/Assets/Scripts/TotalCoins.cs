using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TotalCoins : MonoBehaviour
{
    public int coins;
    public Text TXTcoins;
    public int shoots;
    public Text TXTShoots;

    Text text;
    void Start()
    {
        shoots = PlayerPrefs.GetInt("TotalShoots");
        coins = PlayerPrefs.GetInt("TotalCoins");
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {

            Destroy(collision.gameObject);
            coins++;
            PlayerPrefs.SetInt("TotalCoins", coins);
        }
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            shoots++;
            PlayerPrefs.SetInt("TotalShoots", shoots);
        }

        TXTcoins.text = "Total Coins: " + coins;
        TXTShoots.text = "Total Clicks: " + shoots;
    }
}

