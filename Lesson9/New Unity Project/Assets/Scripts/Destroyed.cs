using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using UnityEngine;

public class Destroyed : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float NumberofCollisions = 2;
    [SerializeField] Animator animator;
    [SerializeField] float WaitForDestroy = 1;
    [SerializeField] float blockedGravity = 1;
    Throw Throw;
    Rigidbody2D rg;
     public void OnCollisionEnter2D(Collision2D collision)
    {
        string tag = collision.gameObject.tag;
        if (tag == "Player" || tag=="Boarder") {
            NumberofCollisions--;
            if (NumberofCollisions == 0) {
                animator.SetBool("isBreak", true);
                Throw = gameObject.GetComponent<Throw>();
                Throw.setSpeed(0);
                rg= gameObject.GetComponent<Rigidbody2D>();
                rg.gravityScale = blockedGravity;
                StartCoroutine(w(WaitForDestroy));
                
                
            }
        }
    }
    public IEnumerator w(float s)
    {
        yield return new WaitForSeconds(s);
        Destroy(this.gameObject);

    }
}
