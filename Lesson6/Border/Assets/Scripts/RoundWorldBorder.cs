using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundWorldBorder : MonoBehaviour
{
    private float objectWidth, objectHeight;
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        objectWidth = transform.GetComponent<SpriteRenderer>().bounds.size.x / 2;
        objectHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;
        Debug.Log(screenBounds);

    }

    // Update is called once per frame
    void LateUpdate()
    {
        
        Vector3 viewPos = transform.position;
        Debug.Log("x is " + viewPos.x);
        if (viewPos.x >= screenBounds.x)
        {
            transform.position = new Vector3(viewPos.x * -1 + objectWidth, viewPos.y, viewPos.z);
        }
        if (viewPos.x <= screenBounds.x *-1)
        {
            transform.position = new Vector3(viewPos.x * -1 - objectWidth, viewPos.y, viewPos.z);
        }
        if (viewPos.y >= screenBounds.y)
        {
            transform.position = new Vector3(viewPos.x,viewPos.y * -1 + objectHeight, viewPos.z);
        }
        if (viewPos.y <= screenBounds.y * -1)
        {
            transform.position = new Vector3(viewPos.x,  viewPos.y * -1 - objectHeight, viewPos.z);
        }




    }

}
