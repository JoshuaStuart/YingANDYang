using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public int shopTicketValue;
    public Text ticketValue;

    public Transform shopCanvas;
    public Transform levelCanvas;

    private int selectedColour;

    //ColourThemes
    public GameObject blackAndWhite;
    public GameObject redAndBlue;
    public GameObject purpleAndGreen;


    private void Awake()
    {
        shopCanvas.gameObject.SetActive(false);
        shopTicketValue = PlayerPrefs.GetInt("ticketValue");
        ticketValue.text = shopTicketValue.ToString();
    }

    public void OpenShop()
    {
        shopCanvas.gameObject.SetActive(true);
        levelCanvas.gameObject.SetActive(false);
    }

    public void CloseShop()
    {
        shopCanvas.gameObject.SetActive(false);
        levelCanvas.gameObject.SetActive(true);
    }

    public void SetBlackAndWhite()
    {
        PlayerPrefs.SetInt("colourTheme", 1);
        blackAndWhite.gameObject.SetActive(true);
        redAndBlue.gameObject.SetActive(false);
        purpleAndGreen.gameObject.SetActive(false);
    }

    public void SetRedAndBlue()
    {
        PlayerPrefs.SetInt("colourTheme", 2);
        blackAndWhite.gameObject.SetActive(false);
        redAndBlue.gameObject.SetActive(true);
        purpleAndGreen.gameObject.SetActive(false);
    }
    public void SetPurpleAndGreen()
    {
        PlayerPrefs.SetInt("colourTheme", 3);
        blackAndWhite.gameObject.SetActive(false);
        redAndBlue.gameObject.SetActive(false);
        purpleAndGreen.gameObject.SetActive(true);
    }
    
}
