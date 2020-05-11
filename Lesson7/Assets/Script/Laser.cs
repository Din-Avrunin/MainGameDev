using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    private int direction;
    // Start is called before the first frame update
    void Start()
    {
        direction = Random.Range(0, 2);
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += new Vector3(0,  9f * Time.unscaledDeltaTime, 0);
        if (direction == 1)
            transform.Rotate(Vector3.forward * 0.5f);
        else
            transform.Rotate(Vector3.back * 0.7f);

        if (transform.position.y>8.0f)
        {
            if (transform.parent != null)
            {
                Destroy(transform.parent.gameObject);
            }
            Destroy(this.gameObject);
        }
       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       
        
        if (other.tag == "Enemy")
        {
            Destroy(this.gameObject);
        }
    }
}
