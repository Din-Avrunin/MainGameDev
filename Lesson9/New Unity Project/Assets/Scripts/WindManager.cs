using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WindManager : MonoBehaviour
{
    [SerializeField] GameObject tornadoInit;   
    AreaEffector2D d;
    [SerializeField] float time = 15;
    GameObject tornado;
    // Start is called before the first frame update
    public void Start()
    {
        Vector3 vecInit = new Vector3(0, 0, 0);
        tornado = Instantiate(tornadoInit, vecInit, Quaternion.identity);
        d = this.gameObject.GetComponent<AreaEffector2D>();
        setWind();
    }
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
    public void resetWind()
    {
        d.forceAngle = 0;
        d.forceMagnitude = 0;
        d.forceVariation = 0;
    }
    public void setWind()
    {
        int timeBetweenWindChanges = 5;
        int timeWindALlive = 2;
        d.forceMagnitude = -6;
        d.forceVariation = 3;
        StartCoroutine(randomWind(timeBetweenWindChanges,timeWindALlive));
        
    }
    IEnumerator randomWind(int t, int t2)
    {
        int[] lengthArr = { 35, 200, 140, -35 };
        int rand = Random.Range(0, lengthArr.Length);
        d.forceAngle = lengthArr[rand];
        Vector3 vec;

        if (rand == 0)
            vec = new Vector3(-9, -3, 0); //  bot left
        else if (rand == 1)
            vec = new Vector3(9, 3, 0); //  top right
        else if (rand == 2)
            vec = new Vector3(9, -3, 0); // bot right
        else 
            vec = new Vector3(-9, 3, 0);  // top left
        Debug.Log(tornado.transform.position);

        tornado.transform.position = vec;
        yield return new WaitForSeconds(t);
        d.forceAngle = 0;
        yield return new WaitForSeconds(t2);
        StartCoroutine(randomWind(t, t2));

    }
}
