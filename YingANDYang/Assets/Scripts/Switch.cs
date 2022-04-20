using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Switch : MonoBehaviour
{
    public GameObject switchUI;
    public GameObject blackBG;
    public GameObject whiteBG;

    public int count;

    public float currentCount;
    public Text countText1;
    public Text countText2;

    private bool blackBGactive;

    public GameObject gameOverCanvas;
    public GameObject gameCanvas;

    public GameObject whiteSwitch;
    public GameObject whiteSwitchNumber;
    public GameObject blackSwitch;
    public GameObject blackSwitchNumber;


    private void Start()
    {
        gameCanvas.gameObject.SetActive(true);
        blackBGactive = false;
        blackSwitch.SetActive(false);
        blackSwitchNumber.SetActive(false);
        currentCount = count;
        countText1.text = currentCount.ToString();
        countText2.text = currentCount.ToString();
    }
    void Update()
    {
        if(count <= 0)
        {
            count = 0;
            currentCount = 0;
        }

        if (count > 0)
        {
            if ((Input.GetKeyDown(KeyCode.Tab) || Input.GetMouseButtonDown(1)) && count > 0)
            {


                if (blackBGactive == true)
                {
                    whiteBG.SetActive(false);
                    blackBG.SetActive(true);

                    count = count - 1;

                    blackBGactive = false;

                    blackSwitch.SetActive(false);
                    blackSwitchNumber.SetActive(false);
                    whiteSwitch.SetActive(true);
                    whiteSwitchNumber.SetActive(true);
                }
                else
                {
                    whiteBG.SetActive(true);
                    blackBG.SetActive(false);

                    count = count - 1;

                    blackBGactive = true;

                    whiteSwitch.SetActive(false);
                    whiteSwitchNumber.SetActive(false);
                    blackSwitch.SetActive(true);
                    blackSwitchNumber.SetActive(true);
                }
                currentCount = count;
                countText1.text = currentCount.ToString();
                countText2.text = currentCount.ToString();

            }
        }
    }
}
