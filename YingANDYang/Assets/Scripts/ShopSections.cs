using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopSections : MonoBehaviour
{
    public GameObject gems;
    public GameObject tickets;
    public GameObject skins;
    public GameObject selectButtons;

    public void OpenGems()
    {
        gems.gameObject.SetActive(true);
        selectButtons.gameObject.SetActive(false);
    }

    public void OpenTickets()
    {
        tickets.gameObject.SetActive(true);
        selectButtons.gameObject.SetActive(false);
    }
    
    public void OpenSkins()
    {
        skins.gameObject.SetActive(true);
        selectButtons.gameObject.SetActive(false);
    }

    public void BackButtton()
    {
        gems.gameObject.SetActive(false);
        tickets.gameObject.SetActive(false);
        skins.gameObject.SetActive(false);
        selectButtons.gameObject.SetActive(true);

    }
}
