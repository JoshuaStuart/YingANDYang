using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUnlock : MonoBehaviour
{
    //locking stuff such as levels
    public Button[] levelButtons;

    public int level;

    public void Start()
    {
        int levelReached = PlayerPrefs.GetInt("levelReached", 1);
        level = levelReached;

        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i + 1 > levelReached)
            {
                levelButtons[i].interactable = false;
            }

        }
    }

    
}
