using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class Destroyed : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float NumberofCollisions = 2;
     public void OnCollisionEnter2D(Collision2D collision)
    {
        string tag = collision.gameObject.tag;
        if (tag == "Player" || tag=="Boarder") {
            NumberofCollisions--;
            if(NumberofCollisions==0)Destroy(this.gameObject);
        }
    }
    
}
