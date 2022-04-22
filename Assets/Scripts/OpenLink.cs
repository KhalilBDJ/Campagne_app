using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLink : MonoBehaviour
{

    public int index;
    public void Link()
    {
        Application.OpenURL(GetAllLinks.links[index]);
    }
    
}
