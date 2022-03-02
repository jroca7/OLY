using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public Text TXTscore;
    public int maxscore;
    public Text TXTmaxscore;

    Text text;
    void Start()
    {
        maxscore = 0;
        maxscore = PlayerPrefs.GetInt("TotalScore");
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {

            Destroy(collision.gameObject);
            score++;

        }
    }

        void Update()
    {
        if (score > PlayerPrefs.GetInt("TotalScore", 0))
        {
            PlayerPrefs.SetInt("TotalScore", score);
        }

        TXTscore.text = "Score: " + score;
        TXTmaxscore.text = "Max Score: " + maxscore;
    }
}
