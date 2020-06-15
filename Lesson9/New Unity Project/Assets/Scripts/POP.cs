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
            Debug.Log("test 10");
            GameManager.fail();
            Debug.Log("test 12");
            Destroy(this.gameObject);
            Debug.Log("test 11");
        }
    }
}
