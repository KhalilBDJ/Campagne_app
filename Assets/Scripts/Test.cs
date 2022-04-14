using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Test : MonoBehaviour
{

    private bool isOpened = false;
    public GameObject moreButtons;
    public void Open()
    {
        if (!isOpened)
        {
            moreButtons.SetActive(true);
            isOpened = true;
            GetComponentInChildren<TMP_Text>().SetText("- LES OPES");
        }
        else
        {
            moreButtons.SetActive(false);
            isOpened = false;
            GetComponentInChildren<TMP_Text>().SetText("+ LES OPES");
        }
    }
}
