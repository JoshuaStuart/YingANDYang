using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public void RestartLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ReturnToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void PlayGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void LoadLevel1()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }

    public void LoadLevel2()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(3);
    }

    public void LoadLevel3()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(4);
    }
    public void LoadLevel4()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(5);
    }

    public void LoadLevel5()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(6);
    }

    public void LoadLevel6()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(7);
    }

    public void LoadLevel7()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(8);
    }
    public void LoadLevel8() //first impossible level
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(9);
    }

}
