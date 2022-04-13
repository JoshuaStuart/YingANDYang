using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour
{
    public Transform winCanvas;
    public Transform gameCanvas;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Time.timeScale = 0;
            winCanvas.gameObject.SetActive(true);
            gameCanvas.gameObject.SetActive(false);
        }
    }
}
