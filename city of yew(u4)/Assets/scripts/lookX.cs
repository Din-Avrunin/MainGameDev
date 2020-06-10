using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookX : MonoBehaviour
{
    [SerializeField] float mouseSensitivity = 1;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mx = Input.GetAxis("Mouse X");
        Vector3 rotation = transform.localEulerAngles;
        rotation.y += mx * mouseSensitivity;
        transform.localEulerAngles = rotation;

    }
}
