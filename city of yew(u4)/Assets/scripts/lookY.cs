using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookY : MonoBehaviour
{
    [SerializeField] float mouseSensitivity = 1;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        float my = Input.GetAxis("Mouse Y");
        Vector3 rotation = transform.localEulerAngles;
        rotation.x -= my * mouseSensitivity;
        transform.localEulerAngles = rotation;

    }
}
