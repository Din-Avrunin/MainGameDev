using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{
    [SerializeField] float Speed = 5;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        float x = transform.position.x + (Speed * Time.deltaTime);
        transform.position = new Vector3(x, transform.position.y, 0);
    }
    public void setSpeed(float speed) {
        Speed = speed;
    }
}
