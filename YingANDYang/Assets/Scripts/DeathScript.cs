using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
    public Transform gameOverCanvas;
    public Transform gameCanvas;

    public AudioSource playerHits;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerHits.Play();

            Time.timeScale = 0;
            gameOverCanvas.gameObject.SetActive(true);
            gameCanvas.gameObject.SetActive(false);
        }
    }
}
