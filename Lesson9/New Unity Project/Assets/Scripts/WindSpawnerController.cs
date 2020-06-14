using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindSpawnerController : MonoBehaviour
{
    [SerializeField] GameObject SpawnerWindLeft;
    [SerializeField] GameObject SpawnerWindRight;
    [SerializeField] float time = 15;
    [SerializeField] Boolean startLeft = true;
    // Start is called before the first frame update
    void Start()
    {
        
        if (startLeft) SpawnerWindRight.SetActive(false);
        else SpawnerWindLeft.SetActive(false);
        StartCoroutine(timeToSwitchWindSpawn(time));
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    IEnumerator timeToSwitchWindSpawn(float s)
    {
        yield return new WaitForSeconds(s);
        if (startLeft)
        {
            SpawnerWindLeft.SetActive(false);
            yield return new WaitForSeconds(1);
            SpawnerWindRight.SetActive(true);
            startLeft = !startLeft;
        }
        else
        {
            SpawnerWindRight.SetActive(false);
            yield return new WaitForSeconds(1);
            SpawnerWindLeft.SetActive(true);
            startLeft = !startLeft;
        }
        StartCoroutine(timeToSwitchWindSpawn(s));
    }
}

