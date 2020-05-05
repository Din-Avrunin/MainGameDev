using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    [Tooltip("The number of seconds that the shield remains active")] [SerializeField] float duration;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("extra life given");
            ourScript.shem++;
            Destroy(gameObject);  // Destroy the shield itself - prevent double-use
        }
    }
}
