using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cat : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        

        float otherX = player.transform.position.x;
        float otherY = player.transform.position.y;
        float x = transform.position.x;
        float y = transform.position.y;

        Vector3 vec = new Vector3(otherX - x, otherY - y, 0);
        vec *= Time.deltaTime * speed ;
        transform.position += vec;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")

        {
            GetComponent<AudioSource>().Play();
                
        }            
    }
}
