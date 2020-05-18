using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] GameManager gm;
    public void OnCollisionEnter2D(Collision2D collision)

    {
       
        if (collision.gameObject.tag == "Player")
        {

            StartCoroutine(gm.goal());
               
            
        }
    }

}
