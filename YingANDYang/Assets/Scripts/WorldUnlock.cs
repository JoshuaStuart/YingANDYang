using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorldUnlock : MonoBehaviour
{
    public Button[] worldButtons;

    public int world;

    public void Start()
    {
        int levelReached = PlayerPrefs.GetInt("levelReached", 1);
        
        if (levelReached > 0 && levelReached < 7)
        {
            world = 1;
        }
        if (levelReached >= 7 && levelReached < 14)
        {
            world = 2;
        }
        if (levelReached >= 14 && levelReached < 21)
        {
            world = 3;
        }

        for (int i = 0; i < worldButtons.Length; i++)
        {
            if (i + 1 > world)
            {
                worldButtons[i].interactable = false;
            }

        }
    }
}
