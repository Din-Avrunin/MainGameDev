using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlatform : MonoBehaviour
{
    [SerializeField] Transform left;
    [SerializeField] Transform right;
    [SerializeField] float speed;
    Vector3 nextpos;
    [SerializeField]Boolean isRight = true;
    // Start is called before the first frame update
    void Start()
    {
        if(isRight)
        nextpos = right.position;   
        else nextpos = left.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isRight && transform.position.x >= right.position.x)
        {
            nextpos = left.position;
            isRight = false;
        }
        else if (!isRight && transform.position.x <= left.position.x) { 
            nextpos = right.position;
            isRight = true;
        }
        transform.position = Vector3.MoveTowards(transform.position, nextpos, Time.deltaTime*speed);
    }
    /*  public void OnCollisionStay2D(Collision2D collision)
      {
          if (collision.gameObject.tag == "Player")
          {
              int right = 1;
              if (!isRight) right = -1;
              Debug.Log(new Vector2(Time.deltaTime * speed * right * 5, collision.rigidbody.velocity.y));
              collision.rigidbody.velocity = new Vector2(collision.rigidbody.velocity.x+  (speed * right), collision.rigidbody.velocity.y);
          }*/
   /* public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.transform.parent = transform;
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.transform.parent = null;
        }
    }*/

}


