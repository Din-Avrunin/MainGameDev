using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowSensor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Enemy enemy = other.transform.GetComponent<Enemy>();
            if(enemy!=null)
            enemy.SetSensor();
        }
    }
}
