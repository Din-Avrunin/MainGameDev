using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderDestroy : MonoBehaviour
{
    private float objectWidth, objectHeight;
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {

        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
      

    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 viewPos = transform.position;
        if (this.tag == "Enemy")
        {
            if (transform.position.y < screenBounds.y * -1 - 5)
                Destroy(this.gameObject);
        }
        else if (this.tag == "Laser")
        {
            if (transform.position.y > screenBounds.y + 5)
                Destroy(this.gameObject);
        }
        else if (this.tag == "Player")
        {
            objectWidth = transform.GetComponent<SpriteRenderer>().bounds.size.x / 2;
            objectHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;

            if (transform.position.y < screenBounds.y * -1 - objectHeight)
            {
                ourScript.shem = 0;
                Destroy(this.gameObject);
            }
            if (transform.position.y > screenBounds.y * + objectHeight)
            {
                ourScript.shem = 0;
                Destroy(this.gameObject);
            }
            if (transform.position.x < screenBounds.x * -1 - objectWidth)
            {
                ourScript.shem = 0;
                Destroy(this.gameObject);
            }
            if (transform.position.x > screenBounds.x * + objectWidth)
            {
                ourScript.shem = 0;
                Destroy(this.gameObject);
            }

        }
        
       



    }

}
