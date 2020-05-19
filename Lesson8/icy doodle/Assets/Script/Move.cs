using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] LayerMask filterMask;
    [SerializeField] float speed;
    [SerializeField] float power;
     Rigidbody2D rb;
     BoxCollider2D body;

    void Start()
    {
       rb = transform.GetComponent<Rigidbody2D>();
       body = transform.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    private void Update()
    {
    if (Input.GetKey(KeyCode.RightArrow)) rb.velocity += Vector2.right * speed * Time.deltaTime;
       else if (Input.GetKey(KeyCode.LeftArrow)) rb.velocity += Vector2.right * speed * -1 * Time.deltaTime;       
        if (isGrounded() && Input.GetKey(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x,power);
        }
    }
    private Boolean isGrounded() {

        RaycastHit2D rc = Physics2D.BoxCast(body.bounds.center, body.bounds.size,0f,Vector2.down, .1f, filterMask);
        return rc.collider != null;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("movingPlatform"))
        {
            this.transform.parent = collision.transform;
        }

    }


    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("movingPlatform"))
        {
            this.transform.parent = null;
        }

    }



}