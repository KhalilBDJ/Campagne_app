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
            string name = gameObject.GetComponentInChildren<TMP_Text>().text;
            Debug.Log(name);
            string newName = name.Replace('+', '-');
            GetComponentInChildren<TMP_Text>().SetText(newName);
            Debug.Log(name);
        }
        else
        {
            moreButtons.SetActive(false);
            isOpened = false;
            string name = gameObject.GetComponentInChildren<TMP_Text>().text;
            string newName = name.Replace('-', '+');
            GetComponentInChildren<TMP_Text>().SetText(newName);
        }
    }
}
