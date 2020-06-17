using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    Text txt;
    [SerializeField] static float score = 0;
    [SerializeField] int points = 100;
    [SerializeField] float timeBetweenScore = 1;

    //GameObject data;
    //Data data2;
    // Start is called before the first frame update
    void Start()
    {
        //data = GameObject.Find("Data");
        //data2 = data.GetComponent<Data>();
        score = PlayerPrefs.GetInt("score");
        txt = gameObject.GetComponent<Text>();
    }


    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime; // gets a coin every frame 
        //data2.setScore((int)score);
        PlayerPrefs.SetInt("score", (int)score);
        if (txt != null)
        {
            txt.text = "Score: " + PlayerPrefs.GetInt("score").ToString();
        }




    }
    public void updateScore()
    {
        score += points;
        PlayerPrefs.SetInt("score", (int)score);
    }

    public void resetScore()
    {
        PlayerPrefs.SetInt("score", 0);
        score = 0;
    }
}
