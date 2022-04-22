using System.Collections;
using System.Collections.Generic;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class InstantiatePhotos : MonoBehaviour
{
    public GameObject photoAndNamePrefab;
    public string url;
    

    private Texture2D _webTexture;
    private int c = 0;

    private List<string> links = new List<string>();
    private List<string> names = new List<string>();
    void Start()
    {
        StartCoroutine(ObtainLinks());
    }
    
    IEnumerator ObtainLinks()
    {
        UnityWebRequest www = UnityWebRequest.Get(url);
        yield return www.SendWebRequest();
        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log("ERROR : "+ www.error);
            
        }
        else
        {
            string json = www.downloadHandler.text;
            var o = JSON.Parse(json);
            var size = o.Count;


            if (o["values"] != null)
            {
                for (int i = 1; i <= size; i++)
                {
                    if (o["values"][1][i] != null)
                    {
                        links.Add(o["values"][1][i]);
                    }
                    
                }

                for (int i = 1; i <=size; i++)
                {
                    if (o["values"][0][i] != null)
                    {
                        names.Add(o["values"][0][i]);
                    }
                    
                }

                foreach (var link in links)
                {
                    UnityWebRequest request = UnityWebRequestTexture.GetTexture(link);

                    yield return request.SendWebRequest();

                    if (request.isNetworkError || request.isHttpError)
                    {
                        Debug.Log("Erreur" + request.error);
                    }
                    else
                    {
                        Debug.Log(link);
                        Debug.Log(names[c]);
                        _webTexture = ((DownloadHandlerTexture) request.downloadHandler).texture;
                        photoAndNamePrefab.GetComponentInChildren<Image>().sprite = Sprite.Create(_webTexture, new Rect(0.0f, 0.0f, _webTexture.width, _webTexture.height), new Vector2(0.5f,0.5f), 100f);
                        photoAndNamePrefab.GetComponentInChildren<Image>().preserveAspect = true;
                        photoAndNamePrefab.GetComponentInChildren<TMP_Text>().text = names[c].Replace(".png","");
                        Instantiate(photoAndNamePrefab,gameObject.transform);
                        c++;
                    }
                }
            }
            else
            {
                Debug.Log("le dossier est vide");
            }

        }
    }
   
}
