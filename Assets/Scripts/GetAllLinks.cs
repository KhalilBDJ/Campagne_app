using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using SimpleJSON;

public class GetAllLinks : MonoBehaviour
{
    public static List<string> links = new List<string>();
    private int i = 0;
    void Start()
    {
        StartCoroutine(getLinks());

    }

    IEnumerator getLinks()
    {
        UnityWebRequest request =
            UnityWebRequest.Get(
                "https://sheets.googleapis.com/v4/spreadsheets/1t_HVwBQiwWHqoE8mS34dC3O2FZniF9WW8bH4JVlBykU/values/LINKS?majorDimension=COLUMNS&key=AIzaSyA_A4lVW0iUeOs6iegs6fmwgh9tONzhASY");
        yield return request.SendWebRequest();
        
        if (request.isNetworkError || request.isHttpError)
        {
            Debug.Log("ERROR : " + request.error);
        }
        
        string json = request.downloadHandler.text;
        var o = JSON.Parse(json);
        Debug.Log(o);

        while (o["values"][1][i] != null)
        {
            links.Add(o["values"][1][i]);
            Debug.Log(links[i]);
            i++;
        }
    }
}
