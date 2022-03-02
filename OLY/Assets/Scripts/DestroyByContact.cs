using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DestroyByContact : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            SceneManager.LoadScene(0);
        }

        if (collision.transform.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            SpawnMoneda();
        }
    }
    public GameObject moneda;

    public void SpawnMoneda()
    {
        Instantiate(moneda, transform.position, transform.rotation);
    }
}

