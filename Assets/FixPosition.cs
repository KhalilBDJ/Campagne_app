using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixPosition : MonoBehaviour
{
    private float xPosition;
    void Start()
    {
        xPosition = gameObject.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(xPosition, transform.position.y, transform.position.z);
    }
}
