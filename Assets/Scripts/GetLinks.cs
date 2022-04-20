using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using SimpleJSON;
using UnityEngine.UI;

[Serializable]
public class GetLinks : MonoBehaviour
{

    public Text test;
    public Image image;

    private Texture2D _webTexture;

    private List<string> links = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ObtainLinks());
        //StartCoroutine(SetImage());
    }

    

    IEnumerator ObtainLinks()
    {
        UnityWebRequest www = UnityWebRequest.Get("https://sheetdb.io/api/v1/srht0jmn4o3pi");
        yield return www.SendWebRequest();
        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log("ERROR : "+ www.error);
            
        }
        else
        {
            test.text = "";
            string json = www.downloadHandler.text;
            var o = JSON.Parse(json);
            var size = o.Count;

            for (int i = 0; i <= size; i++)
            {
                links.Add(o[i]["link"]);
            }

            foreach (var link in links)
            {
                Debug.Log(link);
            }
            UnityWebRequest request = UnityWebRequestTexture.GetTexture(links[0]);

            yield return request.SendWebRequest();

            if (request.isNetworkError || request.isHttpError)
            {
                Debug.Log("Erreur" + request.error);
            }
            else
            {
                //image.texture = ((DownloadHandlerTexture) request.downloadHandler).texture;
                _webTexture = ((DownloadHandlerTexture) request.downloadHandler).texture;
                Sprite imageSprite = Sprite.Create(_webTexture, new Rect(0.0f, 0.0f, _webTexture.width, _webTexture.height), new Vector2(0.5f,0.5f), 100f);
                image.sprite = imageSprite;
                image.preserveAspect = true;
            }
        }
    }

    /*IEnumerator SetImage()
    {
        UnityWebRequest request = UnityWebRequestTexture.GetTexture(links[0]);

        yield return request.SendWebRequest();

        if (request.isNetworkError || request.isHttpError)
        {
            Debug.Log("Erreur" + request.error);
        }
        else
        {
            image.texture = ((DownloadHandlerTexture) request.downloadHandler).texture;
        }
    }*/
}


