using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindManager : MonoBehaviour
{
    [SerializeField] float time = 15;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(timeToLive(time));
    }
    IEnumerator timeToLive(float s)
    {
        yield return new WaitForSeconds(s);
        Destroy(this.gameObject);
    }
}
