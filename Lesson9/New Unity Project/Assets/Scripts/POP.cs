using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POP : MonoBehaviour
{
    [SerializeField] GameManager GameManager;
    // Start is called before the first frame update
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy") {
            GameManager.fail();
            Destroy(this.gameObject);
        }
    }
}
