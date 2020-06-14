using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    Text text;
    [SerializeField] static float score = 0;
    [SerializeField] float realScore = 0;
    [SerializeField] int points = 100;
    [SerializeField] float timeBetweenScore = 1;
    // Start is called before the first frame update
    void Start()
    {
        text = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
       score += Time.deltaTime; // gets a coin every frame 
        realScore = (int)score;
        text.text = "score " + realScore;
        

    }
    public void updateScore()
    {
        score += points;
    }
   
}
