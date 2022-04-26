using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public int shopTicketValue;
    public int shopGemValue;
    public Text ticketValue;
    public Text gemValue;

    public Transform shopCanvas;
    public Transform levelCanvas;

    private int selectedColour;

    //ColourThemes
    public GameObject blackAndWhite;
    public GameObject redAndBlue;
    public GameObject purpleAndGreen;

    //see if purchased
    private int redBluePurchased;
    private int purpleGreenPurchased;

    //set if purchased
    public GameObject redBlueNot;
    public GameObject purpleGreenNot;
    public GameObject redBlueYes;
    public GameObject purpleGreenYes;


    private void Awake()
    {
        shopCanvas.gameObject.SetActive(false);
    }

    private void FixedUpdate()
    {
        shopGemValue = PlayerPrefs.GetInt("gemValue");
        gemValue.text = shopGemValue.ToString();

        shopTicketValue = PlayerPrefs.GetInt("ticketValue");
        ticketValue.text = shopTicketValue.ToString();

        redBluePurchased = PlayerPrefs.GetInt("redBlue");
        purpleGreenPurchased = PlayerPrefs.GetInt("purpleGreen");

        if (redBluePurchased == 0)
        {
            redBlueNot.gameObject.SetActive(true);
            redBlueYes.gameObject.SetActive(false);
        }
        else
        {
            redBlueNot.gameObject.SetActive(false);
            redBlueYes.gameObject.SetActive(true);
        }

        if (purpleGreenPurchased == 0)
        {
            purpleGreenNot.gameObject.SetActive(true);
            purpleGreenYes.gameObject.SetActive(false);
        }
        else
        {
            purpleGreenNot.gameObject.SetActive(false);
            purpleGreenYes.gameObject.SetActive(true);
        }
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

    public void BuyRedBlue()
    {
        if(shopTicketValue >= 1000)
        { 
            PlayerPrefs.SetInt("redBlue", 1);
            PlayerPrefs.SetInt("ticketValue", shopTicketValue - 1000);
        }
    }

    public void BuyPurpleGreen()
    {
        if (shopTicketValue >= 3000)
        {
            PlayerPrefs.SetInt("purpleGreen", 1);
            PlayerPrefs.SetInt("ticketValue", shopTicketValue - 3000);
        }
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
    
    public void Buy1000Gems()
    {
        PlayerPrefs.SetInt("gemValue", shopGemValue + 1000);
    }

    public void Buy10000Gems()
    {
        PlayerPrefs.SetInt("gemValue", shopGemValue + 10000);
    }

    public void Buy3000Gems()
    {
        PlayerPrefs.SetInt("gemValue", shopGemValue + 3000);
    }

    public void Buy500Tickets()
    {
        if(shopGemValue >= 5000)
        {
            PlayerPrefs.SetInt("gemValue", shopGemValue - 5000);
            PlayerPrefs.SetInt("ticketValue", shopTicketValue + 500);
        }
    }

    public void Buy1000Tickets()
    {
        if(shopGemValue >= 7000)
        {
            PlayerPrefs.SetInt("gemValue", shopGemValue - 7000);
            PlayerPrefs.SetInt("ticketValue", shopTicketValue + 1000);
        }
    }
}
