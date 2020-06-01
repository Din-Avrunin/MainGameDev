using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float speed = 5;
    [SerializeField] Animator animation;

    // Update is called once per frame
    void Update()
    {
        float axis = Input.GetAxis("Horizontal");
        if (axis > 0)
        {
            animation.SetBool("isRight", true);
        }
        else { animation.SetBool("isRight", false); }

        if (axis < 0)
        {
            animation.SetBool("isLeft", true);
        }
        else { animation.SetBool("isLeft", false); }

        Vector2 vec = transform.position;
        float x = transform.position.x + (speed * Time.deltaTime) * axis; //move right or left or not
        float y = transform.position.y + ( speed * Time.deltaTime) * Input.GetAxis("Vertical"); //move up or down or not
        transform.position = new Vector3(x,y,0);
    }
}
