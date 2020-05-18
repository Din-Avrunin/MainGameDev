using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_player : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float scrollTime;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, Math.Max(transform.position.y + scrollTime * Time.deltaTime, player.position.y),-10);
    }
}
