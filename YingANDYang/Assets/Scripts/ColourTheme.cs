using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourTheme : MonoBehaviour
{
    private int selectedColour;
    
    public GameObject blackAndWhite;
    public GameObject redAndBlue;
    public GameObject purpleAndGreen;

    private void Awake()
    {
        selectedColour = PlayerPrefs.GetInt("colourTheme");

        if(selectedColour == 1)
        {
            blackAndWhite.gameObject.SetActive(true);
            redAndBlue.gameObject.SetActive(false);
            purpleAndGreen.gameObject.SetActive(false);
        }

        if(selectedColour == 2)
        {
            blackAndWhite.gameObject.SetActive(false);
            redAndBlue.gameObject.SetActive(true);
            purpleAndGreen.gameObject.SetActive(false);
        }

        if (selectedColour == 3)
        {
            blackAndWhite.gameObject.SetActive(false);
            redAndBlue.gameObject.SetActive(false);
            purpleAndGreen.gameObject.SetActive(true);
        }
    }
}
