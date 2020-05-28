using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float speed = 5;
    [SerializeField] Camera camera;
    private float width, height;
    private float objectWidth, objectHeight;


    void Start()
    {
        height = 2f * camera.orthographicSize /2;
        width = height * camera.aspect;
        objectWidth = transform.GetComponent<SpriteRenderer>().bounds.size.x / 2;
        objectHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vec = transform.position;
        float x = transform.position.x + (speed * Time.deltaTime) * Input.GetAxis("Horizontal"); //move right or left or not
        float y = transform.position.y + ( speed * Time.deltaTime) * Input.GetAxis("Vertical"); //move up or down or not
        
        
        //prevents the player from exceeding the boarder
        x = Mathf.Clamp(x, width*-1+ objectWidth, width- objectWidth);
        y = Mathf.Clamp(y, height*-1+ objectHeight, height- objectHeight);

        transform.position = new Vector3(x,y,0);
    }
}
