using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    Text text;
    [SerializeField] static float score = 0;
    [SerializeField] int points = 100;
    [SerializeField] float timeBetweenScore = 1;

    GameObject data;
    Data data2;

    
    

        // Start is called before the first frame update
        void Start()
    {
        data = GameObject.Find("Data");
        data2 = data.GetComponent<Data>();

        text = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
        score += Time.deltaTime; // gets a coin every frame 
        data2.setScore((int)score);
        text.text = "score " + data2.getScore();
        
            

    }
    public void updateScore()
    {
        score += points;
    }
   
}
