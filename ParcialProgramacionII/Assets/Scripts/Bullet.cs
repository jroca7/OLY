using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour
{
    public int scoreValue = 5;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            //ScoreManager.score + scoreValue;
        }
        else
        {
         Destroy(gameObject);
        }
    }
}
