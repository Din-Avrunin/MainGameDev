using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameManager gm;
    [SerializeField] Transform left;
    [SerializeField] Transform right;
    [SerializeField] float speed;
    Vector3 nextpos;
    [SerializeField] Boolean isRight = true;
    // Start is called before the first frame update
    void Start()
    {
        if (isRight)
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
        else if (!isRight && transform.position.x <= left.position.x)
        {
            nextpos = right.position;
            isRight = true;
        }
        transform.position = Vector3.MoveTowards(transform.position, nextpos, Time.deltaTime * speed);
    }
   
    public void OnCollisionEnter2D(Collision2D collision)

    {

        if (collision.gameObject.tag == "Player")
        {

            StartCoroutine(gm.fail());


        }
    }

}
