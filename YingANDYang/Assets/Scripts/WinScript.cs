using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour
{
    public Transform winCanvas;
    public Transform gameCanvas;

    public string currentLevel = "Level1";
    public int currentLevelIndex = 1;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Time.timeScale = 0;
            winCanvas.gameObject.SetActive(true);
            gameCanvas.gameObject.SetActive(false);

            WinLevel();
        }
    }
    public void WinLevel()
    {
        PlayerPrefs.SetInt("levelReached", currentLevelIndex + 1);
    }
}
