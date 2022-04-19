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
}
