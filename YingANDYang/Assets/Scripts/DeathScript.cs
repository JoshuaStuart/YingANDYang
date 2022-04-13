using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
    public Transform gameOverCanvas;
    public Transform gameCanvas;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Time.timeScale = 0;
            gameOverCanvas.gameObject.SetActive(true);
            gameCanvas.gameObject.SetActive(false);
        }
    }
}
