using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnBoarding : MonoBehaviour
{
    public int count = 1;
    public Transform onBaord;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(count>=1)
        {
            onBaord.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        onBaord.gameObject.SetActive(false);
        count = count - 1;
    }
}
