using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] LayerMask lm;
    [SerializeField] float speed;
    [SerializeField] float power;
    private Rigidbody2D rb;
    private BoxCollider2D bc;

    void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();
        bc = transform.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    private void Update()
    {
    if (Input.GetKey(KeyCode.RightArrow)) rb.velocity += Vector2.right * speed;
       else if (Input.GetKey(KeyCode.LeftArrow)) rb.velocity += Vector2.right * speed * -1;       
        if (isGrounded() && Input.GetKey(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x,power);
        }
    }
    private Boolean isGrounded() {

        RaycastHit2D rc = Physics2D.BoxCast(bc.bounds.center, bc.bounds.size,0f,Vector2.down, .1f,lm);
        return rc.collider != null;
        /*  Collider2D c = Physics2D.OverlapBox(bc.bounds.center, bc.bounds.size*Vector2.up, 0f, lm);
          return c != null;*/
      /*  RaycastHit2D rc = Physics2D.Raycast(bc.bounds.center, Vector2.down, bc.bounds.extents.y + 0.01f, lm);
        return rc.collider != null;*/
    }
}