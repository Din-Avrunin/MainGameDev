using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Coinscript : MonoBehaviour
{
    [SerializeField] ScoreManager sm;
    public void Start()
    {
       
    }


    public void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        string otherTag= other.gameObject.tag;
        if (otherTag == "Player") // if a player touches the gold coin, add to the score the number of points, and destroy the coin
        {

            sm.updateScore();
            Destroy(this.gameObject);
      
        }
        else if (otherTag == "Enemy" || otherTag == "Cat")
        {
            Destroy(this.gameObject);
        }
            
    }
}
