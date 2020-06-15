using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    [SerializeField] int lives;
    [SerializeField] int score;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    public void init()
    {
        lives = 5;
        score = 0;
    }
    public int getLives()
    {
        return lives;
    }
    public void setLives(int lives)
    {
        this.lives = lives;
    }
    public int getScore()
    {
        return score;
    }
    public void setScore(int score)
    {
        this.score = score;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
